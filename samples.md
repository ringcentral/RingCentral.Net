# RingCentral.Net SDK Code Samples


## Get API Versions

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi`
Rate Limit Group|`NoThrottling`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetVersionsResponse](./RingCentral.Net/Definitions/GetVersionsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersions) in API Explorer.


## Revoke Token

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/oauth/revoke`
Rate Limit Group|`Auth`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Revoke().Post(revokeTokenRequest, restRequestConfig);
}
```

- Parameter `revokeTokenRequest` is of type [RevokeTokenRequest](./RingCentral.Net/Definitions/RevokeTokenRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-revokeToken) in API Explorer.


## Get Token

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/oauth/token`
Rate Limit Group|`Auth`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Token().Post(getTokenRequest, restRequestConfig);
}
```

- Parameter `getTokenRequest` is of type [GetTokenRequest](./RingCentral.Net/Definitions/GetTokenRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [TokenInfo](./RingCentral.Net/Definitions/TokenInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-getToken) in API Explorer.


## Get Version Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}`
Rate Limit Group|`NoThrottling`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetVersionResponse](./RingCentral.Net/Definitions/GetVersionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.


## Get Account Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetAccountInfoResponse](./RingCentral.Net/Definitions/GetAccountInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountInfo) in API Explorer.


## Get Company Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters, restRequestConfig);
}
```

- Parameter `listCompanyActiveCallsParameters` is of type [ListCompanyActiveCallsParameters](./RingCentral.Net/Definitions/ListCompanyActiveCallsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyActiveCallsResponse](./RingCentral.Net/Definitions/CompanyActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listCompanyActiveCalls) in API Explorer.


## Create Company Call Handling Rule

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest, restRequestConfig);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().List(listCompanyAnsweringRulesParameters, restRequestConfig);
}
```

- Parameter `listCompanyAnsweringRulesParameters` is of type [ListCompanyAnsweringRulesParameters](./RingCentral.Net/Definitions/ListCompanyAnsweringRulesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyAnsweringRuleList](./RingCentral.Net/Definitions/CompanyAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-listCompanyAnsweringRules) in API Explorer.


## Get Company Call Handling Rule

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-readCompanyAnsweringRule) in API Explorer.


## Update Company Call Handling Rule

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate, restRequestConfig);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteCompanyAnsweringRule) in API Explorer.


## Get Account Business Address

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/business-address`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountBusinessAddress) in API Explorer.


## Update Company Business Address

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/business-address`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest, restRequestConfig);
}
```

- Parameter `modifyAccountBusinessAddressRequest` is of type [ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/ModifyAccountBusinessAddressRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.


## Get Company Business Hours

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/business-hours`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readCompanyBusinessHours) in API Explorer.


## Update Company Business Hours

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/business-hours`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest, restRequestConfig);
}
```

- Parameter `companyBusinessHoursUpdateRequest` is of type [CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/CompanyBusinessHoursUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateCompanyBusinessHours) in API Explorer.


## Get Company Call Log Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().List(readCompanyCallLogParameters, restRequestConfig);
}
```

- Parameter `readCompanyCallLogParameters` is of type [ReadCompanyCallLogParameters](./RingCentral.Net/Definitions/ReadCompanyCallLogParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountCallLogResponse](./RingCentral.Net/Definitions/AccountCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.


## Sync Company Call Log

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-log-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLogSync().Get(syncAccountCallLogParameters, restRequestConfig);
}
```

- Parameter `syncAccountCallLogParameters` is of type [SyncAccountCallLogParameters](./RingCentral.Net/Definitions/SyncAccountCallLogParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountCallLogSyncResponse](./RingCentral.Net/Definitions/AccountCallLogSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncAccountCallLog) in API Explorer.


## Get Company Call Log Record(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).Get(readCompanyCallRecordParameters, restRequestConfig);
}
```

- Parameter `readCompanyCallRecordParameters` is of type [ReadCompanyCallRecordParameters](./RingCentral.Net/Definitions/ReadCompanyCallRecordParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyCallLogRecord](./RingCentral.Net/Definitions/CompanyCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.


## Create Call Monitoring Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest, restRequestConfig);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Get(listCallMonitoringGroupsParameters, restRequestConfig);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallMonitoringGroups](./RingCentral.Net/Definitions/CallMonitoringGroups.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API Explorer.


## Updates Call Monitoring Group

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest, restRequestConfig);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API Explorer.


## Update Call Monitoring Group List

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign, restRequestConfig);
}
```

- Parameter `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./RingCentral.Net/Definitions/CallMonitoringBulkAssign.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in API Explorer.


## Get Call Monitoring Group Member List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters, restRequestConfig);
}
```

- Parameter `listCallMonitoringGroupMembersParameters` is of type [ListCallMonitoringGroupMembersParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupMembersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallMonitoringGroupMemberList](./RingCentral.Net/Definitions/CallMonitoringGroupMemberList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroupMembers) in API Explorer.


## Get Call Queue List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().List(listCallQueuesParameters, restRequestConfig);
}
```

- Parameter `listCallQueuesParameters` is of type [ListCallQueuesParameters](./RingCentral.Net/Definitions/ListCallQueuesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueues](./RingCentral.Net/Definitions/CallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueues) in API Explorer.


## Get Call Queue

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueueDetails](./RingCentral.Net/Definitions/CallQueueDetails.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-readCallQueueInfo) in API Explorer.


## Update Call Queue

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Put(callQueueUpdateDetails, restRequestConfig);
}
```

- Parameter `callQueueUpdateDetails` is of type [CallQueueUpdateDetails](./RingCentral.Net/Definitions/CallQueueUpdateDetails.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueueDetails](./RingCentral.Net/Definitions/CallQueueDetails.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateCallQueueInfo) in API Explorer.


## Assign Multiple Call Queue Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource, restRequestConfig);
}
```

- Parameter `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./RingCentral.Net/Definitions/CallQueueBulkAssignResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API Explorer.


## Get Call Queue Members

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters, restRequestConfig);
}
```

- Parameter `listCallQueueMembersParameters` is of type [ListCallQueueMembersParameters](./RingCentral.Net/Definitions/ListCallQueueMembersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueueMembers](./RingCentral.Net/Definitions/CallQueueMembers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueueMembers) in API Explorer.


## Get Call Queue Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueuePresence](./RingCentral.Net/Definitions/CallQueuePresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readCallQueuePresence) in API Explorer.


## Update Call Queue Presence

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Put(callQueueUpdatePresence, restRequestConfig);
}
```

- Parameter `callQueueUpdatePresence` is of type [CallQueueUpdatePresence](./RingCentral.Net/Definitions/CallQueueUpdatePresence.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallQueuePresence](./RingCentral.Net/Definitions/CallQueuePresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateCallQueuePresence) in API Explorer.


## Get Call Recording Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-readCallRecordingSettings) in API Explorer.


## Update Call Recording Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Put(callRecordingSettingsResource, restRequestConfig);
}
```

- Parameter `callRecordingSettingsResource` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingSettings) in API Explorer.


## Update Call Recording Extension List

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording/bulk-assign`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource, restRequestConfig);
}
```

- Parameter `bulkAccountCallRecordingsResource` is of type [BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/BulkAccountCallRecordingsResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingExtensionList) in API Explorer.


## Get Call Recording Custom Greeting List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Get(listCallRecordingCustomGreetingsParameters, restRequestConfig);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallRecordingCustomGreetings](./RingCentral.Net/Definitions/CallRecordingCustomGreetings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingCustomGreetings) in API Explorer.


## Delete Call Recording Custom Greeting

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-deleteCallRecordingCustomGreeting) in API Explorer.


## Get Call Recording Extension List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/call-recording/extensions`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallRecordingExtensions](./RingCentral.Net/Definitions/CallRecordingExtensions.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingExtensions) in API Explorer.


## Create Custom Field

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/custom-fields`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Post(customFieldCreateRequest, restRequestConfig);
}
```

- Parameter `customFieldCreateRequest` is of type [CustomFieldCreateRequest](./RingCentral.Net/Definitions/CustomFieldCreateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.


## Get Custom Field List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/custom-fields`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomFieldsResource](./RingCentral.Net/Definitions/CustomFieldsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-listCustomFields) in API Explorer.


## Update Сustom Field

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Put(customFieldUpdateRequest, restRequestConfig);
}
```

- Parameter `customFieldUpdateRequest` is of type [CustomFieldUpdateRequest](./RingCentral.Net/Definitions/CustomFieldUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.


## Delete Custom Field

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-deleteCustomField) in API Explorer.


## Get Device

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/device/{deviceId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Get(readDeviceParameters, restRequestConfig);
}
```

- Parameter `readDeviceParameters` is of type [ReadDeviceParameters](./RingCentral.Net/Definitions/ReadDeviceParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-readDevice) in API Explorer.


## Update Device

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/device/{deviceId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Put(accountDeviceUpdate, updateDeviceParameters, restRequestConfig);
}
```

- Parameter `accountDeviceUpdate` is of type [AccountDeviceUpdate](./RingCentral.Net/Definitions/AccountDeviceUpdate.cs)
- Parameter `updateDeviceParameters` is of type [UpdateDeviceParameters](./RingCentral.Net/Definitions/UpdateDeviceParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.


## Get Company Directory Entries

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/directory/entries`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters, restRequestConfig);
}
```

- Parameter `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-listDirectoryEntries) in API Explorer.


## Search Company Directory Entries

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/directory/entries/search`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest, restRequestConfig);
}
```

- Parameter `searchDirectoryEntriesRequest` is of type [SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/SearchDirectoryEntriesRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.


## Get Corporate Directory Entry

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/directory/entries/{entryId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ContactResource](./RingCentral.Net/Definitions/ContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.


## Get Account Federation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/directory/federation`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [FederationResource](./RingCentral.Net/Definitions/FederationResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readAccountFederation) in API Explorer.


## Get Device List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().Get(listDevicesAutomaticLocationUpdatesParameters, restRequestConfig);
}
```

- Parameter `listDevicesAutomaticLocationUpdatesParameters` is of type [ListDevicesAutomaticLocationUpdatesParameters](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdatesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ListDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listDevicesAutomaticLocationUpdates) in API Explorer.


## Enable Automatic Location Updates for Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().Post(assignMultipleDevicesAutomaticLocationUpdates, restRequestConfig);
}
```

- Parameter `assignMultipleDevicesAutomaticLocationUpdates` is of type [AssignMultipleDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/AssignMultipleDevicesAutomaticLocationUpdates.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.


## Get Network Map

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [NetworksList](./RingCentral.Net/Definitions/NetworksList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listNetworks) in API Explorer.


## Create Network

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().Post(createNetworkRequest, restRequestConfig);
}
```

- Parameter `createNetworkRequest` is of type [CreateNetworkRequest](./RingCentral.Net/Definitions/CreateNetworkRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readNetwork) in API Explorer.


## Update Network

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Put(updateNetworkRequest, restRequestConfig);
}
```

- Parameter `updateNetworkRequest` is of type [UpdateNetworkRequest](./RingCentral.Net/Definitions/UpdateNetworkRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.


## Get Account Switch List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters, restRequestConfig);
}
```

- Parameter `listAccountSwitchesParameters` is of type [ListAccountSwitchesParameters](./RingCentral.Net/Definitions/ListAccountSwitchesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SwitchesList](./RingCentral.Net/Definitions/SwitchesList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API Explorer.


## Create Switch

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().Post(createSwitchInfo, restRequestConfig);
}
```

- Parameter `createSwitchInfo` is of type [CreateSwitchInfo](./RingCentral.Net/Definitions/CreateSwitchInfo.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Create Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().Post(createMultipleSwitchesRequest, restRequestConfig);
}
```

- Parameter `createMultipleSwitchesRequest` is of type [CreateMultipleSwitchesRequest](./RingCentral.Net/Definitions/CreateMultipleSwitchesRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./RingCentral.Net/Definitions/CreateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API Explorer.


## Update Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().Post(updateMultipleSwitchesRequest, restRequestConfig);
}
```

- Parameter `updateMultipleSwitchesRequest` is of type [UpdateMultipleSwitchesRequest](./RingCentral.Net/Definitions/UpdateMultipleSwitchesRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./RingCentral.Net/Definitions/UpdateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API Explorer.


## Validate Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().Post(validateMultipleSwitchesRequest, restRequestConfig);
}
```

- Parameter `validateMultipleSwitchesRequest` is of type [ValidateMultipleSwitchesRequest](./RingCentral.Net/Definitions/ValidateMultipleSwitchesRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./RingCentral.Net/Definitions/ValidateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API Explorer.


## Get Switch

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readSwitch) in API Explorer.


## Update Switch

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Put(updateSwitchInfo, restRequestConfig);
}
```

- Parameter `updateSwitchInfo` is of type [UpdateSwitchInfo](./RingCentral.Net/Definitions/UpdateSwitchInfo.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteSwitch) in API Explorer.


## Get Emergency Map Configuration Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AutomaticLocationUpdatesTaskInfo](./RingCentral.Net/Definitions/AutomaticLocationUpdatesTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readAutomaticLocationUpdatesTask) in API Explorer.


## Get User List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().Get(listAutomaticLocationUpdatesUsersParameters, restRequestConfig);
}
```

- Parameter `listAutomaticLocationUpdatesUsersParameters` is of type [ListAutomaticLocationUpdatesUsersParameters](./RingCentral.Net/Definitions/ListAutomaticLocationUpdatesUsersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AutomaticLocationUpdatesUserList](./RingCentral.Net/Definitions/AutomaticLocationUpdatesUserList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAutomaticLocationUpdatesUsers) in API Explorer.


## Enable Automatic Location Updates for Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().Post(bulkAssignAutomaticLocationUpdatesUsers, restRequestConfig);
}
```

- Parameter `bulkAssignAutomaticLocationUpdatesUsers` is of type [BulkAssignAutomaticLocationUpdatesUsers](./RingCentral.Net/Definitions/BulkAssignAutomaticLocationUpdatesUsers.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.


## Get Wireless Point List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().List(listWirelessPointsParameters, restRequestConfig);
}
```

- Parameter `listWirelessPointsParameters` is of type [ListWirelessPointsParameters](./RingCentral.Net/Definitions/ListWirelessPointsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [WirelessPointsList](./RingCentral.Net/Definitions/WirelessPointsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API Explorer.


## Create Wireless Point

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().Post(createWirelessPoint, restRequestConfig);
}
```

- Parameter `createWirelessPoint` is of type [CreateWirelessPoint](./RingCentral.Net/Definitions/CreateWirelessPoint.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Create Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().Post(createMultipleWirelessPointsRequest, restRequestConfig);
}
```

- Parameter `createMultipleWirelessPointsRequest` is of type [CreateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in API Explorer.


## Update Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().Post(updateMultipleWirelessPointsRequest, restRequestConfig);
}
```

- Parameter `updateMultipleWirelessPointsRequest` is of type [UpdateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in API Explorer.


## Validate Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().Post(validateMultipleWirelessPointsRequest, restRequestConfig);
}
```

- Parameter `validateMultipleWirelessPointsRequest` is of type [ValidateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints) in API Explorer.


## Get Wireless Point

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API Explorer.


## Update Wireless Point

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Put(updateWirelessPoint, restRequestConfig);
}
```

- Parameter `updateWirelessPoint` is of type [UpdateWirelessPoint](./RingCentral.Net/Definitions/UpdateWirelessPoint.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API Explorer.


## Add Emergency Location

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-locations`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().Post(emergencyLocationInfoRequest, restRequestConfig);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-locations`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().List(listEmergencyLocationsParameters, restRequestConfig);
}
```

- Parameter `listEmergencyLocationsParameters` is of type [ListEmergencyLocationsParameters](./RingCentral.Net/Definitions/ListEmergencyLocationsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [EmergencyLocationList](./RingCentral.Net/Definitions/EmergencyLocationList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API Explorer.


## Get Emergency Location

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API Explorer.


## Update Emergency Location

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Put(emergencyLocationInfoRequest, restRequestConfig);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Get Extension List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().List(listExtensionsParameters, restRequestConfig);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionListResponse](./RingCentral.Net/Definitions/GetExtensionListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listExtensions) in API Explorer.


## Create Extension

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`AddRemoveUsers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Post(extensionCreationRequest, restRequestConfig);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtension) in API Explorer.


## Update Extension

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserInfo OR EditUserCredentials`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Put(extensionUpdateRequest, restRequestConfig);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`AddRemoveUsers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Delete(deleteExtensionParameters, restRequestConfig);
}
```

- Parameter `deleteExtensionParameters` is of type [DeleteExtensionParameters](./RingCentral.Net/Definitions/DeleteExtensionParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteExtension) in API Explorer.


## Get User Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters, restRequestConfig);
}
```

- Parameter `listExtensionActiveCallsParameters` is of type [ListExtensionActiveCallsParameters](./RingCentral.Net/Definitions/ListExtensionActiveCallsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserActiveCallsResponse](./RingCentral.Net/Definitions/UserActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listExtensionActiveCalls) in API Explorer.


## Address Book Synchronization

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters, restRequestConfig);
}
```

- Parameter `syncAddressBookParameters` is of type [SyncAddressBookParameters](./RingCentral.Net/Definitions/SyncAddressBookParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AddressBookSync](./RingCentral.Net/Definitions/AddressBookSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-syncAddressBook) in API Explorer.


## Get Contact List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters, restRequestConfig);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ContactList](./RingCentral.Net/Definitions/ContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.


## Create Contact

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters, restRequestConfig);
}
```

- Parameter `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.


## Get Contact

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.


## Update Contact

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactRequest, updateContactParameters, restRequestConfig);
}
```

- Parameter `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.


## Delete Contact

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.


## Get Call Handling Rules

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters, restRequestConfig);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserAnsweringRuleList](./RingCentral.Net/Definitions/UserAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-listAnsweringRules) in API Explorer.


## Create Call Handling Rule

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest, restRequestConfig);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(readAnsweringRuleParameters, restRequestConfig);
}
```

- Parameter `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./RingCentral.Net/Definitions/ReadAnsweringRuleParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-readAnsweringRule) in API Explorer.


## Update Call Handling Rule

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest, restRequestConfig);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteAnsweringRule) in API Explorer.


## Get Authorization Profile

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AuthProfileResource](./RingCentral.Net/Definitions/AuthProfileResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readAuthorizationProfile) in API Explorer.


## Check User Permission

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters, restRequestConfig);
}
```

- Parameter `checkUserPermissionParameters` is of type [CheckUserPermissionParameters](./RingCentral.Net/Definitions/CheckUserPermissionParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AuthProfileCheckResource](./RingCentral.Net/Definitions/AuthProfileCheckResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-checkUserPermission) in API Explorer.


## Get User Business Hours

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetUserBusinessHoursResponse](./RingCentral.Net/Definitions/GetUserBusinessHoursResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readUserBusinessHours) in API Explorer.


## Update User Business Hours

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest, restRequestConfig);
}
```

- Parameter `userBusinessHoursUpdateRequest` is of type [UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/UserBusinessHoursUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./RingCentral.Net/Definitions/UserBusinessHoursUpdateResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.


## Get User Call Log Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters, restRequestConfig);
}
```

- Parameter `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./RingCentral.Net/Definitions/ReadUserCallLogParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserCallLogResponse](./RingCentral.Net/Definitions/UserCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.


## Delete User Call Log

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`EditCallLog`
User Permission|`EditCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters, restRequestConfig);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.


## Sync User Call Log

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters, restRequestConfig);
}
```

- Parameter `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./RingCentral.Net/Definitions/SyncUserCallLogParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallLogSync](./RingCentral.Net/Definitions/CallLogSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncUserCallLog) in API Explorer.


## Get User Call Record

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(readUserCallRecordParameters, restRequestConfig);
}
```

- Parameter `readUserCallRecordParameters` is of type [ReadUserCallRecordParameters](./RingCentral.Net/Definitions/ReadUserCallRecordParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserCallLogRecord](./RingCentral.Net/Definitions/UserCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.


## Get Agent’s Call Queue Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Get(readExtensionCallQueuePresenceParameters, restRequestConfig);
}
```

- Parameter `readExtensionCallQueuePresenceParameters` is of type [ReadExtensionCallQueuePresenceParameters](./RingCentral.Net/Definitions/ReadExtensionCallQueuePresenceParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueuePresenceList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readExtensionCallQueuePresence) in API Explorer.


## Update Call Queue Presence

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Put(extensionCallQueueUpdatePresenceList, restRequestConfig);
}
```

- Parameter `extensionCallQueueUpdatePresenceList` is of type [ExtensionCallQueueUpdatePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueueUpdatePresenceList.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueuePresenceList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateExtensionCallQueuePresence) in API Explorer.


## Update User Call Queues

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`Accounts`
User Permission|`JoinLeaveCallQueue`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().Put(userCallQueues, restRequestConfig);
}
```

- Parameter `userCallQueues` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.


## Get Caller Blocking Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readCallerBlockingSettings) in API Explorer.


## Update Caller Blocking Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate, restRequestConfig);
}
```

- Parameter `callerBlockingSettingsUpdate` is of type [CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/CallerBlockingSettingsUpdate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API Explorer.


## Get Blocked/Allowed Phone Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedNumbersParameters, restRequestConfig);
}
```

- Parameter `listBlockedAllowedNumbersParameters` is of type [ListBlockedAllowedNumbersParameters](./RingCentral.Net/Definitions/ListBlockedAllowedNumbersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumbersList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-listBlockedAllowedNumbers) in API Explorer.


## Add Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber, restRequestConfig);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readBlockedAllowedNumber) in API Explorer.


## Delete Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.


## Update Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber, restRequestConfig);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Extension Caller ID

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCallerIDSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtensionCallerId) in API Explorer.


## Update Extension Caller ID

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditCallerIDSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo, restRequestConfig);
}
```

- Parameter `extensionCallerIdInfo` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtensionCallerId) in API Explorer.


## Create Internal Text Message

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager`
Rate Limit Group|`Medium`
App Permission|`InternalMessages`
User Permission|`InternalSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest, restRequestConfig);
}
```

- Parameter `createInternalTextMessageRequest` is of type [CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/CreateInternalTextMessageRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetInternalTextMessageInfoResponse](./RingCentral.Net/Definitions/GetInternalTextMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Pager-Messages-createInternalTextMessage) in API Explorer.


## Get User Conferencing Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`OrganizeConference`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Get(readConferencingSettingsParameters, restRequestConfig);
}
```

- Parameter `readConferencingSettingsParameters` is of type [ReadConferencingSettingsParameters](./RingCentral.Net/Definitions/ReadConferencingSettingsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readConferencingSettings) in API Explorer.


## Update User Conferencing Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`OrganizeConference`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest, restRequestConfig);
}
```

- Parameter `updateConferencingInfoRequest` is of type [UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/UpdateConferencingInfoRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.


## Get Extension Device List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/device`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters, restRequestConfig);
}
```

- Parameter `listExtensionDevicesParameters` is of type [ListExtensionDevicesParameters](./RingCentral.Net/Definitions/ListExtensionDevicesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionDevicesResponse](./RingCentral.Net/Definitions/GetExtensionDevicesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-listExtensionDevices) in API Explorer.


## Get Favorite Contact List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`
Rate Limit Group|`Light`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listFavoriteContacts) in API Explorer.


## Update Favorite Contact List

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`
Rate Limit Group|`Medium`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection, restRequestConfig);
}
```

- Parameter `favoriteCollection` is of type [FavoriteCollection](./RingCentral.Net/Definitions/FavoriteCollection.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API Explorer.


## Create Fax Message

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax`
Rate Limit Group|`Heavy`
App Permission|`Faxes`
User Permission|`OutboundFaxes`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().Post(createFaxMessageRequest, restRequestConfig);
}
```

- Parameter `createFaxMessageRequest` is of type [CreateFaxMessageRequest](./RingCentral.Net/Definitions/CreateFaxMessageRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [FaxResponse](./RingCentral.Net/Definitions/FaxResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-createFaxMessage) in API Explorer.


## Get User Features

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/features`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Features().Get(readUserFeaturesParameters, restRequestConfig);
}
```

- Parameter `readUserFeaturesParameters` is of type [ReadUserFeaturesParameters](./RingCentral.Net/Definitions/ReadUserFeaturesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [FeatureList](./RingCentral.Net/Definitions/FeatureList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Features-readUserFeatures) in API Explorer.


## Get Forwarding Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().List(listForwardingNumbersParameters, restRequestConfig);
}
```

- Parameter `listForwardingNumbersParameters` is of type [ListForwardingNumbersParameters](./RingCentral.Net/Definitions/ListForwardingNumbersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionForwardingNumberListResponse](./RingCentral.Net/Definitions/GetExtensionForwardingNumberListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-listForwardingNumbers) in API Explorer.


## Create Forwarding Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest, restRequestConfig);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-readForwardingNumber) in API Explorer.


## Update Forwarding Number

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest, restRequestConfig);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.


## Get Extension Grant List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters, restRequestConfig);
}
```

- Parameter `listExtensionGrantsParameters` is of type [ListExtensionGrantsParameters](./RingCentral.Net/Definitions/ListExtensionGrantsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionGrantListResponse](./RingCentral.Net/Definitions/GetExtensionGrantListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-listExtensionGrants) in API Explorer.


## Create Custom User Greeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Post(createCustomUserGreetingRequest, createCustomUserGreetingParameters, restRequestConfig);
}
```

- Parameter `createCustomUserGreetingRequest` is of type [CreateCustomUserGreetingRequest](./RingCentral.Net/Definitions/CreateCustomUserGreetingRequest.cs)
- Parameter `createCustomUserGreetingParameters` is of type [CreateCustomUserGreetingParameters](./RingCentral.Net/Definitions/CreateCustomUserGreetingParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-createCustomUserGreeting) in API Explorer.


## Get Custom Greeting

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readCustomGreeting) in API Explorer.


## Get Scheduled Meetings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingsResource](./RingCentral.Net/Definitions/MeetingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-listMeetings) in API Explorer.


## Create Meeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Post(meetingRequestResource, restRequestConfig);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get User Meeting Recordings List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`MeetingsRecordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingRecordings().Get(listUserMeetingRecordingsParameters, restRequestConfig);
}
```

- Parameter `listUserMeetingRecordingsParameters` is of type [ListUserMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListUserMeetingRecordingsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listUserMeetingRecordings) in API Explorer.


## Get Meeting Service Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readMeetingServiceInfo) in API Explorer.


## Update Meeting Service Info

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Patch(meetingServiceInfoRequest, restRequestConfig);
}
```

- Parameter `meetingServiceInfoRequest` is of type [MeetingServiceInfoRequest](./RingCentral.Net/Definitions/MeetingServiceInfoRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-updateMeetingServiceInfo) in API Explorer.


## Get Meeting User Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/user-settings`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().UserSettings().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingUserSettingsResponse](./RingCentral.Net/Definitions/MeetingUserSettingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-GetUserSetting) in API Explorer.


## Get Meeting Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeeting) in API Explorer.


## Update Meeting

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Put(meetingRequestResource, restRequestConfig);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-deleteMeeting) in API Explorer.


## End Meeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).End().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-endMeeting) in API Explorer.


## Get Meeting Invitation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/invitation`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Invitation().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PublicMeetingInvitationResponse](./RingCentral.Net/Definitions/PublicMeetingInvitationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeetingInvitation) in API Explorer.


## Get Assistants

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assistants().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AssistantsResource](./RingCentral.Net/Definitions/AssistantsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistants) in API Explorer.


## Get Assisted Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assisted().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AssistedUsersResource](./RingCentral.Net/Definitions/AssistedUsersResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistedUsers) in API Explorer.


## Get Message List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters, restRequestConfig);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetMessageList](./RingCentral.Net/Definitions/GetMessageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-listMessages) in API Explorer.


## Get Message

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.


## Update Message List

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest, updateMessageParameters, restRequestConfig);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- Parameter `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageParameters, restRequestConfig);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.


## Get Message Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`
Rate Limit Group|`Medium`
App Permission|`ReadMessages`
User Permission|`ReadMessageContent`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(readMessageContentParameters, restRequestConfig);
}
```

- Parameter `readMessageContentParameters` is of type [ReadMessageContentParameters](./RingCentral.Net/Definitions/ReadMessageContentParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageContent) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Sync Messages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters, restRequestConfig);
}
```

- Parameter `syncMessagesParameters` is of type [SyncMessagesParameters](./RingCentral.Net/Definitions/SyncMessagesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetMessageSyncResponse](./RingCentral.Net/Definitions/GetMessageSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-syncMessages) in API Explorer.


## Send MMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/mms`
Rate Limit Group|`Medium`
App Permission|`SMS`
User Permission|`OutboundSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().Post(createMmsMessage, restRequestConfig);
}
```

- Parameter `createMmsMessage` is of type [CreateMMSMessage](./RingCentral.Net/Definitions/CreateMMSMessage.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetSMSMessageInfoResponse](./RingCentral.Net/Definitions/GetSMSMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createMMS) in API Explorer.


## Get Notification Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadMessagesNotificationsSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readNotificationSettings) in API Explorer.


## Update Notification Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditMessagesNotificationsSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest, restRequestConfig);
}
```

- Parameter `notificationSettingsUpdateRequest` is of type [NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/NotificationSettingsUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateNotificationSettings) in API Explorer.


## Get Extension Phone Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters, restRequestConfig);
}
```

- Parameter `listExtensionPhoneNumbersParameters` is of type [ListExtensionPhoneNumbersParameters](./RingCentral.Net/Definitions/ListExtensionPhoneNumbersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetExtensionPhoneNumbersResponse](./RingCentral.Net/Definitions/GetExtensionPhoneNumbersResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listExtensionPhoneNumbers) in API Explorer.


## Get User Presence Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Get(readUserPresenceStatusParameters, restRequestConfig);
}
```

- Parameter `readUserPresenceStatusParameters` is of type [ReadUserPresenceStatusParameters](./RingCentral.Net/Definitions/ReadUserPresenceStatusParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetPresenceInfo](./RingCentral.Net/Definitions/GetPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUserPresenceStatus) in API Explorer.


## Update User Presence Status

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Put(presenceInfoResource, restRequestConfig);
}
```

- Parameter `presenceInfoResource` is of type [PresenceInfoResource](./RingCentral.Net/Definitions/PresenceInfoResource.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PresenceInfoResponse](./RingCentral.Net/Definitions/PresenceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.


## Get User Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Upload User Profile Image

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Post(createUserProfileImageRequest, restRequestConfig);
}
```

- Parameter `createUserProfileImageRequest` is of type [CreateUserProfileImageRequest](./RingCentral.Net/Definitions/CreateUserProfileImageRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-createUserProfileImage) in API Explorer.


## Update User Profile Image

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Put(updateUserProfileImageRequest, restRequestConfig);
}
```

- Parameter `updateUserProfileImageRequest` is of type [UpdateUserProfileImageRequest](./RingCentral.Net/Definitions/UpdateUserProfileImageRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.


## Get Scaled User Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledPofileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Make RingOut Call

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`
Rate Limit Group|`Heavy`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest, restRequestConfig);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`
Rate Limit Group|`Light`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`
Rate Limit Group|`Heavy`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Send SMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms`
Rate Limit Group|`Medium`
App Permission|`SMS`
User Permission|`OutboundSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().Post(createSmsMessage, restRequestConfig);
}
```

- Parameter `createSmsMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetSMSMessageInfoResponse](./RingCentral.Net/Definitions/GetSMSMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.


## Get Unified Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`
Rate Limit Group|`Medium`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUnifiedPresence) in API Explorer.


## Update Unified Presence

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`EditPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Patch(updateUnifiedPresence, restRequestConfig);
}
```

- Parameter `updateUnifiedPresence` is of type [UpdateUnifiedPresence](./RingCentral.Net/Definitions/UpdateUnifiedPresence.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.


## Get User Video Configuration

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).VideoConfiguration().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Video-Configuration-readUserVideoConfiguration) in API Explorer.


## Update User Video Configuration

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).VideoConfiguration().Put(userVideoConfiguration, restRequestConfig);
}
```

- Parameter `userVideoConfiguration` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Video-Configuration-updateUserVideoConfiguration) in API Explorer.


## Create Company Greeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/greeting`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().Post(createCompanyGreetingRequest, restRequestConfig);
}
```

- Parameter `createCompanyGreetingRequest` is of type [CreateCompanyGreetingRequest](./RingCentral.Net/Definitions/CreateCompanyGreetingRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CustomCompanyGreetingInfo](./RingCentral.Net/Definitions/CustomCompanyGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-createCompanyGreeting) in API Explorer.


## Create IVR Menu

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-menus`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Post(ivrMenuInfo, restRequestConfig);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-createIVRMenu) in API Explorer.


## Get IVR Menu

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRMenu) in API Explorer.


## Update IVR Menu

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Put(ivrMenuInfo, restRequestConfig);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-updateIVRMenu) in API Explorer.


## Create IVR Prompts

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Post(createIvrPromptRequest, restRequestConfig);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-createIVRPrompt) in API Explorer.


## Get IVR Prompt List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [IVRPrompts](./RingCentral.Net/Definitions/IVRPrompts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-listIVRPrompts) in API Explorer.


## Get IVR Prompt

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRPrompt) in API Explorer.


## Delete IVR Prompt

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-deleteIVRPrompt) in API Explorer.


## Update IVR Prompt

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Put(updateIvrPromptRequest, restRequestConfig);
}
```

- Parameter `updateIvrPromptRequest` is of type [UpdateIVRPromptRequest](./RingCentral.Net/Definitions/UpdateIVRPromptRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-updateIVRPrompt) in API Explorer.


## Get IVR Prompt Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRPromptContent) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get Account Meeting Recordings List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/meeting-recordings`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`MeetingsRecordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MeetingRecordings().Get(listAccountMeetingRecordingsParameters, restRequestConfig);
}
```

- Parameter `listAccountMeetingRecordingsParameters` is of type [ListAccountMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListAccountMeetingRecordingsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listAccountMeetingRecordings) in API Explorer.


## Get Locked Meeting Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/meeting/locked-settings`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Meeting().LockedSettings().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountLockedSettingResponse](./RingCentral.Net/Definitions/AccountLockedSettingResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-GetAccountLockedSetting) in API Explorer.


## Get Message Store Configuration

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-configuration`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`AccountAdministration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageStoreConfiguration) in API Explorer.


## Update Message Store Configuration

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-configuration`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`AccountAdministration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration, restRequestConfig);
}
```

- Parameter `messageStoreConfiguration` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API Explorer.


## Create Message Store Report

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-report`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest, restRequestConfig);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API Explorer.


## Get Message Store Report Archive

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [MessageStoreReportArchive](./RingCentral.Net/Definitions/MessageStoreReportArchive.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API Explorer.


## Get Message Store Report Archive Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchiveContent) in API Explorer.


## Assign Paging Group Users and Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest, restRequestConfig);
}
```

- Parameter `editPagingGroupRequest` is of type [EditPagingGroupRequest](./RingCentral.Net/Definitions/EditPagingGroupRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices) in API Explorer.


## Get Paging Group Devices

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters, restRequestConfig);
}
```

- Parameter `listPagingGroupDevicesParameters` is of type [ListPagingGroupDevicesParameters](./RingCentral.Net/Definitions/ListPagingGroupDevicesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PagingOnlyGroupDevices](./RingCentral.Net/Definitions/PagingOnlyGroupDevices.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupDevices) in API Explorer.


## Get Paging Group Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters, restRequestConfig);
}
```

- Parameter `listPagingGroupUsersParameters` is of type [ListPagingGroupUsersParameters](./RingCentral.Net/Definitions/ListPagingGroupUsersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PagingOnlyGroupUsers](./RingCentral.Net/Definitions/PagingOnlyGroupUsers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupUsers) in API Explorer.


## Get Company Phone Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/phone-number`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters, restRequestConfig);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountPhoneNumbers](./RingCentral.Net/Definitions/AccountPhoneNumbers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbers) in API Explorer.


## Get Phone Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CompanyPhoneNumberInfo](./RingCentral.Net/Definitions/CompanyPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.


## Get User Presence Status List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/presence`
Rate Limit Group|`Heavy`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Presence().Get(readAccountPresenceParameters, restRequestConfig);
}
```

- Parameter `readAccountPresenceParameters` is of type [ReadAccountPresenceParameters](./RingCentral.Net/Definitions/ReadAccountPresenceParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [AccountPresenceInfo](./RingCentral.Net/Definitions/AccountPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readAccountPresence) in API Explorer.


## Get Call Recording

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/recording/{recordingId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallRecording`
User Permission|`ReadCallRecording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetCallRecordingResponse](./RingCentral.Net/Definitions/GetCallRecordingResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecording) in API Explorer.


## Get Call Recordings Data

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/recording/{recordingId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadCallRecording`
User Permission|`ReadCallRecording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-listCallRecordingData) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get Account Service Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/service-info`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadServicePlanInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetServiceInfoResponse](./RingCentral.Net/Definitions/GetServiceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountServiceInfo) in API Explorer.


## Make CallOut

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/call-out`
Rate Limit Group|`Heavy`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().Post(makeCallOutRequest, restRequestConfig);
}
```

- Parameter `makeCallOutRequest` is of type [MakeCallOutRequest](./RingCentral.Net/Definitions/MakeCallOutRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallOutCallSession) in API Explorer.


## Start Conference Call Session

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/conference`
Rate Limit Group|`Heavy`
App Permission|`TelephonySessions`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Conference().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallSessionObject](./RingCentral.Net/Definitions/CallSessionObject.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createConferenceCallSession) in API Explorer.


## Get Call Session Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Get(readCallSessionStatusParameters, restRequestConfig);
}
```

- Parameter `readCallSessionStatusParameters` is of type [ReadCallSessionStatusParameters](./RingCentral.Net/Definitions/ReadCallSessionStatusParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallSessionStatus) in API Explorer.


## Drop Call Session

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallSession) in API Explorer.


## Bring-In Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/bring-in`
Rate Limit Group|`Light`
App Permission|`TelephonySessions`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties().BringIn().Post(addPartyRequest, restRequestConfig);
}
```

- Parameter `addPartyRequest` is of type [AddPartyRequest](./RingCentral.Net/Definitions/AddPartyRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallPartyWithBringIn) in API Explorer.


## Get Call Party Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallPartyStatus) in API Explorer.


## Delete Call Party

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`TelephonySessions`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallParty) in API Explorer.


## Update Call Party

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Patch(partyUpdateRequest, restRequestConfig);
}
```

- Parameter `partyUpdateRequest` is of type [PartyUpdateRequest](./RingCentral.Net/Definitions/PartyUpdateRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.


## Answer Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().Post(answerTarget, restRequestConfig);
}
```

- Parameter `answerTarget` is of type [AnswerTarget](./RingCentral.Net/Definitions/AnswerTarget.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-answerCallParty) in API Explorer.


## Bridge Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Bridge().Post(bridgeTargetRequest, restRequestConfig);
}
```

- Parameter `bridgeTargetRequest` is of type [BridgeTargetRequest](./RingCentral.Net/Definitions/BridgeTargetRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-bridgeCallParty) in API Explorer.


## Call Flip on Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().Post(callPartyFlip, restRequestConfig);
}
```

- Parameter `callPartyFlip` is of type [CallPartyFlip](./RingCentral.Net/Definitions/CallPartyFlip.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callFlipParty) in API Explorer.


## Forward Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget, restRequestConfig);
}
```

- Parameter `forwardTarget` is of type [ForwardTarget](./RingCentral.Net/Definitions/ForwardTarget.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-forwardCallParty) in API Explorer.


## Hold Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-holdCallParty) in API Explorer.


## Ignore Call in Queue

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().Post(ignoreRequestBody, restRequestConfig);
}
```

- Parameter `ignoreRequestBody` is of type [IgnoreRequestBody](./RingCentral.Net/Definitions/IgnoreRequestBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.


## Call Park

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Park().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callParkParty) in API Explorer.


## Pickup Call

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().Post(pickupTarget, restRequestConfig);
}
```

- Parameter `pickupTarget` is of type [PickupTarget](./RingCentral.Net/Definitions/PickupTarget.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pickupCallParty) in API Explorer.


## Create Recording

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-startCallRecording) in API Explorer.


## Pause/Resume Recording

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters, restRequestConfig);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Reject Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-rejectParty) in API Explorer.


## Reply with Text

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().Post(callPartyReply, restRequestConfig);
}
```

- Parameter `callPartyReply` is of type [CallPartyReply](./RingCentral.Net/Definitions/CallPartyReply.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ReplyParty](./RingCentral.Net/Definitions/ReplyParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-replyParty) in API Explorer.


## Supervise Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().Post(partySuperviseRequest, restRequestConfig);
}
```

- Parameter `partySuperviseRequest` is of type [PartySuperviseRequest](./RingCentral.Net/Definitions/PartySuperviseRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [PartySuperviseResponse](./RingCentral.Net/Definitions/PartySuperviseResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallParty) in API Explorer.


## Transfer Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().Post(transferTarget, restRequestConfig);
}
```

- Parameter `transferTarget` is of type [TransferTarget](./RingCentral.Net/Definitions/TransferTarget.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-transferCallParty) in API Explorer.


## Unhold Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-unholdCallParty) in API Explorer.


## Supervise Call Session

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest, restRequestConfig);
}
```

- Parameter `superviseCallSessionRequest` is of type [SuperviseCallSessionRequest](./RingCentral.Net/Definitions/SuperviseCallSessionRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SuperviseCallSession](./RingCentral.Net/Definitions/SuperviseCallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.


## Get User Template List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/templates`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().List(listUserTemplatesParameters, restRequestConfig);
}
```

- Parameter `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./RingCentral.Net/Definitions/ListUserTemplatesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserTemplates](./RingCentral.Net/Definitions/UserTemplates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listUserTemplates) in API Explorer.


## Get User Template

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/account/{accountId}/templates/{templateId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [TemplateInfo](./RingCentral.Net/Definitions/TemplateInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.


## Register Device

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/client-info/sip-provision`
Rate Limit Group|`Heavy`
App Permission|`VoipCalling`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().Post(createSipRegistrationRequest, restRequestConfig);
}
```

- Parameter `createSipRegistrationRequest` is of type [CreateSipRegistrationRequest](./RingCentral.Net/Definitions/CreateSipRegistrationRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [CreateSipRegistrationResponse](./RingCentral.Net/Definitions/CreateSipRegistrationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Device-SIP-Registration-createSIPRegistration) in API Explorer.


## Get Country List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/country`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country().List(listCountriesParameters, restRequestConfig);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listCountries) in API Explorer.


## Get Country

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/country/{countryId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetCountryInfoDictionaryResponse](./RingCentral.Net/Definitions/GetCountryInfoDictionaryResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.


## Get Fax Cover Page List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/fax-cover-page`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters, restRequestConfig);
}
```

- Parameter `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./RingCentral.Net/Definitions/ListFaxCoverPagesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ListFaxCoverPagesResponse](./RingCentral.Net/Definitions/ListFaxCoverPagesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-listFaxCoverPages) in API Explorer.


## Get Standard Greeting List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/greeting`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().List(listStandardGreetingsParameters, restRequestConfig);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DictionaryGreetingList](./RingCentral.Net/Definitions/DictionaryGreetingList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-listStandardGreetings) in API Explorer.


## Get Standard Greeting

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/greeting/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DictionaryGreetingInfo](./RingCentral.Net/Definitions/DictionaryGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readStandardGreeting) in API Explorer.


## Get Language List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/language`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [LanguageList](./RingCentral.Net/Definitions/LanguageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLanguages) in API Explorer.


## Get Language

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/language/{languageId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [LanguageInfo](./RingCentral.Net/Definitions/LanguageInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.


## Get Location List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/location`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Location().Get(listLocationsParameters, restRequestConfig);
}
```

- Parameter `listLocationsParameters` is of type [ListLocationsParameters](./RingCentral.Net/Definitions/ListLocationsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetLocationListResponse](./RingCentral.Net/Definitions/GetLocationListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLocations) in API Explorer.


## Get States List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/state`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State().List(listStatesParameters, restRequestConfig);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetStateListResponse](./RingCentral.Net/Definitions/GetStateListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listStates) in API Explorer.


## Get State

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/state/{stateId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetStateInfoResponse](./RingCentral.Net/Definitions/GetStateInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.


## Get Timezone List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/timezone`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().List(listTimezonesParameters, restRequestConfig);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetTimezoneListResponse](./RingCentral.Net/Definitions/GetTimezoneListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listTimezones) in API Explorer.


## Get Timezone

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/dictionary/timezone/{timezoneId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).Get(readTimezoneParameters, restRequestConfig);
}
```

- Parameter `readTimezoneParameters` is of type [ReadTimezoneParameters](./RingCentral.Net/Definitions/ReadTimezoneParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetTimezoneInfoResponse](./RingCentral.Net/Definitions/GetTimezoneInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.


## Get Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats().List(listGlipChatsParameters, restRequestConfig);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipChatsList](./RingCentral.Net/Definitions/GlipChatsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChats) in API Explorer.


## Get Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipChatInfo](./RingCentral.Net/Definitions/GlipChatInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChat) in API Explorer.


## Add Chat to Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/favorite`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Favorite().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-favoriteGlipChat) in API Explorer.


## Create Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/notes`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Post(glipNoteCreate, restRequestConfig);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNote) in API Explorer.


## Get Chat Notes

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/notes`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Get(listChatNotesParameters, restRequestConfig);
}
```

- Parameter `listChatNotesParameters` is of type [ListChatNotesParameters](./RingCentral.Net/Definitions/ListChatNotesParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipNotesInfo](./RingCentral.Net/Definitions/GlipNotesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-listChatNotes) in API Explorer.


## Get Posts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().List(readGlipPostsParameters, restRequestConfig);
}
```

- Parameter `readGlipPostsParameters` is of type [ReadGlipPostsParameters](./RingCentral.Net/Definitions/ReadGlipPostsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPostsList](./RingCentral.Net/Definitions/GlipPostsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPosts) in API Explorer.


## Create Glip Post

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPost) in API Explorer.


## Update Post

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Patch(glipPatchPostBody, restRequestConfig);
}
```

- Parameter `glipPatchPostBody` is of type [GlipPatchPostBody](./RingCentral.Net/Definitions/GlipPatchPostBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPost) in API Explorer.


## Mark Chat as Read

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/read`
Rate Limit Group|`Medium`
App Permission|`GlipInternal`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Read().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatRead) in API Explorer.


## Get Chat Tasks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/tasks`
Rate Limit Group|`Heavy`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Get(listChatTasksParameters, restRequestConfig);
}
```

- Parameter `listChatTasksParameters` is of type [ListChatTasksParameters](./RingCentral.Net/Definitions/ListChatTasksParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-listChatTasks) in API Explorer.


## Create Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/tasks`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Post(glipCreateTask, restRequestConfig);
}
```

- Parameter `glipCreateTask` is of type [GlipCreateTask](./RingCentral.Net/Definitions/GlipCreateTask.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTask) in API Explorer.


## Remove Chat from Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/unfavorite`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unfavorite().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-unfavoriteGlipChat) in API Explorer.


## Mark Chat as Unread

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/chats/{chatId}/unread`
Rate Limit Group|`Medium`
App Permission|`GlipInternal`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unread().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatUnread) in API Explorer.


## Get Company Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/companies/{companyId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Companies(companyId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipCompany](./RingCentral.Net/Definitions/GlipCompany.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipCompany) in API Explorer.


## Get Conversations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/conversations`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().List(listGlipConversationsParameters, restRequestConfig);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipConversationsList](./RingCentral.Net/Definitions/GlipConversationsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversations) in API Explorer.


## Create/Open Conversation

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/conversations`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().Post(createGlipConversationRequest, restRequestConfig);
}
```

- Parameter `createGlipConversationRequest` is of type [CreateGlipConversationRequest](./RingCentral.Net/Definitions/CreateGlipConversationRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/conversations/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversation) in API Explorer.


## Create Data Export Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/data-export`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().Post(createDataExportTaskRequest, restRequestConfig);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/data-export`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().List(listDataExportTasksParameters, restRequestConfig);
}
```

- Parameter `listDataExportTasksParameters` is of type [ListDataExportTasksParameters](./RingCentral.Net/Definitions/ListDataExportTasksParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DataExportTaskList](./RingCentral.Net/Definitions/DataExportTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-listDataExportTasks) in API Explorer.


## Get Data Export Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/data-export/{taskId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTask) in API Explorer.


## Get Data Export Task Dataset

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Datasets(datasetId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTaskDataset) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get User Events List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().List(readGlipEventsParameters, restRequestConfig);
}
```

- Parameter `readGlipEventsParameters` is of type [ReadGlipEventsParameters](./RingCentral.Net/Definitions/ReadGlipEventsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventsInfo](./RingCentral.Net/Definitions/GlipEventsInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEvents) in API Explorer.


## Create Event

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().Post(glipEventCreate, restRequestConfig);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEvent) in API Explorer.


## Update Event

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Put(glipEventCreate, restRequestConfig);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEvent) in API Explorer.


## Get Everyone Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/everyone`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipEveryone) in API Explorer.


## Update Everyone Сhat

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/glip/everyone`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Patch(updateGlipEveryoneRequest, restRequestConfig);
}
```

- Parameter `updateGlipEveryoneRequest` is of type [UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/UpdateGlipEveryoneRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryone) in API Explorer.


## Get Favorite Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/favorites`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Favorites().Get(listFavoriteChatsParameters, restRequestConfig);
}
```

- Parameter `listFavoriteChatsParameters` is of type [ListFavoriteChatsParameters](./RingCentral.Net/Definitions/ListFavoriteChatsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listFavoriteChats) in API Explorer.


## Create Event by Group ID

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Post(glipEventCreate, restRequestConfig);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventbyGroupId) in API Explorer.


## Get Group Events

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-listGroupEvents) in API Explorer.


## Create Post in Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/groups/{groupId}/posts`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().Post(glipCreatePost, restRequestConfig);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipGroupPost) in API Explorer.


## Create Webhook in Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipWebhookInfo](./RingCentral.Net/Definitions/GlipWebhookInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-createGlipGroupWebhook) in API Explorer.


## Get Webhooks in Group

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipGroupWebhooks) in API Explorer.


## Get Note

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GetGlipNoteInfo](./RingCentral.Net/Definitions/GetGlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-readUserNote) in API Explorer.


## Update Note

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Patch(glipNoteCreate, restRequestConfig);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNote) in API Explorer.


## Delete Note

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-deleteNote) in API Explorer.


## Lock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}/lock`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Lock().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-lockNote) in API Explorer.


## Publish Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}/publish`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Publish().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-publishNote) in API Explorer.


## Unlock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/notes/{noteId}/unlock`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Unlock().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-unlockNote) in API Explorer.


## Get Person

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/persons/{personId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Persons(personId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPersonInfo](./RingCentral.Net/Definitions/GlipPersonInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPerson) in API Explorer.


## Get Preferences

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/preferences`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Preferences().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipPreferencesInfo](./RingCentral.Net/Definitions/GlipPreferencesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPreferences) in API Explorer.


## Get Recent Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/recent/chats`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Recent().Chats().Get(listRecentChatsParameters, restRequestConfig);
}
```

- Parameter `listRecentChatsParameters` is of type [ListRecentChatsParameters](./RingCentral.Net/Definitions/ListRecentChatsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listRecentChats) in API Explorer.


## Get Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-readTask) in API Explorer.


## Patch Task

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Patch(glipUpdateTask, restRequestConfig);
}
```

- Parameter `glipUpdateTask` is of type [GlipUpdateTask](./RingCentral.Net/Definitions/GlipUpdateTask.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTask) in API Explorer.


## Delete Task

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-deleteTask) in API Explorer.


## Complete Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/tasks/{taskId}/complete`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Complete().Post(glipCompleteTask, restRequestConfig);
}
```

- Parameter `glipCompleteTask` is of type [GlipCompleteTask](./RingCentral.Net/Definitions/GlipCompleteTask.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTask) in API Explorer.


## Get Teams

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/teams`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().List(listGlipTeamsParameters, restRequestConfig);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTeamsList](./RingCentral.Net/Definitions/GlipTeamsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeams) in API Explorer.


## Create Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().Post(glipPostTeamBody, restRequestConfig);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeam) in API Explorer.


## Update Team

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Patch(glipPatchTeamBody, restRequestConfig);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeam) in API Explorer.


## Add Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/add`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().Post(glipPostMembersListBody, restRequestConfig);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembers) in API Explorer.


## Archive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/archive`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Archive().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-archiveGlipTeam) in API Explorer.


## Join Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/join`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Join().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-joinGlipTeam) in API Explorer.


## Leave Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/leave`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Leave().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-leaveGlipTeam) in API Explorer.


## Remove Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/remove`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().Post(glipPostMembersIdsListBody, restRequestConfig);
}
```

- Parameter `glipPostMembersIdsListBody` is of type [GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/GlipPostMembersIdsListBody.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembers) in API Explorer.


## Unarchive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/teams/{chatId}/unarchive`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Unarchive().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-unarchiveGlipTeam) in API Explorer.


## Get Webhooks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipWebhooks) in API Explorer.


## Get Webhook

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/glip/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-readGlipWebhook) in API Explorer.


## Delete Webhook

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/glip/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-deleteGlipWebhook) in API Explorer.


## Activate Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/webhooks/{webhookId}/activate`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Activate().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-activateGlipWebhook) in API Explorer.


## Suspend Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/glip/webhooks/{webhookId}/suspend`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Suspend().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-suspendGlipWebhook) in API Explorer.


## Parse Phone Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/number-parser/parse`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters, restRequestConfig);
}
```

- Parameter `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./RingCentral.Net/Definitions/ParsePhoneNumberRequest.cs)
- Parameter `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ParsePhoneNumberResponse](./RingCentral.Net/Definitions/ParsePhoneNumberResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-parsePhoneNumber) in API Explorer.


## Get Subscription List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/subscription`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().List(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [RecordsCollectionResourceSubscriptionResponse](./RingCentral.Net/Definitions/RecordsCollectionResourceSubscriptionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-listSubscriptions) in API Explorer.


## Create Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/subscription`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().Post(createSubscriptionRequest, restRequestConfig);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v1.0/subscription/{subscriptionId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-readSubscription) in API Explorer.


## Update Subscription

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/v1.0/subscription/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Put(modifySubscriptionRequest, updateSubscriptionParameters, restRequestConfig);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v1.0/subscription/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.


## Renew Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v1.0/subscription/{subscriptionId}/renew`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().Post(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-renewSubscription) in API Explorer.


## Get Service Provider Config

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/v2/ServiceProviderConfig`
Rate Limit Group|`NoThrottling`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).ServiceProviderConfig().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [ServiceProviderConfig](./RingCentral.Net/Definitions/ServiceProviderConfig.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readServiceProviderConfig2) in API Explorer.


## Search/List Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/v2/Users`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().List(searchViaGet2Parameters, restRequestConfig);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaGet2) in API Explorer.


## Create User

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/v2/Users`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().Post(createUser, restRequestConfig);
}
```

- Parameter `createUser` is of type [CreateUser](./RingCentral.Net/Definitions/CreateUser.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Search/List Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/v2/Users/.search`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DotSearch().Post(searchRequest, restRequestConfig);
}
```

- Parameter `searchRequest` is of type [SearchRequest](./RingCentral.Net/Definitions/SearchRequest.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaPost2) in API Explorer.


## Get User

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/v2/Users/{id}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readUser2) in API Explorer.


## Update/Replace User

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/scim/v2/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Put(user, restRequestConfig);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/scim/v2/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Delete(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-deleteUser2) in API Explorer.


## Update/Patch User

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/scim/v2/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Patch(userPatch, restRequestConfig);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Check Health

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/v2/health`
Rate Limit Group|`NoThrottling`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Health().Get(restRequestConfig);
}
```

- Parameter `restRequestConfig` is of type [RestRequestConfig](./RingCentral.Net/Definitions/RestRequestConfig.cs)
- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-checkHealth2) in API Explorer.