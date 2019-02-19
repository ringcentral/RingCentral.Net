// Adjust swagger spec, because it is not 100% correct
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

// Delete /restapi/oauth/authorize: https://git.ringcentral.com/platform/api-metadata-specs/issues/26
delete doc.paths['/restapi/oauth/authorize']

// Add code & redirect_uri for getToken: https://git.ringcentral.com/platform/api-metadata-specs/issues/25
doc.paths['/restapi/oauth/token'].post.parameters.push({
  name: 'code',
  in: 'formData',
  required: false,
  type: 'string',
  description: 'The authorization code that the client previously received from the authorization server'
})
doc.paths['/restapi/oauth/token'].post.parameters.push({
  name: 'redirect_uri',
  in: 'formData',
  required: false,
  type: 'string',
  description: 'The redirect URI in the token request must be an exact match of the redirect URI that was used when generating the authorization code'
})

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
