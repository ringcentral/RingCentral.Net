import yaml from 'js-yaml'
import fs from 'fs'
import * as R from 'ramda'
import changeCase from 'change-case'
import path from 'path'

const outputDir = '../RingCentral/Paths/Generated'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))
const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => p
  .replace(/\/restapi\/v1\.0/, '/restapi/{apiVersion}')
  .replace(/\/scim\/v2/, '/scim/{version}')
  .replace(/\/\.search/, '/dotSearch')
)
const deNormalizePath = path => {
  return path
    .replace(/\/restapi\/\{apiVersion\}/, '/restapi/v1.0')
    .replace(/\/scim\/\{version\}/, '/scim/v2')
    .replace(/\/dotSearch/, '/.search')
}

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
        public string ${paramName};
`
    }

    if (paramName) {
      code += `
        public Index(RestClient rc, string ${paramName} = ${defaultParamValue ? `"${defaultParamValue}"` : null})
        {
            this.rc = rc;
            this.${paramName} = ${paramName};
        }`
    } else {
      code += `
        public Index(RestClient rc)
        {
            this.rc = rc;
        }`
    }

    if (paramName) {
      code += `

        public string Path(bool withParameter = true)
        {
            if (withParameter)
            {
                return $"/${name}/{${paramName}}";
            }

            return "/${name}";
        }`
    } else {
      code += `
        public string Path()
        {
            return "/${name}";
        }`
    }

    const operations = []
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
      const responseSchema = (responses[200] || responses[201] || responses[204] || responses.default).schema
      let responseType = 'string'
      if (responseSchema) {
        responseType = R.last(responseSchema['$ref'].split('/'))
      }
      code += `

        public async Task<${responseType}> ${smartMethod}()
        {
            return await rc.${method}<${responseType}>(this.Path(${(paramName && !operation.endpoint.endsWith('}')) ? 'false' : ''}));
        }`
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

    // generate(`${prefix}${name}/`) // todo: uncomment this line
  })(nextLevels)
}

generate('/')
generate('/scim/')
generate('/scim/{version}/')
generate('/scim/{version}/Users/')
