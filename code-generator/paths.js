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

const getRoutes = (prefix, name) => {
  return [...prefix.split('/').filter(t => t !== ''), name].map(t => changeCase.pascalCase(t))
}
const getFolderPath = (prefix, name) => {
  return path.join(outputDir, ...getRoutes(prefix, name))
}

const generate = (prefix = '/') => {
  const nextLevels = R.pipe(
    R.map(p => p.split(prefix).filter(t => !R.isEmpty(t))[0]),
    R.filter(t => !R.isNil(t)),
    R.uniq
  )(normalizedPaths)
  if (R.isEmpty(nextLevels)) {
    return
  }
  console.log(nextLevels)

  R.forEach(name => {
    const routes = getRoutes(prefix, name)
    console.log(routes)
    const folderPath = getFolderPath(prefix, name)
    console.log(folderPath)
    fs.mkdirSync(folderPath)
    var paramName = R.pipe(
      R.filter(p => p.startsWith(`${prefix}${name}/{`)),
      R.uniqBy(p => R.take(2, p.split('/').filter(t => t !== '')).join('/')),
      R.map(p => R.init(R.tail(p.split('/')[2]))),
      R.head
    )(normalizedPaths)
    console.log(paramName)
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
    public class Index
    {
        public RestClient rc;`

    if (paramName) {
      code += `
        public string ${paramName};`
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
        public string Path()
        {
            if (${paramName} != null)
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

    code += `
    }
}`
    fs.writeFileSync(path.join(folderPath, 'Index.cs'), code)
  })(nextLevels)
}

generate()
