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

let md = `# RingCentral.Net SDK Code samples`
normalizedPaths.forEach(path => {
  console.log(path)
  const names = path.split('/').filter(name => name !== '' && !name.startsWith('{'))
  console.log(names)
  var gCode = fs.readFileSync(`../RingCentral.Net/Paths/${names.map(n => changeCase.pascalCase(n)).join('/')}/Index.cs`, 'utf-8')
  const ms = gCode.match(/\/\/ Operation: .+?\n\s*.+?\s*\n\s*.+?\s*\n/g)
    .map(f => {
      console.log(f)
      const ms = f.match(/Operation: (.+?)\s*\n\s*\/\/ Http (.+?)\s*\n.+?(Get|List|Post|Put|Patch|Delete)\((.*?)\)/)
      const operationId = ms[1]
      const endpoint = ms[2].split(' ')[1]
      const method = ms[3]
      const parameters = ms[4].split(',').map(t => t.trim().split(' ').map(tt => tt.trim())[0]).filter(p => p !== '').map(p => R.last(p.split('.')))
      return { operationId, endpoint, method, parameters }
    })
  console.log(ms)
  ms.forEach(({ operationId, endpoint, method, parameters }) => {
    if (endpoint === deNormalizePath(path)) {
      let code = `


## ${changeCase.sentenceCase(operationId)}

HTTP ${changeCase.upperCase(method === 'List' ? 'Get' : method)} \`${endpoint}\`

\`\`\`cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await ${pathToCode(path)}.${method}(${parameters.map(p => changeCase.camelCase(p)).join(', ')});
}
\`\`\`

${parameters.map(p => `- Parameter \`${changeCase.camelCase(p)}\` is of type [${p}](./RingCentral.Net/Definitions/${p}.cs)`).join('\n')}`

      const responses = doc.paths[endpoint][changeCase.lowerCase(method === 'List' ? 'Get' : method)].responses
      const responseType = getResponseType(responses)
      if (!responseType) {
        code += '\n- `result` is an empty string'
      } else if (responseType.startsWith('RingCentral.')) {
        const className = responseType.substring(12)
        code += `\n- \`result\` is of type [${className}](./RingCentral.Net/Definitions/${className}.cs)`
      } else {
        code += `\n- \`result\` is of type \`${responseType}\``
      }

      if (code.includes('.Restapi(apiVersion)')) {
        code += '\n- Parameter `apiVersion` is optional with default value `v1.0`'
      }
      if (code.includes('.Account(accountId)')) {
        code += '\n- Parameter `accountId` is optional with default value `~`'
      }
      if (code.includes('.Extension(extensionId)')) {
        code += '\n- Parameter `extensionId` is optional with default value `~`'
      }
      if (code.includes('.Scim(version)')) {
        code += '\n- Parameter `version` is optional with default value `v2`'
      }
      md += code
    }
  })
})

fs.writeFileSync('../samples.md', md)
