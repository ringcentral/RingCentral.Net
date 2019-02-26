import yaml from 'js-yaml'
import fs from 'fs'
import * as R from 'ramda'
import changeCase from 'change-case'
import path from 'path'

import { normalizedPath, deNormalizePath } from './utils'

const outputDir = '../RingCentral.Net/Paths'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform-adjusted.yml', 'utf8'))

// Delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => normalizedPath(p))

const getRoutes = (prefix, name) => {
  return [...prefix.split('/').filter(t => t !== '' && !t.startsWith('{')), name].map(t => changeCase.pascalCase(t))
}
const getFolderPath = (prefix, name) => {
  return path.join(outputDir, ...getRoutes(prefix, name))
}

const generate = (prefix = '/') => {
  const nextLevels = R.pipe(
    R.filter(p => p.startsWith(prefix)),
    R.map(p => p.substring(prefix.length).split('/').filter(t => t !== '')[0]),
    R.filter(t => !R.isNil(t) && !t.startsWith('{')),
    R.uniq
  )(normalizedPaths)
  if (R.isEmpty(nextLevels)) {
    return
  }
  console.log('nextLeves', nextLevels)

  R.forEach(name => {
    console.log('prefix', prefix)
    console.log('name', name)
    const routes = getRoutes(prefix, name)
    console.log('routes', routes)
    const folderPath = getFolderPath(prefix, name)
    console.log('folderPath', folderPath)
    if (fs.existsSync(folderPath)) {
      console.log('folder already exists')
      return
    }
    fs.mkdirSync(folderPath)
    const paramName = R.pipe(
      R.filter(p => p.startsWith(`${prefix}${name}/{`)),
      R.map(p => p.substring(`${prefix}${name}/`.length)),
      R.map(p => p.split('/').filter(t => t !== '')[0]),
      R.map(t => t.substring(1, t.length - 1)),
      R.head
    )(normalizedPaths)
    if (paramName) {
      console.log('paramName', paramName)
    }
    let defaultParamValue
    if (name === 'restapi' && paramName === 'apiVersion') {
      defaultParamValue = 'v1.0'
    } else if (name === 'scim' && paramName === 'version') {
      defaultParamValue = 'v2'
    } else if (name === 'account' && paramName === 'accountId') {
      defaultParamValue = '~'
    } else if (name === 'extension' && paramName === 'extensionId') {
      defaultParamValue = '~'
    }

    let code = `namespace RingCentral.Paths.${routes.join('.')}
{
    public partial class Index
    {
        public RestClient rc;`

    if (paramName) {
      code += `
        public string ${paramName};`
    }
    if (routes.length > 1) {
      code += `
        public ${R.init(routes).join('.')}.Index parent;`
    }

    if (paramName) {
      code += `

        public Index(${routes.length > 1 ? `${R.init(routes).join('.')}.Index parent` : 'RestClient rc'}, string ${paramName} = ${defaultParamValue ? `"${defaultParamValue}"` : null})
        {
          ${routes.length > 1 ? `  this.parent = parent;
            this.rc = parent.rc;` : '  this.rc = rc;'}
            this.${paramName} = ${paramName};
        }`
    } else {
      code += `

        public Index(${routes.length > 1 ? `${R.init(routes).join('.')}.Index parent` : 'RestClient rc'})
        {
            ${routes.length > 1 ? `this.parent = parent;
            this.rc = parent.rc;` : '  this.rc = rc;'}
        }`
    }

    if (paramName) {
      code += `

        public string Path(bool withParameter = true)
        {
            if (withParameter && ${paramName} != null)
            {
                return $"${routes.length > 1 ? '{parent.Path()}' : ''}/${name}/{${paramName}}";
            }

            return ${routes.length > 1 ? '$"{parent.Path()}' : '"'}/${name}";
        }`
    } else {
      code += `

        public string Path()
        {
            return ${routes.length > 1 ? '$"{parent.Path()}' : '"'}/${name.replace('dotSearch', '.search')}";
        }`
    }

    let operations = []
    const endpoints = [deNormalizePath(`${prefix}${name}`)]
    if (paramName) {
      endpoints.push(`${deNormalizePath(`${prefix}${name}`)}/{${paramName}}`)
    }
    endpoints.forEach(endpoint => {
      console.log('endpoint', endpoint)
      const endpointObj = doc.paths[endpoint]
      if (endpointObj) {
        const methods = Object.keys(endpointObj)
        console.log('HTTP methods', methods)
        methods.forEach(method => {
          // remove duplicate DELETE operation
          // it's OK to have duplicate GETs since we have both Get and List
          operations = operations.filter(op => op.method === 'get' || op.method !== method)
          operations.push({
            endpoint,
            method,
            detail: endpointObj[method]
          })
        })
      }
    })
    if (operations.length > 0) {
      code = `using System.Threading.Tasks;

${code}`
    }

    operations.forEach(operation => {
      const method = changeCase.pascalCase(operation.method)
      const smartMethod = (operation.method === 'get' && !operation.endpoint.endsWith('}') &&
        R.any(o => o.method === 'get' && o.endpoint === operation.endpoint + `/{${paramName}}`)(operations)) ? 'List' : method
      const responses = operation.detail.responses
      const responseSchema = (responses[200] || responses[201] || responses[202] || responses[204] || responses[205] || responses[302] || responses.default).schema
      let responseType = 'string'
      if (responseSchema) {
        if (responseSchema.type === 'string' && responseSchema.format === 'binary') {
          responseType = 'byte[]'
        } else if (responseSchema['$ref']) {
          responseType = 'RingCentral.' + R.last(responseSchema['$ref'].split('/'))
        }
      }

      let body, bodyClass, bodyParam, formUrlEncoded, formData, mixed
      if (operation.detail.consumes && operation.detail.consumes[0] === 'application/x-www-form-urlencoded') {
        formUrlEncoded = true
      } else if (operation.detail.consumes && operation.detail.consumes[0] === 'multipart/form-data') {
        formData = true
      } else if (operation.detail.consumes && operation.detail.consumes[0] === 'multipart/mixed') {
        formData = true
        mixed = true
      } else if (operation.detail.consumes && !operation.detail.consumes.some(c => c === 'application/json') && !operation.detail.consumes.some(c => c.startsWith('text/'))) {
        throw new Error(`Unsupported consume content type: ${operation.detail.consumes.join(', ')}`)
      } else {
        body = (operation.detail.parameters || []).filter(p => p.in === 'body')[0]
        if (body) {
          if (body.schema.type === 'string') {
            bodyClass = 'string'
            bodyParam = 'body'
          } else {
            bodyClass = R.last(body.schema['$ref'].split('/'))
            bodyParam = changeCase.lowerCaseFirst(bodyClass)
            bodyClass = 'RingCentral.' + bodyClass
          }
        }
      }
      if (formUrlEncoded || formData) {
        bodyClass = `${changeCase.pascalCase(operation.detail.operationId)}Request`
        bodyParam = `${operation.detail.operationId}Request`
      }
      if (mixed) {
        body = (operation.detail.parameters || []).filter(p => p.in === 'body')[0]
        bodyClass = R.last(body.schema['$ref'].split('/'))
        bodyParam = changeCase.lowerCaseFirst(bodyClass)
        bodyClass = 'RingCentral.' + bodyClass
      }

      const queryParams = (operation.detail.parameters || []).filter(p => p.in === 'query')
      const withParam = paramName && operation.endpoint.endsWith('}')
      const methodParams = []
      if (bodyParam) {
        methodParams.push(`${bodyClass} ${bodyParam}`)
      }
      if (queryParams.length > 0) {
        methodParams.push(`${changeCase.pascalCase(operation.detail.operationId)}Parameters queryParams = null`)
      }
      code += `

      public async Task<${responseType}> ${smartMethod}(${methodParams.join(', ')})
      {${withParam ? `
          if (this.${paramName} == null)
          {
              throw new System.ArgumentNullException("${paramName}");
          }
` : ''}`
      if (formUrlEncoded) {
        code = `using System.Linq;
using System.Net.Http;
${code}`
        code += `
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            RingCentral.Utils.GetPairs(${bodyParam})
              .ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''}), new FormUrlEncodedContent(dict)${queryParams.length > 0 ? `, queryParams` : ''});
        }`
      } else if (formData) {
        code += `
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(${bodyParam});
            return await rc.Post<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''}), multipartFormDataContent${queryParams.length > 0 ? `, queryParams` : ''});
        }`
      } else {
        code += `
            return await rc.${method}<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''})${bodyParam ? `, ${bodyParam}` : ''}${queryParams.length > 0 ? `, queryParams` : ''});
        }`
      }
    })

    code += `
    }
}`

    if (routes.length === 1) { // top level path, such as /restapi & /scim
      code = `${code}

namespace RingCentral
{
    public partial class RestClient
    {
        public Paths.${R.last(routes)}.Index ${R.last(routes)}(${paramName ? `string ${paramName} = ${defaultParamValue ? `"${defaultParamValue}"` : 'null'}` : ''})
        {
            return new Paths.${R.last(routes)}.Index(this${paramName ? `, ${paramName}` : ''});
        }
    }
}`
    } else {
      code = `${code}

namespace RingCentral.Paths.${R.init(routes).join('.')}
{
    public partial class Index
    {
        public ${routes.join('.')}.Index ${R.last(routes)}(${paramName ? `string ${paramName} = ${defaultParamValue ? `"${defaultParamValue}"` : 'null'}` : ''})
        {
            return new ${routes.join('.')}.Index(this${paramName ? `, ${paramName}` : ''});
        }
    }
}`
    }
    fs.writeFileSync(path.join(folderPath, 'Index.cs'), code)

    generate(`${prefix}${name}/`)
    if (paramName) {
      generate(`${prefix}${name}/{${paramName}}/`)
    }
  })(nextLevels)
}

generate('/')
