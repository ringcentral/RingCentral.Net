// adjust swagger spec, because it is not 100% correct
import yaml from 'js-yaml'
import fs from 'fs'

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
const faxAttachment = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax'].post.parameters.filter(p => p.name === 'attachment')[0]
if (faxAttachment.type === 'file') {
  faxAttachment.type = 'array'
  faxAttachment.collectionFormat = 'multi'
  faxAttachment.items = { type: 'file' }
}

// delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
