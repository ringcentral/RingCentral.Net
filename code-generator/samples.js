import yaml from 'js-yaml'
import fs from 'fs'
import changeCase from 'change-case'

import { normalizedPath } from './utils'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform-adjusted.yml', 'utf8'))
const paths = Object.keys(doc.paths)
const normalizedPaths = paths.map(p => normalizedPath(p))
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

normalizedPaths.forEach(path => {
  console.log(path)
  const names = path.split('/').filter(name => name !== '' && !name.startsWith('{'))
  console.log(names)
  let code = `using (var rc = new RestClient(
      Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
      Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
      Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
  ))
  {
      await rc.Authorize(
          Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
          Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
          Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
      );
      await ${pathToCode(path)}
  }`
  console.log(code)
})
