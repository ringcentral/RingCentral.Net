// Adjust swagger spec, because it is not 100% correct
import yaml from 'js-yaml'
import fs from 'fs'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// remove duplicate scim endpoints
delete doc.paths['/scim/health']
delete doc.paths['/scim/Users']
delete doc.paths['/scim/ServiceProviderConfig']

// Support multiple attachments: https://git.ringcentral.com/platform/api-metadata-specs/issues/21
const sendFaxParams = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax'].post.parameters
const faxAttachment = sendFaxParams.filter(p => p.name === 'attachment')[0]
faxAttachment.type = 'array'
faxAttachment.collectionFormat = 'multi'
faxAttachment.items = { type: 'file' }
faxAttachment.name = 'attachments'
const faxTo = sendFaxParams.filter(p => p.name === 'to')[0]
if (faxTo.items.type === 'string') {
  delete faxTo.items.type
  faxTo.items['$ref'] = '#/definitions/MessageStoreCallerInfoRequest'
}

// https://git.ringcentral.com/platform/api-metadata-specs/issues/48
const p1 = doc.paths['/restapi/v1.0/account/{accountId}/greeting'].post
p1.parameters = p1.parameters.filter(p => p.name !== 'answeringRuleId')
p1.parameters.push({
  name: 'answeringRule',
  in: 'formData',
  $ref: '#/definitions/CustomCompanyGreetingAnsweringRuleInfo'
})
const p2 = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting'].post
p2.parameters = p2.parameters.filter(p => p.name !== 'answeringRuleId')
p2.parameters.push({
  name: 'answeringRule',
  in: 'formData',
  $ref: '#/definitions/CustomGreetingAnsweringRuleInfoRequest'
})
doc.definitions['CustomCompanyGreetingAnsweringRuleInfo'] = doc.definitions['CustomGreetingAnsweringRuleInfoRequest'] = {
  type: 'object',
  properties: {
    id: {
      type: 'string'
    }
  }
}

// https://jira.ringcentral.com/browse/PLD-316
doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer'] = doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/answer']
delete doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/answer']
doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/play'] = doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/play']
delete doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/play']
doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup'] = doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/pickup']
delete doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/pickup']

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
