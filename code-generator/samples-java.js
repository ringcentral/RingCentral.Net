import yaml from 'js-yaml'
import fs from 'fs'
import { pascalCase, camelCase } from 'change-case'

import { normalizePath, getResponseType } from './utils'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// Delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => normalizePath(p)).sort()

const pathToCode = path => {
  let names = path.split('/').filter(name => name !== '').map(name => {
    if (name.startsWith('{')) {
      return `(${name.substring(1, name.length - 1)})`
    } else {
      return camelCase(name)
    }
  })
  names = names.map((name, index) => {
    if (name.startsWith('(')) {
      return name
    } else if (index === names.length - 1) {
      return name + '()'
    } else if (names[index + 1].startsWith('(')) {
      return name
    } else {
      return name + '()'
    }
  })
  return 'rc.' + names.join('.').replace(/\.\(/g, '(')
}

let md = '# RingCentral Java SDK Code Samples'
normalizedPaths.forEach(path => {
  console.log(path)
  const names = path.split('/').filter(name => name !== '' && !name.startsWith('{'))
  const gCode = fs.readFileSync(`../RingCentral.Net/Paths/${names.map(n => pascalCase(n)).join('/')}/Index.cs`, 'utf-8')
  const summaries = gCode.match(/\/\/\/ <summary>[\s\S]+?\/\/\/ <\/summary>[\s\S]+?\([\s\S]+?\)/g)
  for (const summary of summaries) {
    const comments = summary.match(/\/\/\/ <summary>([\s\S]+?)\/\/\/ <\/summary>/)[1].trim().split('\n').map(l => l.trim().split(': ').map(t => t.trim()))
    const title = comments.shift()[1]
    let code = `\n\n\n## ${title}\n
Name|Value\n-|-\n${comments.map(c => `${c[0].substring(4)}|\`${c[1] === 'undefined' ? 'N/A' : c[1]}\``).join('\n')}
`
    const match = summary.match(/\/\/\/ <\/summary>[\s\S]+?(\S+?)\(([\s\S]+?)\)/)
    const method = match[1]
    const parameters = match[2].trim().split(/,\s+/).map(p => p.split(' ')[0].trim())
      .filter(p => p !== 'CancellationToken?').map(p => p.startsWith('RingCentral.') ? p.substring(12) : p)
    code += `
\`\`\`java
RestClient rc = new RestClient(clientID, clientSecret, serverURL);
rc.authorize(username, extension, password);
var result = ${pathToCode(path).replace(/\.[A-Z]/g, (m) => m.toLowerCase())}.${method.toLowerCase()}(${parameters.map(p => camelCase(p)).join(', ')});
rc.revoke();
\`\`\`
${parameters.map(p => `- Parameter \`${camelCase(p)}\` is of type [${p}](./src/main/java/com/ringcentral/definitions/${p}.java)`).join('\n')}`
    const httpMethod = comments.shift()[1]
    const endpoint = comments.shift()[1]
    // because `.../message-store` and `.../message-store/{messageId}` are in the same file
    if (endpoint.endsWith('}') === path.endsWith('}')) {
      const responses = doc.paths[endpoint][httpMethod.toLowerCase()].responses
      const responseType = getResponseType(responses)
      if (!responseType) {
        code += '\n- `result` is `null`'
      } else if (responseType.startsWith('RingCentral.')) {
        const className = responseType.substring(12)
        code += `\n- \`result\` is of type [${className}](./src/main/java/com/ringcentral/definitions/${className}.java)`
      } else {
        code += `\n- \`result\` is of type \`${responseType}\``
      }
      if (code.includes('.restapi(apiVersion)')) {
        code += '\n- Parameter `apiVersion` is optional with default value `v1.0`'
      }
      if (code.includes('.account(accountId)')) {
        code += '\n- Parameter `accountId` is optional with default value `~`'
      }
      if (code.includes('.extension(extensionId)')) {
        code += '\n- Parameter `extensionId` is optional with default value `~`'
      }
      if (code.includes('.scim(version)')) {
        code += '\n- Parameter `version` is optional with default value `v2`'
      }
      const operation = doc.paths[endpoint][httpMethod.toLowerCase()]
      code += `\n\n[Try it out](https://developer.ringcentral.com/api-reference#${operation.tags[0].replace(/ /g, '-')}-${operation.operationId}) in API Explorer.`

      if (responseType === 'byte[]') {
        code += `\n\n### ❗❗❗ Code sample above may not work
\nPlease refer to [Binary content downloading](/README.md#Binary-content-downloading).`
      }
      md += code
    }
  }
})

fs.writeFileSync('/Users/tyler.liu/src/java/ringcentral-java/samples.md', md)
