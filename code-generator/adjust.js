// Adjust swagger spec, because it is not 100% correct
import yaml from 'js-yaml'
import fs from 'fs'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// Get rid of Binary: https://git.ringcentral.com/platform/api-metadata-specs/issues/22
// delete doc.definitions.Binary
// Object.keys(doc.paths).forEach(path => {
//   // console.log(path)
//   Object.keys(doc.paths[path]).forEach(method => {
//     // console.log(method)
//     const responses = doc.paths[path][method].responses
//     if (responses && responses.default && responses.default.schema && responses.default.schema['$ref'] === '#/definitions/Binary') {
//       delete responses.default.schema['$ref']
//       responses.default.schema = {
//         type: 'string',
//         format: 'binary'
//       }
//     }
//   })
// })

// Support multiple attachments: https://git.ringcentral.com/platform/api-metadata-specs/issues/21
const sendFaxParams = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax'].post.parameters
const faxAttachment = sendFaxParams.filter(p => p.name === 'attachment')[0]
// if (faxAttachment.type === 'file') {
faxAttachment.type = 'array'
faxAttachment.collectionFormat = 'multi'
faxAttachment.items = { type: 'file' }
faxAttachment.name = 'attachments'
// }
// fix send fax "to" parameter
const faxTo = sendFaxParams.filter(p => p.name === 'to')[0]
if (faxTo.items.type === 'string') {
  delete faxTo.items.type
  faxTo.items['$ref'] = '#/definitions/MessageStoreCallerInfoRequest'
}

// // Add code & redirect_uri for getToken: https://git.ringcentral.com/platform/api-metadata-specs/issues/25
// doc.paths['/restapi/oauth/token'].post.parameters.push({
//   name: 'code',
//   in: 'formData',
//   required: false,
//   type: 'string',
//   description: 'The authorization code that the client previously received from the authorization server'
// })
// doc.paths['/restapi/oauth/token'].post.parameters.push({
//   name: 'redirect_uri',
//   in: 'formData',
//   required: false,
//   type: 'string',
//   description: 'The redirect URI in the token request must be an exact match of the redirect URI that was used when generating the authorization code'
// })

// // fix message attachment response type issue: https://git.ringcentral.com/platform/api-metadata-specs/issues/29
// const messageAttachment = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}'].get.responses[200]
// if (!messageAttachment.schema) {
//   messageAttachment.schema = {
//     type: 'string',
//     format: 'binary'
//   }
// }

// // fix recording content response type issue: https://git.ringcentral.com/platform/api-metadata-specs/issues/30
// const recordingContent = doc.paths['/restapi/v1.0/account/{accountId}/recording/{recordingId}/content'].get.responses[200]
// if (!recordingContent.schema) {
//   recordingContent.schema = {
//     type: 'string',
//     format: 'binary'
//   }
// }

// // add audio property to greeting update request: https://git.ringcentral.com/platform/api-metadata-specs/issues/33
// let props = doc.definitions['CustomGreetingRequest'].properties
// if (!props.audio) {
//   props.audio = {
//     type: 'file',
//     description: 'Custom greeting audio'
//   }
// }
// props = doc.definitions['CustomCompanyGreetingRequest'].properties
// if (!props.audio) {
//   props.audio = {
//     type: 'file',
//     description: 'Custom greeting audio'
//   }
// }

// // add user greetings list response type: https://git.ringcentral.com/platform/api-metadata-specs/issues/34
// const response = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule'].get.responses['200']
// if (!response.schema) {
//   response.schema = {
//     '$ref': '#/definitions/UserAnsweringRuleList'
//   }
//   doc.definitions['UserAnsweringRuleList'] = {
//     type: 'object',
//     properties: {
//       uri: {
//         type: 'string',
//         description: 'Link to an answering rule resource'
//       },
//       records: {
//         type: 'array',
//         description: 'List of user answering rules',
//         items: {
//           $ref: '#/definitions/ListCompanyAnsweringRuleInfo'
//         }
//       },
//       paging: {
//         description: 'Information on paging',
//         $ref: '#/definitions/CallHandlingPagingInfo'
//       },
//       navigation: {
//         description: 'Information on navigation',
//         $ref: '#/definitions/CallHandlingNavigationInfo'
//       }
//     }
//   }
// }

// https://git.ringcentral.com/platform/api-metadata-specs/issues/45
doc.paths['/restapi/v1.0/number-porting/verify-number'] = doc.paths['/v1.0/number-porting/verify-number']
delete doc.paths['/v1.0/number-porting/verify-number']

// https://git.ringcentral.com/platform/api-metadata-specs/issues/46
const responses = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image'].get.responses
delete responses[204]
responses[200] = {
  description: 'User Profile Image Media Data',
  schema: {
    type: 'string',
    format: 'binary'
  }
}

// https://git.ringcentral.com/platform/api-metadata-specs/issues/47
doc.definitions['PersonalContactResource'].properties.id = {
  type: 'string'
}

// remove duplicate scim endpoints
delete doc.paths['/scim/health']
delete doc.paths['/scim/Users']

// https://git.ringcentral.com/platform/api-metadata-specs/issues/48
const p1 = doc.paths['/restapi/v1.0/account/{accountId}/greeting'].post
p1.parameters = p1.parameters.filter(p => p.name !== 'answeringRuleId')
p1.parameters.push({
  name: 'answeringRule',
  in: 'formData',
  '$ref': '#/definitions/CustomCompanyGreetingAnsweringRuleInfo'
})
const p2 = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting'].post
p2.parameters = p2.parameters.filter(p => p.name !== 'answeringRuleId')
p2.parameters.push({
  name: 'answeringRule',
  in: 'formData',
  '$ref': '#/definitions/CustomGreetingAnsweringRuleInfoRequest'
})
doc.definitions['CustomCompanyGreetingAnsweringRuleInfo'] = doc.definitions['CustomGreetingAnsweringRuleInfoRequest'] = {
  type: 'object',
  properties: {
    id: {
      type: 'string'
    }
  }
}

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
