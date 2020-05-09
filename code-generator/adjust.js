// Adjust swagger spec, because it is not 100% correct
import yaml from 'js-yaml'
import fs from 'fs'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform.yml', 'utf8'))

// remove duplicate scim endpoints
delete doc.paths['/scim/health']
delete doc.paths['/scim/Users']
delete doc.paths['/scim/ServiceProviderConfig']

// MMS
doc.definitions.CreateMMSMessage = JSON.parse(JSON.stringify(doc.definitions.CreateSMSMessage))
doc.definitions.CreateMMSMessage.properties.attachments = {
  description: 'Files to send',
  type: 'array',
  collectionFormat: 'multi',
  items: {
    type: 'file'
  }
}
const faxBody = doc.paths['/restapi/v1.0/account/{accountId}/extension/{extensionId}/mms'].post.parameters.filter(p => p.name === 'body')[0]
faxBody.schema.$ref = '#/definitions/CreateMMSMessage'

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

// https://jira.ringcentral.com/browse/PLD-337
// https://github.com/ringcentral/RingCentral.Net/issues/12
// Fax to name
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

// // https://jira.ringcentral.com/browse/PLD-592
// array as definitions
const arrayTypes = Object.keys(doc.definitions).filter(key => doc.definitions[key].type === 'array')
for (const pathKey of Object.keys(doc.paths)) {
  const path = doc.paths[pathKey]
  for (const operationKey of Object.keys(path)) {
    const operation = path[operationKey]
    for (const responseKey of Object.keys(operation.responses)) {
      const response = operation.responses[responseKey]
      if (response.schema) {
        const at = arrayTypes.filter(at => response.schema.$ref === `#/definitions/${at}`)
        if (at.length > 0) {
          response.schema = doc.definitions[at[0]]
        }
      }
    }
  }
}

// https://jira.ringcentral.com/browse/PLD-696
// anonymous definitions
for (const dKey of Object.keys(doc.definitions)) {
  const properties = doc.definitions[dKey].properties
  if (!properties) {
    continue
  }
  for (const pKey of Object.keys(properties)) {
    let property = properties[pKey]
    if (!property.properties && property.items && property.items.properties) {
      property = property.items
    }
    if (property.properties) {
      const newDefinitionName = `${dKey}${pKey.charAt(0).toUpperCase() + pKey.slice(1)}`
      doc.definitions[newDefinitionName] = {
        type: 'object',
        properties: property.properties
      }
      delete property.properties
      property.$ref = `#/definitions/${newDefinitionName}`
      console.log(newDefinitionName)
    }
  }
}

// https://jira.ringcentral.com/browse/PLD-749
// Add "WebSocket" to NotificationDeliveryModeRequest.transportType
doc.definitions.NotificationDeliveryModeRequest.properties.transportType.enum.push('WebSocket')

fs.writeFileSync('rc-platform-adjusted.yml', yaml.safeDump(doc))
