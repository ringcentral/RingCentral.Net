# RingCentral.Net SDK Code Samples


## Get API Versions

HTTP GET `/restapi`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().List();
}
```


- `result` is of type [GetVersionsResponse](./RingCentral.Net/Definitions/GetVersionsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersions) in API Explorer.


## Revoke Token

HTTP POST `/restapi/oauth/revoke`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Revoke().Post(revokeTokenRequest);
}
```

- Parameter `revokeTokenRequest` is of type [RevokeTokenRequest](./RingCentral.Net/Definitions/RevokeTokenRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-revokeToken) in API Explorer.


## Get Token

HTTP POST `/restapi/oauth/token`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Token().Post(getTokenRequest);
}
```

- Parameter `getTokenRequest` is of type [GetTokenRequest](./RingCentral.Net/Definitions/GetTokenRequest.cs)
- `result` is of type [TokenInfo](./RingCentral.Net/Definitions/TokenInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-getToken) in API Explorer.


## Get Version Info

HTTP GET `/restapi/{apiVersion}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Get();
}
```


- `result` is of type [GetVersionResponse](./RingCentral.Net/Definitions/GetVersionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.


## Get Account Info

HTTP GET `/restapi/v1.0/account/{accountId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Get();
}
```


- `result` is of type [GetAccountInfoResponse](./RingCentral.Net/Definitions/GetAccountInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountInfo) in API Explorer.


## Get Company Active Calls

HTTP GET `/restapi/v1.0/account/{accountId}/active-calls`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
}
```

- Parameter `listCompanyActiveCallsParameters` is of type [ListCompanyActiveCallsParameters](./RingCentral.Net/Definitions/ListCompanyActiveCallsParameters.cs)
- `result` is of type [CompanyActiveCallsResponse](./RingCentral.Net/Definitions/CompanyActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listCompanyActiveCalls) in API Explorer.


## Create Company Call Handling Rule

HTTP POST `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

HTTP GET `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().List();
}
```


- `result` is of type [CompanyAnsweringRuleList](./RingCentral.Net/Definitions/CompanyAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCompanyAnsweringRules) in API Explorer.


## Get Company Call Handling Rule

HTTP GET `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Get();
}
```


- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCompanyAnsweringRule) in API Explorer.


## Update Company Call Handling Rule

HTTP PUT `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

HTTP DELETE `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCompanyAnsweringRule) in API Explorer.


## Get Account Business Address

HTTP GET `/restapi/v1.0/account/{accountId}/business-address`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Get();
}
```


- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountBusinessAddress) in API Explorer.


## Update Company Business Address

HTTP PUT `/restapi/v1.0/account/{accountId}/business-address`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest);
}
```

- Parameter `modifyAccountBusinessAddressRequest` is of type [ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/ModifyAccountBusinessAddressRequest.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.


## Get Company Business Hours

HTTP GET `/restapi/v1.0/account/{accountId}/business-hours`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Get();
}
```


- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readCompanyBusinessHours) in API Explorer.


## Update Company Business Hours

HTTP PUT `/restapi/v1.0/account/{accountId}/business-hours`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest);
}
```

- Parameter `companyBusinessHoursUpdateRequest` is of type [CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/CompanyBusinessHoursUpdateRequest.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateCompanyBusinessHours) in API Explorer.


## Get Company Call Log Records

HTTP GET `/restapi/v1.0/account/{accountId}/call-log`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().List(readCompanyCallLogParameters);
}
```

- Parameter `readCompanyCallLogParameters` is of type [ReadCompanyCallLogParameters](./RingCentral.Net/Definitions/ReadCompanyCallLogParameters.cs)
- `result` is of type [AccountCallLogResponse](./RingCentral.Net/Definitions/AccountCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.


## Sync Company Call Log

HTTP GET `/restapi/v1.0/account/{accountId}/call-log-sync`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLogSync().Get(syncAccountCallLogParameters);
}
```

- Parameter `syncAccountCallLogParameters` is of type [SyncAccountCallLogParameters](./RingCentral.Net/Definitions/SyncAccountCallLogParameters.cs)
- `result` is of type [AccountCallLogSyncResponse](./RingCentral.Net/Definitions/AccountCallLogSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncAccountCallLog) in API Explorer.


## Get Company Call Log Record(s)

HTTP GET `/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).Get();
}
```


- `result` is of type [CompanyCallLogRecord](./RingCentral.Net/Definitions/CompanyCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.


## Create Call Monitoring Group

HTTP POST `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

HTTP GET `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Get(listCallMonitoringGroupsParameters);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- `result` is of type [CallMonitoringGroups](./RingCentral.Net/Definitions/CallMonitoringGroups.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API Explorer.


## Updates Call Monitoring Group

HTTP PUT `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

HTTP DELETE `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API Explorer.


## Update Call Monitoring Group List

HTTP POST `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
}
```

- Parameter `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./RingCentral.Net/Definitions/CallMonitoringBulkAssign.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in API Explorer.


## Get Call Monitoring Group Member List

HTTP GET `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters);
}
```

- Parameter `listCallMonitoringGroupMembersParameters` is of type [ListCallMonitoringGroupMembersParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupMembersParameters.cs)
- `result` is of type [CallMonitoringGroupMemberList](./RingCentral.Net/Definitions/CallMonitoringGroupMemberList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroupMembers) in API Explorer.


## Get Call Queues

HTTP GET `/restapi/v1.0/account/{accountId}/call-queues`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().Get(listCallQueuesParameters);
}
```

- Parameter `listCallQueuesParameters` is of type [ListCallQueuesParameters](./RingCentral.Net/Definitions/ListCallQueuesParameters.cs)
- `result` is of type [CallQueues](./RingCentral.Net/Definitions/CallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueues) in API Explorer.


## Assign Multiple Call Queue Members

HTTP POST `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource);
}
```

- Parameter `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./RingCentral.Net/Definitions/CallQueueBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API Explorer.


## Get Call Queue Members

HTTP GET `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters);
}
```

- Parameter `listCallQueueMembersParameters` is of type [ListCallQueueMembersParameters](./RingCentral.Net/Definitions/ListCallQueueMembersParameters.cs)
- `result` is of type [CallQueueMembers](./RingCentral.Net/Definitions/CallQueueMembers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueueMembers) in API Explorer.


## Get Call Recording Settings

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Get();
}
```


- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCallRecordingSettings) in API Explorer.


## Update Call Recording Settings

HTTP PUT `/restapi/v1.0/account/{accountId}/call-recording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Put(callRecordingSettingsResource);
}
```

- Parameter `callRecordingSettingsResource` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingSettings) in API Explorer.


## Update Call Recording Extension List

HTTP POST `/restapi/v1.0/account/{accountId}/call-recording/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
}
```

- Parameter `bulkAccountCallRecordingsResource` is of type [BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/BulkAccountCallRecordingsResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingExtensionList) in API Explorer.


## Get Call Recording Custom Greeting List

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Get(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- `result` is of type [CallRecordingCustomGreetings](./RingCentral.Net/Definitions/CallRecordingCustomGreetings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCallRecordingCustomGreetings) in API Explorer.


## Delete Call Recording Custom Greeting

HTTP DELETE `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCallRecordingCustomGreeting) in API Explorer.


## Get Call Recording Extension List

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording/extensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().Get();
}
```


- `result` is of type [CallRecordingExtensions](./RingCentral.Net/Definitions/CallRecordingExtensions.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCallRecordingExtensions) in API Explorer.


## Assign Multiple Department Members

HTTP POST `/restapi/v1.0/account/{accountId}/department/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Department().BulkAssign().Post(departmentBulkAssignResource);
}
```

- Parameter `departmentBulkAssignResource` is of type [DepartmentBulkAssignResource](./RingCentral.Net/Definitions/DepartmentBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleDepartmentMembers) in API Explorer.


## Get Department Member List

HTTP GET `/restapi/v1.0/account/{accountId}/department/{departmentId}/members`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Department(departmentId).Members().Get(listDepartmentMembersParameters);
}
```

- Parameter `listDepartmentMembersParameters` is of type [ListDepartmentMembersParameters](./RingCentral.Net/Definitions/ListDepartmentMembersParameters.cs)
- `result` is of type [DepartmentMemberList](./RingCentral.Net/Definitions/DepartmentMemberList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listDepartmentMembers) in API Explorer.


## Get Device

HTTP GET `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Get(readDeviceParameters);
}
```

- Parameter `readDeviceParameters` is of type [ReadDeviceParameters](./RingCentral.Net/Definitions/ReadDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-readDevice) in API Explorer.


## Update Device

HTTP PUT `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Put(accountDeviceUpdate);
}
```

- Parameter `accountDeviceUpdate` is of type [AccountDeviceUpdate](./RingCentral.Net/Definitions/AccountDeviceUpdate.cs)
- `result` is of type [DeviceResource](./RingCentral.Net/Definitions/DeviceResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.


## Get Company Directory Entries

HTTP GET `/restapi/v1.0/account/{accountId}/directory/entries`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters);
}
```

- Parameter `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-listDirectoryEntries) in API Explorer.


## Search Company Directory Entries

HTTP POST `/restapi/v1.0/account/{accountId}/directory/entries/search`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest);
}
```

- Parameter `searchDirectoryEntriesRequest` is of type [SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/SearchDirectoryEntriesRequest.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.


## Get Corporate Directory Entry

HTTP GET `/restapi/v1.0/account/{accountId}/directory/entries/{entryId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).Get();
}
```


- `result` is of type [ContactResource](./RingCentral.Net/Definitions/ContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.


## Get Account Federation

HTTP GET `/restapi/v1.0/account/{accountId}/directory/federation`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().Get();
}
```


- `result` is of type [FederationResource](./RingCentral.Net/Definitions/FederationResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readAccountFederation) in API Explorer.


## Get Device List

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().Get(listDevicesAutomaticLocationUpdatesParameters);
}
```

- Parameter `listDevicesAutomaticLocationUpdatesParameters` is of type [ListDevicesAutomaticLocationUpdatesParameters](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdatesParameters.cs)
- `result` is of type [ListDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listDevicesAutomaticLocationUpdates) in API Explorer.


## Enable Automatic Location Updates for Devices

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().Post(assignMultipleDevicesAutomaticLocationUpdates);
}
```

- Parameter `assignMultipleDevicesAutomaticLocationUpdates` is of type [AssignMultipleDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/AssignMultipleDevicesAutomaticLocationUpdates.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.


## Get Network Map

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().List();
}
```


- `result` is of type [NetworksList](./RingCentral.Net/Definitions/NetworksList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listNetworks) in API Explorer.


## Create Network

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().Post(createNetworkRequest);
}
```

- Parameter `createNetworkRequest` is of type [CreateNetworkRequest](./RingCentral.Net/Definitions/CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Get();
}
```


- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readNetwork) in API Explorer.


## Update Network

HTTP PUT `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Put(updateNetworkRequest);
}
```

- Parameter `updateNetworkRequest` is of type [UpdateNetworkRequest](./RingCentral.Net/Definitions/UpdateNetworkRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

HTTP DELETE `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.


## Get Account Switch List

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters);
}
```

- Parameter `listAccountSwitchesParameters` is of type [ListAccountSwitchesParameters](./RingCentral.Net/Definitions/ListAccountSwitchesParameters.cs)
- `result` is of type [SwitchesList](./RingCentral.Net/Definitions/SwitchesList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API Explorer.


## Create Switch

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().Post(createSwitchInfo);
}
```

- Parameter `createSwitchInfo` is of type [CreateSwitchInfo](./RingCentral.Net/Definitions/CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Create Multiple Switches

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().Post(createMultipleSwitchesRequest);
}
```

- Parameter `createMultipleSwitchesRequest` is of type [CreateMultipleSwitchesRequest](./RingCentral.Net/Definitions/CreateMultipleSwitchesRequest.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./RingCentral.Net/Definitions/CreateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API Explorer.


## Update Multiple Switches

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().Post(updateMultipleSwitchesRequest);
}
```

- Parameter `updateMultipleSwitchesRequest` is of type [UpdateMultipleSwitchesRequest](./RingCentral.Net/Definitions/UpdateMultipleSwitchesRequest.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./RingCentral.Net/Definitions/UpdateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API Explorer.


## Validate Multiple Switches

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().Post(validateMultipleSwitchesRequest);
}
```

- Parameter `validateMultipleSwitchesRequest` is of type [ValidateMultipleSwitchesRequest](./RingCentral.Net/Definitions/ValidateMultipleSwitchesRequest.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./RingCentral.Net/Definitions/ValidateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API Explorer.


## Get Switch

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Get();
}
```


- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readSwitch) in API Explorer.


## Update Switch

HTTP PUT `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Put(updateSwitchInfo);
}
```

- Parameter `updateSwitchInfo` is of type [UpdateSwitchInfo](./RingCentral.Net/Definitions/UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

HTTP DELETE `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteSwitch) in API Explorer.


## Get Emergency Map Configuration Task

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).Get();
}
```


- `result` is of type [AutomaticLocationUpdatesTaskInfo](./RingCentral.Net/Definitions/AutomaticLocationUpdatesTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readAutomaticLocationUpdatesTask) in API Explorer.


## Get User List

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().Get(listAutomaticLocationUpdatesUsersParameters);
}
```

- Parameter `listAutomaticLocationUpdatesUsersParameters` is of type [ListAutomaticLocationUpdatesUsersParameters](./RingCentral.Net/Definitions/ListAutomaticLocationUpdatesUsersParameters.cs)
- `result` is of type [AutomaticLocationUpdatesUserList](./RingCentral.Net/Definitions/AutomaticLocationUpdatesUserList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAutomaticLocationUpdatesUsers) in API Explorer.


## Enable Automatic Location Updates for Users

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().Post(bulkAssignAutomaticaLocationUpdatesUsers);
}
```

- Parameter `bulkAssignAutomaticaLocationUpdatesUsers` is of type [BulkAssignAutomaticaLocationUpdatesUsers](./RingCentral.Net/Definitions/BulkAssignAutomaticaLocationUpdatesUsers.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.


## Get Wireless Point List

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().List(listWirelessPointsParameters);
}
```

- Parameter `listWirelessPointsParameters` is of type [ListWirelessPointsParameters](./RingCentral.Net/Definitions/ListWirelessPointsParameters.cs)
- `result` is of type [WirelessPointsList](./RingCentral.Net/Definitions/WirelessPointsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API Explorer.


## Create Wireless Point

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().Post(createWirelessPoint);
}
```

- Parameter `createWirelessPoint` is of type [CreateWirelessPoint](./RingCentral.Net/Definitions/CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Create Multiple Wireless Points

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().Post(createMultipleWirelessPointsRequest);
}
```

- Parameter `createMultipleWirelessPointsRequest` is of type [CreateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsRequest.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in API Explorer.


## Update Multiple Wireless Points

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().Post(updateMultipleWirelessPointsRequest);
}
```

- Parameter `updateMultipleWirelessPointsRequest` is of type [UpdateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsRequest.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in API Explorer.


## Validate Multiple Wireless Points

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().Post(validateMultipleWirelessPointsRequest);
}
```

- Parameter `validateMultipleWirelessPointsRequest` is of type [ValidateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsRequest.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints) in API Explorer.


## Get Wireless Point

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Get();
}
```


- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API Explorer.


## Update Wireless Point

HTTP PUT `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Put(updateWirelessPoint);
}
```

- Parameter `updateWirelessPoint` is of type [UpdateWirelessPoint](./RingCentral.Net/Definitions/UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

HTTP DELETE `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API Explorer.


## Add Emergency Location

HTTP POST `/restapi/v1.0/account/{accountId}/emergency-locations`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().Post(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-locations`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().List(listEmergencyLocationsParameters);
}
```

- Parameter `listEmergencyLocationsParameters` is of type [ListEmergencyLocationsParameters](./RingCentral.Net/Definitions/ListEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationList](./RingCentral.Net/Definitions/EmergencyLocationList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API Explorer.


## Get Emergency Location

HTTP GET `/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Get();
}
```


- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API Explorer.


## Update Emergency Location

HTTP PUT `/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Put(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Get Extension List

HTTP GET `/restapi/v1.0/account/{accountId}/extension`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().List(listExtensionsParameters);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- `result` is of type [GetExtensionListResponse](./RingCentral.Net/Definitions/GetExtensionListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listExtensions) in API Explorer.


## Create Extension

HTTP POST `/restapi/v1.0/account/{accountId}/extension`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Post(extensionCreationRequest);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Get();
}
```


- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtension) in API Explorer.


## Update Extension

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Delete(deleteExtensionParameters);
}
```

- Parameter `deleteExtensionParameters` is of type [DeleteExtensionParameters](./RingCentral.Net/Definitions/DeleteExtensionParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteExtension) in API Explorer.


## Get User Active Calls

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
}
```

- Parameter `listExtensionActiveCallsParameters` is of type [ListExtensionActiveCallsParameters](./RingCentral.Net/Definitions/ListExtensionActiveCallsParameters.cs)
- `result` is of type [UserActiveCallsResponse](./RingCentral.Net/Definitions/UserActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listExtensionActiveCalls) in API Explorer.


## Address Book Synchronization

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
}
```

- Parameter `syncAddressBookParameters` is of type [SyncAddressBookParameters](./RingCentral.Net/Definitions/SyncAddressBookParameters.cs)
- `result` is of type [AddressBookSync](./RingCentral.Net/Definitions/AddressBookSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-syncAddressBook) in API Explorer.


## Get Contact List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- `result` is of type [ContactList](./RingCentral.Net/Definitions/ContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.


## Create Contact

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters);
}
```

- Parameter `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.


## Get Contact

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get();
}
```


- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.


## Update Contact

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactRequest, updateContactParameters);
}
```

- Parameter `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.


## Delete Contact

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.


## Get Call Handling Rules

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- `result` is of type [UserAnsweringRuleList](./RingCentral.Net/Definitions/UserAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listAnsweringRules) in API Explorer.


## Create Call Handling Rule

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(readAnsweringRuleParameters);
}
```

- Parameter `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./RingCentral.Net/Definitions/ReadAnsweringRuleParameters.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readAnsweringRule) in API Explorer.


## Update Call Handling Rule

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteAnsweringRule) in API Explorer.


## Get Authorization Profile

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Get();
}
```


- `result` is of type [AuthProfileResource](./RingCentral.Net/Definitions/AuthProfileResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readAuthorizationProfile) in API Explorer.


## Check User Permission

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
}
```

- Parameter `checkUserPermissionParameters` is of type [CheckUserPermissionParameters](./RingCentral.Net/Definitions/CheckUserPermissionParameters.cs)
- `result` is of type [AuthProfileCheckResource](./RingCentral.Net/Definitions/AuthProfileCheckResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-checkUserPermission) in API Explorer.


## Get User Business Hours

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Get();
}
```


- `result` is of type [GetUserBusinessHoursResponse](./RingCentral.Net/Definitions/GetUserBusinessHoursResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readUserBusinessHours) in API Explorer.


## Update User Business Hours

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest);
}
```

- Parameter `userBusinessHoursUpdateRequest` is of type [UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/UserBusinessHoursUpdateRequest.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./RingCentral.Net/Definitions/UserBusinessHoursUpdateResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.


## Get User Call Log Records

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters);
}
```

- Parameter `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./RingCentral.Net/Definitions/ReadUserCallLogParameters.cs)
- `result` is of type [UserCallLogResponse](./RingCentral.Net/Definitions/UserCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.


## Delete User Call Log

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.


## Sync User Call Log

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
}
```

- Parameter `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./RingCentral.Net/Definitions/SyncUserCallLogParameters.cs)
- `result` is of type [CallLogSync](./RingCentral.Net/Definitions/CallLogSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncUserCallLog) in API Explorer.


## Get User Call Record

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(readUserCallRecordParameters);
}
```

- Parameter `readUserCallRecordParameters` is of type [ReadUserCallRecordParameters](./RingCentral.Net/Definitions/ReadUserCallRecordParameters.cs)
- `result` is of type [UserCallLogRecord](./RingCentral.Net/Definitions/UserCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.


## Update User Call Queues

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().Put(userCallQueues);
}
```

- Parameter `userCallQueues` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- `result` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.


## Get Caller Blocking Settings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Get();
}
```


- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readCallerBlockingSettings) in API Explorer.


## Update Caller Blocking Settings

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
}
```

- Parameter `callerBlockingSettingsUpdate` is of type [CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/CallerBlockingSettingsUpdate.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API Explorer.


## Get Blocked/Allowed Phone Numbers

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedNumbersParameters);
}
```

- Parameter `listBlockedAllowedNumbersParameters` is of type [ListBlockedAllowedNumbersParameters](./RingCentral.Net/Definitions/ListBlockedAllowedNumbersParameters.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumbersList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-listBlockedAllowedNumbers) in API Explorer.


## Add Blocked/Allowed Number

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get();
}
```


- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readBlockedAllowedNumber) in API Explorer.


## Delete Blocked/Allowed Number

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.


## Update Blocked/Allowed Number

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Extension Caller ID

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Get();
}
```


- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtensionCallerId) in API Explorer.


## Update Extension Caller ID

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo);
}
```

- Parameter `extensionCallerIdInfo` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtensionCallerId) in API Explorer.


## Create Internal Text Message

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest);
}
```

- Parameter `createInternalTextMessageRequest` is of type [CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/CreateInternalTextMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Pager-Messages-createInternalTextMessage) in API Explorer.


## Get User Conferencing Settings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Get(readConferencingSettingsParameters);
}
```

- Parameter `readConferencingSettingsParameters` is of type [ReadConferencingSettingsParameters](./RingCentral.Net/Definitions/ReadConferencingSettingsParameters.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readConferencingSettings) in API Explorer.


## Update User Conferencing Settings

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
}
```

- Parameter `updateConferencingInfoRequest` is of type [UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/UpdateConferencingInfoRequest.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.


## Get Extension Device List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/device`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters);
}
```

- Parameter `listExtensionDevicesParameters` is of type [ListExtensionDevicesParameters](./RingCentral.Net/Definitions/ListExtensionDevicesParameters.cs)
- `result` is of type [GetExtensionDevicesResponse](./RingCentral.Net/Definitions/GetExtensionDevicesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-listExtensionDevices) in API Explorer.


## Get Favorite Contact List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Get();
}
```


- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listFavoriteContacts) in API Explorer.


## Update Favorite Contact List

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection);
}
```

- Parameter `favoriteCollection` is of type [FavoriteCollection](./RingCentral.Net/Definitions/FavoriteCollection.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API Explorer.


## Create Fax Message

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().Post(createFaxMessageRequest);
}
```

- Parameter `createFaxMessageRequest` is of type [CreateFaxMessageRequest](./RingCentral.Net/Definitions/CreateFaxMessageRequest.cs)
- `result` is of type [FaxResponse](./RingCentral.Net/Definitions/FaxResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-createFaxMessage) in API Explorer.


## Get User Features

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/features`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Features().Get(readUserFeaturesParameters);
}
```

- Parameter `readUserFeaturesParameters` is of type [ReadUserFeaturesParameters](./RingCentral.Net/Definitions/ReadUserFeaturesParameters.cs)
- `result` is of type [FeatureList](./RingCentral.Net/Definitions/FeatureList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Features-readUserFeatures) in API Explorer.


## Get Forwarding Number List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().List(listForwardingNumbersParameters);
}
```

- Parameter `listForwardingNumbersParameters` is of type [ListForwardingNumbersParameters](./RingCentral.Net/Definitions/ListForwardingNumbersParameters.cs)
- `result` is of type [GetExtensionForwardingNumberListResponse](./RingCentral.Net/Definitions/GetExtensionForwardingNumberListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-listForwardingNumbers) in API Explorer.


## Create Forwarding Number

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get();
}
```


- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-readForwardingNumber) in API Explorer.


## Update Forwarding Number

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.


## Get Extension Grant List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters);
}
```

- Parameter `listExtensionGrantsParameters` is of type [ListExtensionGrantsParameters](./RingCentral.Net/Definitions/ListExtensionGrantsParameters.cs)
- `result` is of type [GetExtensionGrantListResponse](./RingCentral.Net/Definitions/GetExtensionGrantListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-listExtensionGrants) in API Explorer.


## Create Custom User Greeting

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Post(createCustomUserGreetingRequest);
}
```

- Parameter `createCustomUserGreetingRequest` is of type [CreateCustomUserGreetingRequest](./RingCentral.Net/Definitions/CreateCustomUserGreetingRequest.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCustomUserGreeting) in API Explorer.


## Get Custom Greeting

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Get();
}
```


- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCustomGreeting) in API Explorer.


## Get Scheduled Meetings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().List();
}
```


- `result` is of type [MeetingsResource](./RingCentral.Net/Definitions/MeetingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-listMeetings) in API Explorer.


## Create Meetings

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Post(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get User Meeting Recordings List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingRecordings().Get(listUserMeetingRecordingsParameters);
}
```

- Parameter `listUserMeetingRecordingsParameters` is of type [ListUserMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListUserMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listUserMeetingRecordings) in API Explorer.


## Get Meeting Service Info

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Get();
}
```


- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readMeetingServiceInfo) in API Explorer.


## Get Meeting Info

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Get();
}
```


- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeeting) in API Explorer.


## Update Meeting

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Put(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-deleteMeeting) in API Explorer.


## End Meeting

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).End().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-endMeeting) in API Explorer.


## Get Assistants

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assistants().Get();
}
```


- `result` is of type [AssistantsResource](./RingCentral.Net/Definitions/AssistantsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistants) in API Explorer.


## Get Assisted Users

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assisted().Get();
}
```


- `result` is of type [AssistedUsersResource](./RingCentral.Net/Definitions/AssistedUsersResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistedUsers) in API Explorer.


## Get Message List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- `result` is of type [GetMessageList](./RingCentral.Net/Definitions/GetMessageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-listMessages) in API Explorer.


## Get Message

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Get();
}
```


- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.


## Update Message(s)

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageParameters);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.


## Get Message Content

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(readMessageContentParameters);
}
```

- Parameter `readMessageContentParameters` is of type [ReadMessageContentParameters](./RingCentral.Net/Definitions/ReadMessageContentParameters.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageContent) in API Explorer.


## Sync Messages

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters);
}
```

- Parameter `syncMessagesParameters` is of type [SyncMessagesParameters](./RingCentral.Net/Definitions/SyncMessagesParameters.cs)
- `result` is of type [GetMessageSyncResponse](./RingCentral.Net/Definitions/GetMessageSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-syncMessages) in API Explorer.


## Create MMS Message

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/mms`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().Post(createSmsMessage);
}
```

- Parameter `createSmsMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#MMS-createMMS) in API Explorer.


## Get Notification Settings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Get();
}
```


- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readNotificationSettings) in API Explorer.


## Update Notification Settings

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
}
```

- Parameter `notificationSettingsUpdateRequest` is of type [NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/NotificationSettingsUpdateRequest.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateNotificationSettings) in API Explorer.


## Get Extension Phone Number List

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
}
```

- Parameter `listExtensionPhoneNumbersParameters` is of type [ListExtensionPhoneNumbersParameters](./RingCentral.Net/Definitions/ListExtensionPhoneNumbersParameters.cs)
- `result` is of type [GetExtensionPhoneNumbersResponse](./RingCentral.Net/Definitions/GetExtensionPhoneNumbersResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listExtensionPhoneNumbers) in API Explorer.


## Get User Presence Status

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Get(readUserPresenceStatusParameters);
}
```

- Parameter `readUserPresenceStatusParameters` is of type [ReadUserPresenceStatusParameters](./RingCentral.Net/Definitions/ReadUserPresenceStatusParameters.cs)
- `result` is of type [GetPresenceInfo](./RingCentral.Net/Definitions/GetPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUserPresenceStatus) in API Explorer.


## Update User Presence Status

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Put(presenceInfoResource);
}
```

- Parameter `presenceInfoResource` is of type [PresenceInfoResource](./RingCentral.Net/Definitions/PresenceInfoResource.cs)
- `result` is of type [PresenceInfoResource](./RingCentral.Net/Definitions/PresenceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.


## Get User Profile Image

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().List();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImage) in API Explorer.


## Upload User Profile Image

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Post(createUserProfileImageRequest);
}
```

- Parameter `createUserProfileImageRequest` is of type [CreateUserProfileImageRequest](./RingCentral.Net/Definitions/CreateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-createUserProfileImage) in API Explorer.


## Update User Profile Image

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Put(updateUserProfileImageRequest);
}
```

- Parameter `updateUserProfileImageRequest` is of type [UpdateUserProfileImageRequest](./RingCentral.Net/Definitions/UpdateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.


## Get Scaled User Profile Image

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledPofileImage) in API Explorer.


## Make RingOut Call

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Get();
}
```


- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Send SMS

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().Post(createSmsMessage);
}
```

- Parameter `createSmsMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.


## Get Unified Presence

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Get();
}
```


- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUnifiedPresence) in API Explorer.


## Update Unified Presence

HTTP PATCH `/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Patch(updateUnifiedPresence);
}
```

- Parameter `updateUnifiedPresence` is of type [UpdateUnifiedPresence](./RingCentral.Net/Definitions/UpdateUnifiedPresence.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.


## Create Company Greeting

HTTP POST `/restapi/v1.0/account/{accountId}/greeting`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().Post(createCompanyGreetingRequest);
}
```

- Parameter `createCompanyGreetingRequest` is of type [CreateCompanyGreetingRequest](./RingCentral.Net/Definitions/CreateCompanyGreetingRequest.cs)
- `result` is of type [CustomCompanyGreetingInfo](./RingCentral.Net/Definitions/CustomCompanyGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyGreeting) in API Explorer.


## Create IVR Menu

HTTP POST `/restapi/v1.0/account/{accountId}/ivr-menus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Post(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRMenu) in API Explorer.


## Get IVR Menu

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Get();
}
```


- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRMenu) in API Explorer.


## Update IVR Menu

HTTP PUT `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Put(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRMenu) in API Explorer.


## Create IVR Prompts

HTTP POST `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Post(createIvrPromptRequest);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRPrompt) in API Explorer.


## Get IVR Prompt List

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().List();
}
```


- `result` is of type [IVRPrompts](./RingCentral.Net/Definitions/IVRPrompts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-listIVRPrompts) in API Explorer.


## Get IVR Prompt

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Get();
}
```


- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRPrompt) in API Explorer.


## Delete IVR Prompt

HTTP DELETE `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-deleteIVRPrompt) in API Explorer.


## Update IVR Prompt

HTTP PUT `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Put(updateIvrPromptRequest);
}
```

- Parameter `updateIvrPromptRequest` is of type [UpdateIVRPromptRequest](./RingCentral.Net/Definitions/UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRPrompt) in API Explorer.


## Get IVR Prompt Content

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().Get();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRPromptContent) in API Explorer.


## Get Account Meeting Recordings List

HTTP GET `/restapi/v1.0/account/{accountId}/meeting-recordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MeetingRecordings().Get(listAccountMeetingRecordingsParameters);
}
```

- Parameter `listAccountMeetingRecordingsParameters` is of type [ListAccountMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListAccountMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listAccountMeetingRecordings) in API Explorer.


## Get Message Store Configuration

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Get();
}
```


- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageStoreConfiguration) in API Explorer.


## Update Message Store Configuration

HTTP PUT `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration);
}
```

- Parameter `messageStoreConfiguration` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API Explorer.


## Create Message Store Report

HTTP POST `/restapi/v1.0/account/{accountId}/message-store-report`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Get();
}
```


- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API Explorer.


## Get Message Store Report Archive

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().List();
}
```


- `result` is of type [MessageStoreReportArchive](./RingCentral.Net/Definitions/MessageStoreReportArchive.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API Explorer.


## Get Message Store Report Archive Content

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).Get();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchiveContent) in API Explorer.


## Assign Paging Group Users and Devices

HTTP POST `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
}
```

- Parameter `editPagingGroupRequest` is of type [EditPagingGroupRequest](./RingCentral.Net/Definitions/EditPagingGroupRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices) in API Explorer.


## Get Paging Group Devices

HTTP GET `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters);
}
```

- Parameter `listPagingGroupDevicesParameters` is of type [ListPagingGroupDevicesParameters](./RingCentral.Net/Definitions/ListPagingGroupDevicesParameters.cs)
- `result` is of type [PagingOnlyGroupDevices](./RingCentral.Net/Definitions/PagingOnlyGroupDevices.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupDevices) in API Explorer.


## Get Paging Group Users

HTTP GET `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters);
}
```

- Parameter `listPagingGroupUsersParameters` is of type [ListPagingGroupUsersParameters](./RingCentral.Net/Definitions/ListPagingGroupUsersParameters.cs)
- `result` is of type [PagingOnlyGroupUsers](./RingCentral.Net/Definitions/PagingOnlyGroupUsers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupUsers) in API Explorer.


## Get Company Phone Number List

HTTP GET `/restapi/v1.0/account/{accountId}/phone-number`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- `result` is of type [AccountPhoneNumbers](./RingCentral.Net/Definitions/AccountPhoneNumbers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbers) in API Explorer.


## Get Phone Number

HTTP GET `/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).Get();
}
```


- `result` is of type [CompanyPhoneNumberInfo](./RingCentral.Net/Definitions/CompanyPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.


## Get User Presence Status List

HTTP GET `/restapi/v1.0/account/{accountId}/presence`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Presence().Get(readAccountPresenceParameters);
}
```

- Parameter `readAccountPresenceParameters` is of type [ReadAccountPresenceParameters](./RingCentral.Net/Definitions/ReadAccountPresenceParameters.cs)
- `result` is of type [AccountPresenceInfo](./RingCentral.Net/Definitions/AccountPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readAccountPresence) in API Explorer.


## Get Call Recording

HTTP GET `/restapi/v1.0/account/{accountId}/recording/{recordingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Get();
}
```


- `result` is of type [GetCallRecordingResponse](./RingCentral.Net/Definitions/GetCallRecordingResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecording) in API Explorer.


## Get Call Recordings Data

HTTP GET `/restapi/v1.0/account/{accountId}/recording/{recordingId}/content`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().Get();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-listCallRecordingData) in API Explorer.


## Get Account Service Info

HTTP GET `/restapi/v1.0/account/{accountId}/service-info`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().Get();
}
```


- `result` is of type [GetServiceInfoResponse](./RingCentral.Net/Definitions/GetServiceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountServiceInfo) in API Explorer.


## Make CallOut

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/call-out`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().Post(makeCallOutRequest);
}
```

- Parameter `makeCallOutRequest` is of type [MakeCallOutRequest](./RingCentral.Net/Definitions/MakeCallOutRequest.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallOutCallSession) in API Explorer.


## Get Call Session Status

HTTP GET `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Get(readCallSessionStatusParameters);
}
```

- Parameter `readCallSessionStatusParameters` is of type [ReadCallSessionStatusParameters](./RingCentral.Net/Definitions/ReadCallSessionStatusParameters.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallSessionStatus) in API Explorer.


## Drop Call Session

HTTP DELETE `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallSession) in API Explorer.


## Get Call Party Status

HTTP GET `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Get();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallPartyStatus) in API Explorer.


## Update Call Party

HTTP PATCH `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Patch(partyUpdateRequest);
}
```

- Parameter `partyUpdateRequest` is of type [PartyUpdateRequest](./RingCentral.Net/Definitions/PartyUpdateRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.


## Answer Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().Post(answerTarget);
}
```

- Parameter `answerTarget` is of type [AnswerTarget](./RingCentral.Net/Definitions/AnswerTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-answerCallParty) in API Explorer.


## Call Flip on Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().Post(callPartyFlip);
}
```

- Parameter `callPartyFlip` is of type [CallPartyFlip](./RingCentral.Net/Definitions/CallPartyFlip.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callFlipParty) in API Explorer.


## Forward Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget);
}
```

- Parameter `forwardTarget` is of type [ForwardTarget](./RingCentral.Net/Definitions/ForwardTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-forwardCallParty) in API Explorer.


## Hold Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().Post();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-holdCallParty) in API Explorer.


## Ignore Call in Queue

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().Post(ignoreRequestBody);
}
```

- Parameter `ignoreRequestBody` is of type [IgnoreRequestBody](./RingCentral.Net/Definitions/IgnoreRequestBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.


## Call Park

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Park().Post();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callParkParty) in API Explorer.


## Pickup Call

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().Post(pickupTarget);
}
```

- Parameter `pickupTarget` is of type [PickupTarget](./RingCentral.Net/Definitions/PickupTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pickupCallParty) in API Explorer.


## Create Recording

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-startCallRecording) in API Explorer.


## Pause/Resume Recording

HTTP PATCH `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Reject Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-rejectParty) in API Explorer.


## Reply with Text

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().Post(callPartyReply);
}
```

- Parameter `callPartyReply` is of type [CallPartyReply](./RingCentral.Net/Definitions/CallPartyReply.cs)
- `result` is of type [ReplyParty](./RingCentral.Net/Definitions/ReplyParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-replyParty) in API Explorer.


## Supervise Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().Post(partySuperviseRequest);
}
```

- Parameter `partySuperviseRequest` is of type [PartySuperviseRequest](./RingCentral.Net/Definitions/PartySuperviseRequest.cs)
- `result` is of type [PartySuperviseResponse](./RingCentral.Net/Definitions/PartySuperviseResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallParty) in API Explorer.


## Transfer Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().Post(transferTarget);
}
```

- Parameter `transferTarget` is of type [TransferTarget](./RingCentral.Net/Definitions/TransferTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-transferCallParty) in API Explorer.


## Unhold Call Party

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().Post();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-unholdCallParty) in API Explorer.


## Supervise Call Session

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest);
}
```

- Parameter `superviseCallSessionRequest` is of type [SuperviseCallSessionRequest](./RingCentral.Net/Definitions/SuperviseCallSessionRequest.cs)
- `result` is of type [SuperviseCallSession](./RingCentral.Net/Definitions/SuperviseCallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.


## Get User Template List

HTTP GET `/restapi/v1.0/account/{accountId}/templates`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().List(listUserTemplatesParameters);
}
```

- Parameter `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./RingCentral.Net/Definitions/ListUserTemplatesParameters.cs)
- `result` is of type [UserTemplates](./RingCentral.Net/Definitions/UserTemplates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listUserTemplates) in API Explorer.


## Get User Template

HTTP GET `/restapi/v1.0/account/{accountId}/templates/{templateId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).Get();
}
```


- `result` is of type [TemplateInfo](./RingCentral.Net/Definitions/TemplateInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.


## Register SIP Device

HTTP POST `/restapi/v1.0/client-info/sip-provision`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().Post(createSipRegistrationRequest);
}
```

- Parameter `createSipRegistrationRequest` is of type [CreateSipRegistrationRequest](./RingCentral.Net/Definitions/CreateSipRegistrationRequest.cs)
- `result` is of type [CreateSipRegistrationResponse](./RingCentral.Net/Definitions/CreateSipRegistrationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#SIP-createSIPRegistration) in API Explorer.


## Get Country List

HTTP GET `/restapi/v1.0/dictionary/country`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country().List(listCountriesParameters);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listCountries) in API Explorer.


## Get Country

HTTP GET `/restapi/v1.0/dictionary/country/{countryId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).Get();
}
```


- `result` is of type [GetCountryInfoDictionaryResponse](./RingCentral.Net/Definitions/GetCountryInfoDictionaryResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.


## Get Fax Cover Page List

HTTP GET `/restapi/v1.0/dictionary/fax-cover-page`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters);
}
```

- Parameter `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./RingCentral.Net/Definitions/ListFaxCoverPagesParameters.cs)
- `result` is of type [ListFaxCoverPagesResponse](./RingCentral.Net/Definitions/ListFaxCoverPagesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-listFaxCoverPages) in API Explorer.


## Get Standard Greeting List

HTTP GET `/restapi/v1.0/dictionary/greeting`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().List(listStandardGreetingsParameters);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- `result` is of type [DictionaryGreetingList](./RingCentral.Net/Definitions/DictionaryGreetingList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listStandardGreetings) in API Explorer.


## Get Standard Greeting

HTTP GET `/restapi/v1.0/dictionary/greeting/{greetingId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).Get();
}
```


- `result` is of type [DictionaryGreetingInfo](./RingCentral.Net/Definitions/DictionaryGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readStandardGreeting) in API Explorer.


## Get Language List

HTTP GET `/restapi/v1.0/dictionary/language`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language().List();
}
```


- `result` is of type [LanguageList](./RingCentral.Net/Definitions/LanguageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLanguages) in API Explorer.


## Get Language

HTTP GET `/restapi/v1.0/dictionary/language/{languageId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).Get();
}
```


- `result` is of type [LanguageInfo](./RingCentral.Net/Definitions/LanguageInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.


## Get Location List

HTTP GET `/restapi/v1.0/dictionary/location`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Location().Get(listLocationsParameters);
}
```

- Parameter `listLocationsParameters` is of type [ListLocationsParameters](./RingCentral.Net/Definitions/ListLocationsParameters.cs)
- `result` is of type [GetLocationListResponse](./RingCentral.Net/Definitions/GetLocationListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLocations) in API Explorer.


## Get States List

HTTP GET `/restapi/v1.0/dictionary/state`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State().List(listStatesParameters);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- `result` is of type [GetStateListResponse](./RingCentral.Net/Definitions/GetStateListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listStates) in API Explorer.


## Get State

HTTP GET `/restapi/v1.0/dictionary/state/{stateId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).Get();
}
```


- `result` is of type [GetStateInfoResponse](./RingCentral.Net/Definitions/GetStateInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.


## Get Timezone List

HTTP GET `/restapi/v1.0/dictionary/timezone`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().List(listTimezonesParameters);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- `result` is of type [GetTimezoneListResponse](./RingCentral.Net/Definitions/GetTimezoneListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listTimezones) in API Explorer.


## Get Timezone

HTTP GET `/restapi/v1.0/dictionary/timezone/{timezoneId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).Get(readTimezoneParameters);
}
```

- Parameter `readTimezoneParameters` is of type [ReadTimezoneParameters](./RingCentral.Net/Definitions/ReadTimezoneParameters.cs)
- `result` is of type [GetTimezoneInfoResponse](./RingCentral.Net/Definitions/GetTimezoneInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.


## Create Card

HTTP POST `/restapi/v1.0/glip/cards`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().Post(glipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipCard) in API Explorer.


## Get Card

HTTP GET `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Get();
}
```


- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipCard) in API Explorer.


## Update Card

HTTP PUT `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Put(glipMessageAttachmentInfoRequest);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipCard) in API Explorer.


## Delete Card

HTTP DELETE `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipCard) in API Explorer.


## Get Chats

HTTP GET `/restapi/v1.0/glip/chats`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats().List(listGlipChatsParameters);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- `result` is of type [GlipChatsList](./RingCentral.Net/Definitions/GlipChatsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChats) in API Explorer.


## Get Chat

HTTP GET `/restapi/v1.0/glip/chats/{chatId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Get();
}
```


- `result` is of type [GlipChatInfo](./RingCentral.Net/Definitions/GlipChatInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChat) in API Explorer.


## Add Chat to Favorites

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/favorite`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Favorite().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-favoriteGlipChat) in API Explorer.


## Create Note

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/notes`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Post(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNote) in API Explorer.


## Get Chat Notes

HTTP GET `/restapi/v1.0/glip/chats/{chatId}/notes`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Get(listChatNotesParameters);
}
```

- Parameter `listChatNotesParameters` is of type [ListChatNotesParameters](./RingCentral.Net/Definitions/ListChatNotesParameters.cs)
- `result` is of type [GlipNotesInfo](./RingCentral.Net/Definitions/GlipNotesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-listChatNotes) in API Explorer.


## Get Posts

HTTP GET `/restapi/v1.0/glip/chats/{chatId}/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().List(readGlipPostsParameters);
}
```

- Parameter `readGlipPostsParameters` is of type [ReadGlipPostsParameters](./RingCentral.Net/Definitions/ReadGlipPostsParameters.cs)
- `result` is of type [GlipPostsList](./RingCentral.Net/Definitions/GlipPostsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPosts) in API Explorer.


## Create Post

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().Post(glipPostPostBody);
}
```

- Parameter `glipPostPostBody` is of type [GlipPostPostBody](./RingCentral.Net/Definitions/GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

HTTP GET `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Get();
}
```


- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPost) in API Explorer.


## Update Post

HTTP PATCH `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Patch(glipPatchPostBody);
}
```

- Parameter `glipPatchPostBody` is of type [GlipPatchPostBody](./RingCentral.Net/Definitions/GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

HTTP DELETE `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPost) in API Explorer.


## Mark Chat as Read

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/read`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Read().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatRead) in API Explorer.


## Get Chat Tasks

HTTP GET `/restapi/v1.0/glip/chats/{chatId}/tasks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Get(listChatTasksParameters);
}
```

- Parameter `listChatTasksParameters` is of type [ListChatTasksParameters](./RingCentral.Net/Definitions/ListChatTasksParameters.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-listChatTasks) in API Explorer.


## Create Task

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/tasks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Post(glipCreateTask);
}
```

- Parameter `glipCreateTask` is of type [GlipCreateTask](./RingCentral.Net/Definitions/GlipCreateTask.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTask) in API Explorer.


## Remove Chat from Favorites

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/unfavorite`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unfavorite().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-unfavoriteGlipChat) in API Explorer.


## Mark Chat as Unread

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/unread`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unread().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatUnread) in API Explorer.


## Get Company Info

HTTP GET `/restapi/v1.0/glip/companies/{companyId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Companies(companyId).Get();
}
```


- `result` is of type [GlipCompany](./RingCentral.Net/Definitions/GlipCompany.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipCompany) in API Explorer.


## Get Conversations

HTTP GET `/restapi/v1.0/glip/conversations`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().List(listGlipConversationsParameters);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- `result` is of type [GlipConversationsList](./RingCentral.Net/Definitions/GlipConversationsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversations) in API Explorer.


## Create/Open Conversation

HTTP POST `/restapi/v1.0/glip/conversations`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().Post(createGlipConversationRequest);
}
```

- Parameter `createGlipConversationRequest` is of type [CreateGlipConversationRequest](./RingCentral.Net/Definitions/CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

HTTP GET `/restapi/v1.0/glip/conversations/{chatId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).Get();
}
```


- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversation) in API Explorer.


## Create Data Export Task

HTTP POST `/restapi/v1.0/glip/data-export`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().Post(createDataExportTaskRequest);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

HTTP GET `/restapi/v1.0/glip/data-export`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().List(listDataExportTasksParameters);
}
```

- Parameter `listDataExportTasksParameters` is of type [ListDataExportTasksParameters](./RingCentral.Net/Definitions/ListDataExportTasksParameters.cs)
- `result` is of type [DataExportTaskList](./RingCentral.Net/Definitions/DataExportTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-listDataExportTasks) in API Explorer.


## Get Data Export Task

HTTP GET `/restapi/v1.0/glip/data-export/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Get();
}
```


- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTask) in API Explorer.


## Get Data Export Task Dataset

HTTP GET `/restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Datasets(datasetId).Get();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTaskDataset) in API Explorer.


## Get User Events List

HTTP GET `/restapi/v1.0/glip/events`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().List(readGlipEventsParameters);
}
```

- Parameter `readGlipEventsParameters` is of type [ReadGlipEventsParameters](./RingCentral.Net/Definitions/ReadGlipEventsParameters.cs)
- `result` is of type [GlipEventsInfo](./RingCentral.Net/Definitions/GlipEventsInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEvents) in API Explorer.


## Create Event

HTTP POST `/restapi/v1.0/glip/events`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().Post(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

HTTP GET `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Get();
}
```


- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEvent) in API Explorer.


## Update Event

HTTP PUT `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Put(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

HTTP DELETE `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEvent) in API Explorer.


## Get Everyone Chat

HTTP GET `/restapi/v1.0/glip/everyone`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Get();
}
```


- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipEveryone) in API Explorer.


## Update Everyone Сhat

HTTP PATCH `/restapi/v1.0/glip/everyone`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Patch(updateGlipEveryoneRequest);
}
```

- Parameter `updateGlipEveryoneRequest` is of type [UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/UpdateGlipEveryoneRequest.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryone) in API Explorer.


## Get Favorite Chats

HTTP GET `/restapi/v1.0/glip/favorites`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Favorites().Get(listFavoriteChatsParameters);
}
```

- Parameter `listFavoriteChatsParameters` is of type [ListFavoriteChatsParameters](./RingCentral.Net/Definitions/ListFavoriteChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listFavoriteChats) in API Explorer.


## Get User Groups

HTTP GET `/restapi/v1.0/glip/groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().List(listGlipGroupsParameters);
}
```

- Parameter `listGlipGroupsParameters` is of type [ListGlipGroupsParameters](./RingCentral.Net/Definitions/ListGlipGroupsParameters.cs)
- `result` is of type [GlipGroupList](./RingCentral.Net/Definitions/GlipGroupList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipGroups) in API Explorer.


## Create Group

HTTP POST `/restapi/v1.0/glip/groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().Post(glipCreateGroup);
}
```

- Parameter `glipCreateGroup` is of type [GlipCreateGroup](./RingCentral.Net/Definitions/GlipCreateGroup.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-createGlipGroup) in API Explorer.


## Get Group

HTTP GET `/restapi/v1.0/glip/groups/{groupId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Get();
}
```


- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipGroup) in API Explorer.


## Edit Group Members

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).BulkAssign().Post(editGroupRequest);
}
```

- Parameter `editGroupRequest` is of type [EditGroupRequest](./RingCentral.Net/Definitions/EditGroupRequest.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-assignGlipGroupMembers) in API Explorer.


## Create Event by Group ID

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Post(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventbyGroupId) in API Explorer.


## Get Group Events

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Get();
}
```


- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-listGroupEvents) in API Explorer.


## Get Group Posts

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().Get(listGlipGroupPostsParameters);
}
```

- Parameter `listGlipGroupPostsParameters` is of type [ListGlipGroupPostsParameters](./RingCentral.Net/Definitions/ListGlipGroupPostsParameters.cs)
- `result` is of type [GlipPosts](./RingCentral.Net/Definitions/GlipPosts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-listGlipGroupPosts) in API Explorer.


## Create Post in Group

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().Post(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipGroupPost) in API Explorer.


## Update Post

HTTP PUT `/restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts(postId).Text().Put(string);
}
```

- Parameter `string` is of type [string](./RingCentral.Net/Definitions/string.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipPostText) in API Explorer.


## Create Webhook in Group

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Post();
}
```


- `result` is of type [GlipWebhookInfo](./RingCentral.Net/Definitions/GlipWebhookInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-createGlipGroupWebhook) in API Explorer.


## Get Webhooks in Group

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Get();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipGroupWebhooks) in API Explorer.


## Get Note

HTTP GET `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Get();
}
```


- `result` is of type [GetGlipNoteInfo](./RingCentral.Net/Definitions/GetGlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-readUserNote) in API Explorer.


## Update Note

HTTP PATCH `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Patch(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNote) in API Explorer.


## Delete Note

HTTP DELETE `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-deleteNote) in API Explorer.


## Lock Note

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/lock`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Lock().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-lockNote) in API Explorer.


## Publish Note

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/publish`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Publish().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-publishNote) in API Explorer.


## Unlock Note

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/unlock`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Unlock().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-unlockNote) in API Explorer.


## Get Person

HTTP GET `/restapi/v1.0/glip/persons/{personId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Persons(personId).Get();
}
```


- `result` is of type [GlipPersonInfo](./RingCentral.Net/Definitions/GlipPersonInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPerson) in API Explorer.


## Get Posts

HTTP GET `/restapi/v1.0/glip/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Posts().Get(listGlipPostsParameters);
}
```

- Parameter `listGlipPostsParameters` is of type [ListGlipPostsParameters](./RingCentral.Net/Definitions/ListGlipPostsParameters.cs)
- `result` is of type [GlipPosts](./RingCentral.Net/Definitions/GlipPosts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-listGlipPosts) in API Explorer.


## Create Post

HTTP POST `/restapi/v1.0/glip/posts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Posts().Post(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createPost) in API Explorer.


## Get Preferences

HTTP GET `/restapi/v1.0/glip/preferences`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Preferences().Get();
}
```


- `result` is of type [GlipPreferencesInfo](./RingCentral.Net/Definitions/GlipPreferencesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPreferences) in API Explorer.


## Get Recent Chats

HTTP GET `/restapi/v1.0/glip/recent/chats`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Recent().Chats().Get(listRecentChatsParameters);
}
```

- Parameter `listRecentChatsParameters` is of type [ListRecentChatsParameters](./RingCentral.Net/Definitions/ListRecentChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listRecentChats) in API Explorer.


## Get Task

HTTP GET `/restapi/v1.0/glip/tasks/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Get();
}
```


- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-readTask) in API Explorer.


## Patch Task

HTTP PATCH `/restapi/v1.0/glip/tasks/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Patch(glipUpdateTask);
}
```

- Parameter `glipUpdateTask` is of type [GlipUpdateTask](./RingCentral.Net/Definitions/GlipUpdateTask.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTask) in API Explorer.


## Delete Task

HTTP DELETE `/restapi/v1.0/glip/tasks/{taskId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-deleteTask) in API Explorer.


## Complete Task

HTTP POST `/restapi/v1.0/glip/tasks/{taskId}/complete`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Complete().Post(glipCompleteTask);
}
```

- Parameter `glipCompleteTask` is of type [GlipCompleteTask](./RingCentral.Net/Definitions/GlipCompleteTask.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTask) in API Explorer.


## Get Teams

HTTP GET `/restapi/v1.0/glip/teams`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().List(listGlipTeamsParameters);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- `result` is of type [GlipTeamsList](./RingCentral.Net/Definitions/GlipTeamsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeams) in API Explorer.


## Create Team

HTTP POST `/restapi/v1.0/glip/teams`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().Post(glipPostTeamBody);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

HTTP GET `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Get();
}
```


- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeam) in API Explorer.


## Update Team

HTTP PATCH `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Patch(glipPatchTeamBody);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

HTTP DELETE `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeam) in API Explorer.


## Add Team Members

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/add`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().Post(glipPostMembersListBody);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembers) in API Explorer.


## Archive Team

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/archive`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Archive().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-archiveGlipTeam) in API Explorer.


## Join Team

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/join`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Join().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-joinGlipTeam) in API Explorer.


## Leave Team

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/leave`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Leave().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-leaveGlipTeam) in API Explorer.


## Remove Team Members

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/remove`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().Post(glipPostMembersIdsListBody);
}
```

- Parameter `glipPostMembersIdsListBody` is of type [GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/GlipPostMembersIdsListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembers) in API Explorer.


## Unarchive Team

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/unarchive`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Unarchive().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-unarchiveGlipTeam) in API Explorer.


## Get Webhooks

HTTP GET `/restapi/v1.0/glip/webhooks`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().List();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipWebhooks) in API Explorer.


## Get Webhook

HTTP GET `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Get();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-readGlipWebhook) in API Explorer.


## Delete Webhook

HTTP DELETE `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-deleteGlipWebhook) in API Explorer.


## Activate Webhook

HTTP POST `/restapi/v1.0/glip/webhooks/{webhookId}/activate`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Activate().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-activateGlipWebhook) in API Explorer.


## Suspend Webhook

HTTP POST `/restapi/v1.0/glip/webhooks/{webhookId}/suspend`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Suspend().Post();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-suspendGlipWebhook) in API Explorer.


## Parse Phone Number

HTTP POST `/restapi/v1.0/number-parser/parse`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
}
```

- Parameter `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./RingCentral.Net/Definitions/ParsePhoneNumberRequest.cs)
- Parameter `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- `result` is of type [ParsePhoneNumberResponse](./RingCentral.Net/Definitions/ParsePhoneNumberResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-parsePhoneNumber) in API Explorer.


## Get Service Status

HTTP GET `/restapi/v1.0/status`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Status().Get();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIStatus) in API Explorer.


## Get Subscriptions

HTTP GET `/restapi/v1.0/subscription`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().List();
}
```


- `result` is of type [RecordsCollectionResourceSubscriptionResponse](./RingCentral.Net/Definitions/RecordsCollectionResourceSubscriptionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-listSubscriptions) in API Explorer.


## Create Subscription

HTTP POST `/restapi/v1.0/subscription`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().Post(createSubscriptionRequest);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

HTTP GET `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Get();
}
```


- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-readSubscription) in API Explorer.


## Renew Subscription / Update Event Filters

HTTP PUT `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Put(modifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

HTTP DELETE `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Delete();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.


## Renew Subscription

HTTP POST `/restapi/v1.0/subscription/{subscriptionId}/renew`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().Post();
}
```


- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-renewSubscription) in API Explorer.


## Get Service Provider Config

HTTP GET `/scim/v2/ServiceProviderConfig`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).ServiceProviderConfig().Get();
}
```


- `result` is of type [ServiceProviderConfig](./RingCentral.Net/Definitions/ServiceProviderConfig.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readServiceProviderConfig2) in API Explorer.


## Search/List Users

HTTP GET `/scim/v2/Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().List(searchViaGet2Parameters);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaGet2) in API Explorer.


## Create User

HTTP POST `/scim/v2/Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().Post(createUser);
}
```

- Parameter `createUser` is of type [CreateUser](./RingCentral.Net/Definitions/CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Search/List Users

HTTP POST `/scim/v2/Users/.search`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DotSearch().Post(searchRequest);
}
```

- Parameter `searchRequest` is of type [SearchRequest](./RingCentral.Net/Definitions/SearchRequest.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaPost2) in API Explorer.


## Get User

HTTP GET `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Get();
}
```


- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readUser2) in API Explorer.


## Update/Replace User

HTTP PUT `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Put(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

HTTP DELETE `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Delete();
}
```


- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-deleteUser2) in API Explorer.


## Update/Patch User

HTTP PATCH `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Patch(userPatch);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Check Health

HTTP GET `/scim/v2/health`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Health().Get();
}
```


- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-checkHealth2) in API Explorer.