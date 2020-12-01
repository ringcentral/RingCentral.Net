import yaml from 'js-yaml'
import fs from 'fs'
import * as R from 'ramda'
import { pascalCase, capitalCase } from 'change-case'
import { lowerCaseFirst } from 'lower-case-first'
import path from 'path'

import { normalizePath, deNormalizePath, getResponseType } from './utils'

const outputDir = '../RingCentral.Net/Paths'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// Delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => normalizePath(p))

const getRoutes = (prefix, name) => {
  return [...prefix.split('/').filter(t => t !== '' && !t.startsWith('{')), name].map(t => pascalCase(t))
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
  console.log('nextLevels', nextLevels)

  R.forEach(name => {
    console.log('prefix', prefix)
    console.log('name', name)
    const routes = getRoutes(prefix, name)
    console.log('routes', routes)
    const folderPath = getFolderPath(prefix, name)
    console.log('folderPath', folderPath)
    const paramName = R.pipe(
      R.filter(p => p.startsWith(`${prefix}${name}/{`)),
      R.map(p => p.substring(`${prefix}${name}/`.length)),
      R.map(p => p.split('/').filter(t => t !== '')[0]),
      R.map(t => t.substring(1, t.length - 1)),
      R.head
    )(normalizedPaths)
    if (fs.existsSync(folderPath)) {
      console.log('folder already exists')
      generate(`${prefix}${name}/`)
      if (paramName) {
        generate(`${prefix}${name}/{${paramName}}/`)
      }
      return
    }
    fs.mkdirSync(folderPath)
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
    const usings = new Set()
    if (operations.length > 0) {
      usings.add('using System.Threading.Tasks;')
    }

    operations.forEach(operation => {
      const method = pascalCase(operation.method)
      const smartMethod = (operation.method === 'get' && !operation.endpoint.endsWith('}') &&
        R.any(o => o.method === 'get' && o.endpoint === operation.endpoint + `/{${paramName}}`)(operations)) ? 'List' : method
      const responses = operation.detail.responses
      let responseType = getResponseType(responses)
      if (!responseType) {
        responseType = 'string'
      }

      let body, bodyClass, bodyParam, formUrlEncoded, multipart
      if (operation.detail.requestBody && operation.detail.requestBody.content && operation.detail.requestBody.content['application/x-www-form-urlencoded']) {
        formUrlEncoded = true
      } else if (operation.detail.requestBody && operation.detail.requestBody.content && operation.detail.requestBody.content['multipart/form-data']) {
        multipart = true
      } else if (operation.detail.consumes && !operation.detail.consumes.some(c => c === 'application/json') && !operation.detail.consumes.some(c => c.startsWith('text/'))) {
        throw new Error(`Unsupported consume content type: ${operation.detail.consumes.join(', ')}`)
      } else {
        // body = (operation.detail.parameters || []).filter(p => p.in === 'body')[0]
        const requestBody = operation.detail.requestBody
        if(requestBody) {
          const content = requestBody.content
          body = content[Object.keys(content)[0]]
          if (body.schema.type === 'string') {
            bodyClass = 'string'
            bodyParam = 'body'
          } else {
            bodyClass = R.last(body.schema.$ref.split('/'))
            bodyParam = lowerCaseFirst(bodyClass)
            bodyClass = 'RingCentral.' + bodyClass
          }
        }
      }
      if (formUrlEncoded || multipart) {
        bodyClass = `${pascalCase(operation.detail.operationId)}Request`
        bodyParam = `${operation.detail.operationId}Request`
        // body = (operation.detail.parameters || []).filter(p => p.in === 'body' && p.schema && p.schema.$ref)[0]
        const content = operation.detail.requestBody.content
        body = content[Object.keys(content)[0]]
        if (body && body.schema && body.schema.$ref) {
          bodyClass = R.last(body.schema.$ref.split('/'))
          bodyParam = lowerCaseFirst(bodyClass)
          bodyClass = 'RingCentral.' + bodyClass
        }
      }

      const queryParams = (operation.detail.parameters || []).filter(p => p.in === 'query')
      const withParam = paramName && operation.endpoint.endsWith('}')
      const methodParams = []
      if (bodyParam) {
        methodParams.push(`${bodyClass} ${bodyParam}`)
      }
      if (queryParams.length > 0) {
        methodParams.push(`${pascalCase(operation.detail.operationId)}Parameters queryParams = null`)
      }
      methodParams.push('RestRequestConfig restRequestConfig = null')
      code += `

      /// <summary>
      /// Operation: ${operation.detail.summary || capitalCase(operation.detail.operationId)}
      /// HTTP Method: ${method.toUpperCase()}
      /// Endpoint: ${operation.endpoint}
      /// Rate Limit Group: ${operation.detail['x-throttling-group']}
      /// App Permission: ${operation.detail['x-app-permission']}
      /// User Permission: ${operation.detail['x-user-permission']}
      /// </summary>
      public async Task<${responseType}> ${smartMethod}(${methodParams.join(', ')})
      {${withParam ? `
          if (this.${paramName} == null)
          {
              throw new System.ArgumentNullException("${paramName}");
          }
` : ''}`
      if (formUrlEncoded) {
        usings.add('using System.Linq;')
        usings.add('using System.Net.Http;')
        code += `
          var dict = new System.Collections.Generic.Dictionary<string, string>();
          Utils.GetPairs(${bodyParam})
            .ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
          return await rc.${method}<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''}), new FormUrlEncodedContent(dict), ${queryParams.length > 0 ? 'queryParams' : 'null'}, restRequestConfig);
      }`
      } else if (multipart) {
        code += `
          var multipartFormDataContent = Utils.GetMultipartFormDataContent(${bodyParam});
          return await rc.${method}<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''}), multipartFormDataContent, ${queryParams.length > 0 ? 'queryParams' : 'null'}, restRequestConfig);
      }`
      } else {
        code += `
          return await rc.${method}<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''})${bodyParam ? `, ${bodyParam}` : ''}, ${queryParams.length > 0 ? 'queryParams' : 'null'}, restRequestConfig);
      }`
      }

      // // batch get
      // if (method === 'Get' && (
      //   (operation.detail.description && operation.detail.description.replace(/\s+/g, ' ').toLowerCase().includes('batch request is supported')) ||
      //   (operation.detail.parameters && operation.detail.parameters.some(p => p.in === 'path' && p.collectionFormat === 'csv'))
      // )) {
      //   code += `
      // public async Task<BatchResponse<${responseType}>[]> BatchGet(${methodParams.join(', ')})
      // {
      //     if (!this.Path(${(!withParam && paramName) ? 'false' : ''}).Contains(","))
      //     {
      //         throw new System.ArgumentException(
      //             "In order to make a BatchGet, please specify multiple IDs delimited by ','");
      //     }
      //     return await rc.BatchGet<${responseType}>(this.Path(${(!withParam && paramName) ? 'false' : ''}), ${queryParams.length > 0 ? 'queryParams' : 'null'}, restRequestConfig);
      // }`
      // }
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
    code = Array.from(usings).join('\n') + '\n\n' + code
    fs.writeFileSync(path.join(folderPath, 'Index.cs'), code)

    generate(`${prefix}${name}/`)
    if (paramName) {
      generate(`${prefix}${name}/{${paramName}}/`)
    }
  })(nextLevels)
}

generate('/')
