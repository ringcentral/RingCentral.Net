import yaml from 'js-yaml'
import fs from 'fs'

// adjust swagger spec, because it is not 100% correct

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// Get rid of Binary: https://git.ringcentral.com/platform/api-metadata-specs/issues/22
delete doc.definitions.Binary
Object.keys(doc.paths).forEach(path => {
  // console.log(path)
  Object.keys(doc.paths[path]).forEach(method => {
    // console.log(method)
    const responses = doc.paths[path][method].responses
    if (responses && responses.default && responses.default.schema && responses.default.schema['$ref'] === '#/definitions/Binary') {
      delete responses.default.schema['$ref']
      responses.default.schema = {
        type: 'string',
        format: 'binary'
      }
    }
  })
})

// Support multiple attachments: https://git.ringcentral.com/platform/api-metadata-specs/issues/21

fs.writeFileSync('rc-patform-adjusted.yml', yaml.safeDump(doc))
