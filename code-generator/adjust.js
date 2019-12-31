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
  faxTo.items.$ref = '#/definitions/MessageStoreCalleeInfoRequest'
}

// https://jira.ringcentral.com/browse/PLD-337?filter=-2
// https://github.com/ringcentral/RingCentral.Net/issues/12
doc.definitions.MessageStoreCalleeInfoRequest = {
  type: 'object',
  properties: {
    phoneNumber: {
      type: 'string',
      description: 'Phone number in E.164 format'
    },
    name: {
      type: 'string',
      description: 'Name of the callee'
    }
  }
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
doc.definitions.CustomCompanyGreetingAnsweringRuleInfo = doc.definitions.CustomGreetingAnsweringRuleInfoRequest = {
  type: 'object',
  properties: {
    id: {
      type: 'string'
    }
  }
}

// https://jira.ringcentral.com/browse/PLD-590
// doc.definitions.MeetingRecurrenceResource.properties.frequency = {
//   type: 'string',
//   enum: [
//     'Daily',
//     'Weekly',
//     'Monthly'
//   ]
// }
// const weekDay = {
//   type: 'string',
//   enum: [
//     'Sunday',
//     'Monday',
//     'Tuesday',
//     'Wednesday',
//     'Thursday',
//     'Friday',
//     'Saturday'
//   ]
// }
// doc.definitions.MeetingRecurrenceResource.properties.weeklyByDays.items = weekDay
// doc.definitions.MeetingRecurrenceResource.properties.monthlyByWeekDay = weekDay
// doc.definitions.MeetingRecurrenceResource.properties.monthlyByWeek = {
//   type: 'string',
//   enum: [
//     'Last',
//     'First',
//     'Second',
//     'Third',
//     'Fourth'
//   ]
// }

// delete doc.definitions.MeetingFrequency
// delete doc.definitions.WeekDay
// delete doc.definitions.MonthlyWeek

// https://jira.ringcentral.com/browse/PLD-591
// doc.paths['/restapi/v1.0/account/{accountId}/call-queues/{groupId}'].get.tags = ['Call Queues']
// doc.paths['/restapi/v1.0/account/{accountId}/call-queues/{groupId}'].put.tags = ['Call Queues']
// doc.paths['/restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence'].get.tags = ['Call Queues']
// doc.paths['/restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence'].put.tags = ['Call Queues']
// doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence'].get.tags = ['Call Queues']
// doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence'].put.tags = ['Call Queues']

// https://jira.ringcentral.com/browse/PLD-592
// doc.definitions.PlayTarget.properties.resources = doc.definitions.PlayResources
doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}'].get.responses['207'].schema = doc.definitions.GetMessageMultiResponse
doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}'].put.responses['207'].schema = doc.definitions.GetMessageMultiResponse
doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence'].get.responses['207'].schema = doc.definitions.UnifiedPresenceList

// https://jira.ringcentral.com/browse/PLD-593
doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise'] = doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/supervise']
delete doc.paths['/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/supervise']

// https://jira.ringcentral.com/browse/PLD-595
delete doc.definitions.GetExtensionInfoResponse.properties.account

// https://jira.ringcentral.com/browse/PLD-596
doc.definitions.GlipGroupInfo.properties.members.items = { type: 'string' }

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
