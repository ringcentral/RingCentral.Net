import yaml from 'js-yaml'
import fs from 'fs'
import * as R from 'ramda'

const outputDir = '../RingCentral/Paths/Generated'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

let paths = Object.keys(doc.paths)
paths.forEach(p => console.log(p))

paths = paths.map(p => p.replace('/restapi/v1.0', '/restapi/{apiVersion}')
  .replace('/scim/v2', '/scim/{scimVersion}')
  .replace('/.search', '/DotSearch')
)
paths.forEach(p => console.log(p))

const firstLevels = R.pipe(
  R.map(p => p.split('/').filter(t => !R.isEmpty(t))[0]),
  R.uniq
)(paths)
console.log(firstLevels)

firstLevels.forEach(fl => {
  console.log(`/${fl}:`)
  const path = doc.paths[`/${fl}`]
  if (path) {
    const methods = Object.keys(path)
    console.log(methods)
  }
  const regexp = new RegExp(`/${fl}/(\{[A-Za-z]+\}|v[0-9.]+)`)
  const parameters = R.pipe(
    R.map(p => p.match(regexp)),
    R.filter(m => m !== null),
    R.map(m => m[1]),
    R.uniq
  )(paths)
  console.log('Parameters: ', parameters)
})
