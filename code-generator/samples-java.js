import yaml from 'js-yaml'
import fs from 'fs'
import changeCase from 'change-case'
import * as R from 'ramda'

import { normalizePath, deNormalizePath, getResponseType } from './utils'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform-adjusted.yml', 'utf8'))

// Delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => normalizePath(p)).sort()
console.log(normalizedPaths)

const pathToCode = path => {
  let names = path.split('/').filter(name => name !== '').map(name => {
    if (name.startsWith('{')) {
      return `(${name.substring(1, name.length - 1)})`
    } else {
      return changeCase.pascalCase(name)
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
  console.log(names)
  var gCode = fs.readFileSync(`../RingCentral.Net/Paths/${names.map(n => changeCase.pascalCase(n)).join('/')}/Index.cs`, 'utf-8')
  const ms = gCode.match(/\/\/\/ Operation: .+?\n\s*.+?\s*\n\s*\/\/\/ <\/summary>\s*\n\s*.+?\s*\n/g)
    .map(f => {
      console.log(f)
      const ms = f.match(/Operation: (.+?)\s*\n\s*\/\/\/ Http (.+?)\s*\n\s*\/\/\/ <\/summary>\s*\n\s*.+?(Get|List|Post|Put|Patch|Delete)\((.*?)\)/)
      const summary = ms[1]
      const endpoint = ms[2].split(' ')[1]
      const method = ms[3]
      const parameters = ms[4].split(',').map(t => t.trim().split(' ').map(tt => tt.trim())[0]).filter(p => p !== '').map(p => R.last(p.split('.')))
      return { summary, endpoint, method, parameters }
    })
  console.log(ms)
  ms.forEach(({ summary, endpoint, method, parameters }) => {
    if (endpoint === deNormalizePath(path)) {
      let code = `


## ${summary}

HTTP ${changeCase.upperCase(method === 'List' ? 'Get' : method)} \`${endpoint}\`

\`\`\`cs
RestClient rc = new RestClient("clientID", "clientSecret", "serverURL");
rc.authorize("username", "extension", "password");
var result = ${pathToCode(path).replace(/\.[A-Z]/g, (m) => m.toLowerCase())}.${method.toLowerCase()}(${parameters.map(p => changeCase.camelCase(p)).join(', ')});
rc.revoke();
\`\`\`

${parameters.map(p => `- Parameter \`${changeCase.camelCase(p)}\` is of type [${p}](./src/main/java/com/ringcentral/definitions/${p}.java)`).join('\n')}`

      const responses = doc.paths[endpoint][changeCase.lowerCase(method === 'List' ? 'Get' : method)].responses
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
      const operation = doc.paths[endpoint][changeCase.lowerCase(method === 'List' ? 'Get' : method)]
      code += `\n\n[Try it out](https://developer.ringcentral.com/api-reference#${operation.tags[0].replace(/ /g, '-')}-${operation.operationId}) in API Explorer.`
      md += code
    }
  })
})

fs.writeFileSync('/Users/tyler.liu/src/java/ringcentral-java/samples.md', md)
