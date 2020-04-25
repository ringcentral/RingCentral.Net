# RingCentral.Net SDK Code Samples


## Get API Versions

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().GET();
}
```


- `result` is of type [GetVersionsResponse](./RingCentral.Net/Definitions/GetVersionsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersions) in API Explorer.


## Get Version Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/{apiVersion}`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().GET();
}
```


- `result` is of type [GetVersionResponse](./RingCentral.Net/Definitions/GetVersionResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.


## Revoke Token

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/oauth/revoke`</td></tr><tr><td>Rate Limit Group</td><td>`Auth`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Revoke().POST(revokeTokenRequest);
}
```

- Parameter `revokeTokenRequest` is of type [RevokeTokenRequest](./RingCentral.Net/Definitions/RevokeTokenRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-revokeToken) in API Explorer.


## Get Token

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/oauth/token`</td></tr><tr><td>Rate Limit Group</td><td>`Auth`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Token().POST(getTokenRequest);
}
```

- Parameter `getTokenRequest` is of type [GetTokenRequest](./RingCentral.Net/Definitions/GetTokenRequest.cs)
- `result` is of type [TokenInfo](./RingCentral.Net/Definitions/TokenInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-getToken) in API Explorer.


## Get API Versions

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).GET();
}
```


- `result` is of type [GetVersionsResponse](./RingCentral.Net/Definitions/GetVersionsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersions) in API Explorer.


## Get Version Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/{apiVersion}`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).GET();
}
```


- `result` is of type [GetVersionResponse](./RingCentral.Net/Definitions/GetVersionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.


## Get Account Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).GET();
}
```


- `result` is of type [GetAccountInfoResponse](./RingCentral.Net/Definitions/GetAccountInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountInfo) in API Explorer.


## Get Company Active Calls

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/active-calls`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().GET(listCompanyActiveCallsParameters);
}
```

- Parameter `listCompanyActiveCallsParameters` is of type [ListCompanyActiveCallsParameters](./RingCentral.Net/Definitions/ListCompanyActiveCallsParameters.cs)
- `result` is of type [CompanyActiveCallsResponse](./RingCentral.Net/Definitions/CompanyActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listCompanyActiveCalls) in API Explorer.


## Create Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().POST(ringCentralCompanyAnsweringRuleRequest);
}
```

- Parameter `ringCentralCompanyAnsweringRuleRequest` is of type [RingCentral.CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().GET(listCompanyAnsweringRulesParameters);
}
```

- Parameter `listCompanyAnsweringRulesParameters` is of type [ListCompanyAnsweringRulesParameters](./RingCentral.Net/Definitions/ListCompanyAnsweringRulesParameters.cs)
- `result` is of type [CompanyAnsweringRuleList](./RingCentral.Net/Definitions/CompanyAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCompanyAnsweringRules) in API Explorer.


## Get Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().GET();
}
```


- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCompanyAnsweringRule) in API Explorer.


## Update Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().PUT(ringCentralCompanyAnsweringRuleUpdate);
}
```

- Parameter `ringCentralCompanyAnsweringRuleUpdate` is of type [RingCentral.CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/RingCentral.CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCompanyAnsweringRule) in API Explorer.


## Create Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).POST(ringCentralCompanyAnsweringRuleRequest);
}
```

- Parameter `ringCentralCompanyAnsweringRuleRequest` is of type [RingCentral.CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).GET(listCompanyAnsweringRulesParameters);
}
```

- Parameter `listCompanyAnsweringRulesParameters` is of type [ListCompanyAnsweringRulesParameters](./RingCentral.Net/Definitions/ListCompanyAnsweringRulesParameters.cs)
- `result` is of type [CompanyAnsweringRuleList](./RingCentral.Net/Definitions/CompanyAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCompanyAnsweringRules) in API Explorer.


## Get Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).GET();
}
```


- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCompanyAnsweringRule) in API Explorer.


## Update Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).PUT(ringCentralCompanyAnsweringRuleUpdate);
}
```

- Parameter `ringCentralCompanyAnsweringRuleUpdate` is of type [RingCentral.CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/RingCentral.CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCompanyAnsweringRule) in API Explorer.


## Get Account Business Address

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/business-address`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().GET();
}
```


- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountBusinessAddress) in API Explorer.


## Update Company Business Address

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/business-address`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().PUT(ringCentralModifyAccountBusinessAddressRequest);
}
```

- Parameter `ringCentralModifyAccountBusinessAddressRequest` is of type [RingCentral.ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/RingCentral.ModifyAccountBusinessAddressRequest.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.


## Get Company Business Hours

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/business-hours`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().GET();
}
```


- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readCompanyBusinessHours) in API Explorer.


## Update Company Business Hours

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/business-hours`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().PUT(ringCentralCompanyBusinessHoursUpdateRequest);
}
```

- Parameter `ringCentralCompanyBusinessHoursUpdateRequest` is of type [RingCentral.CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/RingCentral.CompanyBusinessHoursUpdateRequest.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateCompanyBusinessHours) in API Explorer.


## Get Company Call Log Records

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`FullCompanyCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().GET(readCompanyCallLogParameters);
}
```

- Parameter `readCompanyCallLogParameters` is of type [ReadCompanyCallLogParameters](./RingCentral.Net/Definitions/ReadCompanyCallLogParameters.cs)
- `result` is of type [AccountCallLogResponse](./RingCentral.Net/Definitions/AccountCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.


## Get Company Call Log Record(s)

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`FullCompanyCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().GET(readCompanyCallRecordParameters);
}
```

- Parameter `readCompanyCallRecordParameters` is of type [ReadCompanyCallRecordParameters](./RingCentral.Net/Definitions/ReadCompanyCallRecordParameters.cs)
- `result` is of type [CompanyCallLogRecord](./RingCentral.Net/Definitions/CompanyCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.


## Sync Company Call Log

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-log-sync`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLogSync().GET(syncAccountCallLogParameters);
}
```

- Parameter `syncAccountCallLogParameters` is of type [SyncAccountCallLogParameters](./RingCentral.Net/Definitions/SyncAccountCallLogParameters.cs)
- `result` is of type [AccountCallLogSyncResponse](./RingCentral.Net/Definitions/AccountCallLogSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncAccountCallLog) in API Explorer.


## Get Company Call Log Records

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`FullCompanyCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).GET(readCompanyCallLogParameters);
}
```

- Parameter `readCompanyCallLogParameters` is of type [ReadCompanyCallLogParameters](./RingCentral.Net/Definitions/ReadCompanyCallLogParameters.cs)
- `result` is of type [AccountCallLogResponse](./RingCentral.Net/Definitions/AccountCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.


## Get Company Call Log Record(s)

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`FullCompanyCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).GET(readCompanyCallRecordParameters);
}
```

- Parameter `readCompanyCallRecordParameters` is of type [ReadCompanyCallRecordParameters](./RingCentral.Net/Definitions/ReadCompanyCallRecordParameters.cs)
- `result` is of type [CompanyCallLogRecord](./RingCentral.Net/Definitions/CompanyCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.


## Create Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().POST(ringCentralCreateCallMonitoringGroupRequest);
}
```

- Parameter `ringCentralCreateCallMonitoringGroupRequest` is of type [RingCentral.CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/RingCentral.CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().GET(listCallMonitoringGroupsParameters);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- `result` is of type [CallMonitoringGroups](./RingCentral.Net/Definitions/CallMonitoringGroups.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API Explorer.


## Updates Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().PUT(ringCentralCreateCallMonitoringGroupRequest);
}
```

- Parameter `ringCentralCreateCallMonitoringGroupRequest` is of type [RingCentral.CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/RingCentral.CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API Explorer.


## Create Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).POST(ringCentralCreateCallMonitoringGroupRequest);
}
```

- Parameter `ringCentralCreateCallMonitoringGroupRequest` is of type [RingCentral.CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/RingCentral.CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).GET(listCallMonitoringGroupsParameters);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- `result` is of type [CallMonitoringGroups](./RingCentral.Net/Definitions/CallMonitoringGroups.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API Explorer.


## Updates Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).PUT(ringCentralCreateCallMonitoringGroupRequest);
}
```

- Parameter `ringCentralCreateCallMonitoringGroupRequest` is of type [RingCentral.CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/RingCentral.CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API Explorer.


## Update Call Monitoring Group List

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().POST(ringCentralCallMonitoringBulkAssign);
}
```

- Parameter `ringCentralCallMonitoringBulkAssign` is of type [RingCentral.CallMonitoringBulkAssign](./RingCentral.Net/Definitions/RingCentral.CallMonitoringBulkAssign.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in API Explorer.


## Get Call Monitoring Group Member List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().GET(listCallMonitoringGroupMembersParameters);
}
```

- Parameter `listCallMonitoringGroupMembersParameters` is of type [ListCallMonitoringGroupMembersParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupMembersParameters.cs)
- `result` is of type [CallMonitoringGroupMemberList](./RingCentral.Net/Definitions/CallMonitoringGroupMemberList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroupMembers) in API Explorer.


## Get Call Queue List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-queues`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().GET(listCallQueuesParameters);
}
```

- Parameter `listCallQueuesParameters` is of type [ListCallQueuesParameters](./RingCentral.Net/Definitions/ListCallQueuesParameters.cs)
- `result` is of type [CallQueues](./RingCentral.Net/Definitions/CallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueues) in API Explorer.


## Assign Multiple Call Queue Members

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().POST(ringCentralCallQueueBulkAssignResource);
}
```

- Parameter `ringCentralCallQueueBulkAssignResource` is of type [RingCentral.CallQueueBulkAssignResource](./RingCentral.Net/Definitions/RingCentral.CallQueueBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API Explorer.


## Get Call Queue Members

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().GET(listCallQueueMembersParameters);
}
```

- Parameter `listCallQueueMembersParameters` is of type [ListCallQueueMembersParameters](./RingCentral.Net/Definitions/ListCallQueueMembersParameters.cs)
- `result` is of type [CallQueueMembers](./RingCentral.Net/Definitions/CallQueueMembers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueueMembers) in API Explorer.


## Get Call Recording Settings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().GET();
}
```


- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCallRecordingSettings) in API Explorer.


## Update Call Recording Settings

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().PUT(ringCentralCallRecordingSettingsResource);
}
```

- Parameter `ringCentralCallRecordingSettingsResource` is of type [RingCentral.CallRecordingSettingsResource](./RingCentral.Net/Definitions/RingCentral.CallRecordingSettingsResource.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingSettings) in API Explorer.


## Update Call Recording Extension List

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().POST(ringCentralBulkAccountCallRecordingsResource);
}
```

- Parameter `ringCentralBulkAccountCallRecordingsResource` is of type [RingCentral.BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/RingCentral.BulkAccountCallRecordingsResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingExtensionList) in API Explorer.


## Get Call Recording Custom Greeting List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().GET(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- `result` is of type [CallRecordingCustomGreetings](./RingCentral.Net/Definitions/CallRecordingCustomGreetings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCallRecordingCustomGreetings) in API Explorer.


## Delete Call Recording Custom Greeting

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCallRecordingCustomGreeting) in API Explorer.


## Get Call Recording Custom Greeting List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).GET(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- `result` is of type [CallRecordingCustomGreetings](./RingCentral.Net/Definitions/CallRecordingCustomGreetings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCallRecordingCustomGreetings) in API Explorer.


## Delete Call Recording Custom Greeting

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteCallRecordingCustomGreeting) in API Explorer.


## Get Call Recording Extension List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/call-recording/extensions`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().GET();
}
```


- `result` is of type [CallRecordingExtensions](./RingCentral.Net/Definitions/CallRecordingExtensions.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listCallRecordingExtensions) in API Explorer.


## Create Custom Field

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().POST(ringCentralCustomFieldCreateRequest);
}
```

- Parameter `ringCentralCustomFieldCreateRequest` is of type [RingCentral.CustomFieldCreateRequest](./RingCentral.Net/Definitions/RingCentral.CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.


## Get Custom Field List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().GET();
}
```


- `result` is of type [CustomFieldsResource](./RingCentral.Net/Definitions/CustomFieldsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-listCustomFields) in API Explorer.


## Update Сustom Field

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().PUT(ringCentralCustomFieldUpdateRequest);
}
```

- Parameter `ringCentralCustomFieldUpdateRequest` is of type [RingCentral.CustomFieldUpdateRequest](./RingCentral.Net/Definitions/RingCentral.CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.


## Delete Custom Field

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-deleteCustomField) in API Explorer.


## Create Custom Field

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).POST(ringCentralCustomFieldCreateRequest);
}
```

- Parameter `ringCentralCustomFieldCreateRequest` is of type [RingCentral.CustomFieldCreateRequest](./RingCentral.Net/Definitions/RingCentral.CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.


## Get Custom Field List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).GET();
}
```


- `result` is of type [CustomFieldsResource](./RingCentral.Net/Definitions/CustomFieldsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-listCustomFields) in API Explorer.


## Update Сustom Field

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).PUT(ringCentralCustomFieldUpdateRequest);
}
```

- Parameter `ringCentralCustomFieldUpdateRequest` is of type [RingCentral.CustomFieldUpdateRequest](./RingCentral.Net/Definitions/RingCentral.CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.


## Delete Custom Field

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-deleteCustomField) in API Explorer.


## Assign Multiple Department Members

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/department/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`UserGroups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Department().BulkAssign().POST(ringCentralDepartmentBulkAssignResource);
}
```

- Parameter `ringCentralDepartmentBulkAssignResource` is of type [RingCentral.DepartmentBulkAssignResource](./RingCentral.Net/Definitions/RingCentral.DepartmentBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleDepartmentMembers) in API Explorer.


## Get Department Member List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/department/{departmentId}/members`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Department(departmentId).Members().GET(listDepartmentMembersParameters);
}
```

- Parameter `listDepartmentMembersParameters` is of type [ListDepartmentMembersParameters](./RingCentral.Net/Definitions/ListDepartmentMembersParameters.cs)
- `result` is of type [DepartmentMemberList](./RingCentral.Net/Definitions/DepartmentMemberList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listDepartmentMembers) in API Explorer.


## Get Device

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/device/{deviceId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyDevices`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).GET(readDeviceParameters);
}
```

- Parameter `readDeviceParameters` is of type [ReadDeviceParameters](./RingCentral.Net/Definitions/ReadDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-readDevice) in API Explorer.


## Update Device

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/device/{deviceId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyDevices`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).PUT(ringCentralAccountDeviceUpdate, updateDeviceParameters);
}
```

- Parameter `ringCentralAccountDeviceUpdate` is of type [RingCentral.AccountDeviceUpdate](./RingCentral.Net/Definitions/RingCentral.AccountDeviceUpdate.cs)
- Parameter `updateDeviceParameters` is of type [UpdateDeviceParameters](./RingCentral.Net/Definitions/UpdateDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.


## Get Company Directory Entries

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/entries`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().GET(listDirectoryEntriesParameters);
}
```

- Parameter `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-listDirectoryEntries) in API Explorer.


## Get Corporate Directory Entry

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/entries/{entryId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().GET();
}
```


- `result` is of type [ContactResource](./RingCentral.Net/Definitions/ContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.


## Search Company Directory Entries

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/entries/search`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().POST(ringCentralSearchDirectoryEntriesRequest);
}
```

- Parameter `ringCentralSearchDirectoryEntriesRequest` is of type [RingCentral.SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/RingCentral.SearchDirectoryEntriesRequest.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.


## Get Company Directory Entries

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/entries`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).GET(listDirectoryEntriesParameters);
}
```

- Parameter `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-listDirectoryEntries) in API Explorer.


## Get Corporate Directory Entry

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/entries/{entryId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).GET();
}
```


- `result` is of type [ContactResource](./RingCentral.Net/Definitions/ContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.


## Get Account Federation

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/directory/federation`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().GET();
}
```


- `result` is of type [FederationResource](./RingCentral.Net/Definitions/FederationResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readAccountFederation) in API Explorer.


## Get Device List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().GET(listDevicesAutomaticLocationUpdatesParameters);
}
```

- Parameter `listDevicesAutomaticLocationUpdatesParameters` is of type [ListDevicesAutomaticLocationUpdatesParameters](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdatesParameters.cs)
- `result` is of type [ListDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listDevicesAutomaticLocationUpdates) in API Explorer.


## Enable Automatic Location Updates for Devices

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().POST(ringCentralAssignMultipleDevicesAutomaticLocationUpdates);
}
```

- Parameter `ringCentralAssignMultipleDevicesAutomaticLocationUpdates` is of type [RingCentral.AssignMultipleDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/RingCentral.AssignMultipleDevicesAutomaticLocationUpdates.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.


## Get Network Map

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().GET();
}
```


- `result` is of type [NetworksList](./RingCentral.Net/Definitions/NetworksList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listNetworks) in API Explorer.


## Create Network

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().POST(ringCentralCreateNetworkRequest);
}
```

- Parameter `ringCentralCreateNetworkRequest` is of type [RingCentral.CreateNetworkRequest](./RingCentral.Net/Definitions/RingCentral.CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().GET();
}
```


- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readNetwork) in API Explorer.


## Update Network

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().PUT(ringCentralUpdateNetworkRequest);
}
```

- Parameter `ringCentralUpdateNetworkRequest` is of type [RingCentral.UpdateNetworkRequest](./RingCentral.Net/Definitions/RingCentral.UpdateNetworkRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.


## Get Network Map

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).GET();
}
```


- `result` is of type [NetworksList](./RingCentral.Net/Definitions/NetworksList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listNetworks) in API Explorer.


## Create Network

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).POST(ringCentralCreateNetworkRequest);
}
```

- Parameter `ringCentralCreateNetworkRequest` is of type [RingCentral.CreateNetworkRequest](./RingCentral.Net/Definitions/RingCentral.CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).GET();
}
```


- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readNetwork) in API Explorer.


## Update Network

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).PUT(ringCentralUpdateNetworkRequest);
}
```

- Parameter `ringCentralUpdateNetworkRequest` is of type [RingCentral.UpdateNetworkRequest](./RingCentral.Net/Definitions/RingCentral.UpdateNetworkRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.


## Get Account Switch List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().GET(listAccountSwitchesParameters);
}
```

- Parameter `listAccountSwitchesParameters` is of type [ListAccountSwitchesParameters](./RingCentral.Net/Definitions/ListAccountSwitchesParameters.cs)
- `result` is of type [SwitchesList](./RingCentral.Net/Definitions/SwitchesList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API Explorer.


## Create Switch

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().POST(ringCentralCreateSwitchInfo);
}
```

- Parameter `ringCentralCreateSwitchInfo` is of type [RingCentral.CreateSwitchInfo](./RingCentral.Net/Definitions/RingCentral.CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Get Switch

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().GET();
}
```


- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readSwitch) in API Explorer.


## Update Switch

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().PUT(ringCentralUpdateSwitchInfo);
}
```

- Parameter `ringCentralUpdateSwitchInfo` is of type [RingCentral.UpdateSwitchInfo](./RingCentral.Net/Definitions/RingCentral.UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteSwitch) in API Explorer.


## Create Multiple Switches

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().POST(ringCentralCreateMultipleSwitchesRequest);
}
```

- Parameter `ringCentralCreateMultipleSwitchesRequest` is of type [RingCentral.CreateMultipleSwitchesRequest](./RingCentral.Net/Definitions/RingCentral.CreateMultipleSwitchesRequest.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./RingCentral.Net/Definitions/CreateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API Explorer.


## Update Multiple Switches

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().POST(ringCentralUpdateMultipleSwitchesRequest);
}
```

- Parameter `ringCentralUpdateMultipleSwitchesRequest` is of type [RingCentral.UpdateMultipleSwitchesRequest](./RingCentral.Net/Definitions/RingCentral.UpdateMultipleSwitchesRequest.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./RingCentral.Net/Definitions/UpdateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API Explorer.


## Validate Multiple Switches

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().POST(ringCentralValidateMultipleSwitchesRequest);
}
```

- Parameter `ringCentralValidateMultipleSwitchesRequest` is of type [RingCentral.ValidateMultipleSwitchesRequest](./RingCentral.Net/Definitions/RingCentral.ValidateMultipleSwitchesRequest.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./RingCentral.Net/Definitions/ValidateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API Explorer.


## Get Account Switch List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).GET(listAccountSwitchesParameters);
}
```

- Parameter `listAccountSwitchesParameters` is of type [ListAccountSwitchesParameters](./RingCentral.Net/Definitions/ListAccountSwitchesParameters.cs)
- `result` is of type [SwitchesList](./RingCentral.Net/Definitions/SwitchesList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API Explorer.


## Create Switch

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).POST(ringCentralCreateSwitchInfo);
}
```

- Parameter `ringCentralCreateSwitchInfo` is of type [RingCentral.CreateSwitchInfo](./RingCentral.Net/Definitions/RingCentral.CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Get Switch

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).GET();
}
```


- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readSwitch) in API Explorer.


## Update Switch

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).PUT(ringCentralUpdateSwitchInfo);
}
```

- Parameter `ringCentralUpdateSwitchInfo` is of type [RingCentral.UpdateSwitchInfo](./RingCentral.Net/Definitions/RingCentral.UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteSwitch) in API Explorer.


## Get Emergency Map Configuration Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).GET();
}
```


- `result` is of type [AutomaticLocationUpdatesTaskInfo](./RingCentral.Net/Definitions/AutomaticLocationUpdatesTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readAutomaticLocationUpdatesTask) in API Explorer.


## Get User List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().GET(listAutomaticLocationUpdatesUsersParameters);
}
```

- Parameter `listAutomaticLocationUpdatesUsersParameters` is of type [ListAutomaticLocationUpdatesUsersParameters](./RingCentral.Net/Definitions/ListAutomaticLocationUpdatesUsersParameters.cs)
- `result` is of type [AutomaticLocationUpdatesUserList](./RingCentral.Net/Definitions/AutomaticLocationUpdatesUserList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAutomaticLocationUpdatesUsers) in API Explorer.


## Enable Automatic Location Updates for Users

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().POST(ringCentralBulkAssignAutomaticaLocationUpdatesUsers);
}
```

- Parameter `ringCentralBulkAssignAutomaticaLocationUpdatesUsers` is of type [RingCentral.BulkAssignAutomaticaLocationUpdatesUsers](./RingCentral.Net/Definitions/RingCentral.BulkAssignAutomaticaLocationUpdatesUsers.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.


## Get Wireless Point List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().GET(listWirelessPointsParameters);
}
```

- Parameter `listWirelessPointsParameters` is of type [ListWirelessPointsParameters](./RingCentral.Net/Definitions/ListWirelessPointsParameters.cs)
- `result` is of type [WirelessPointsList](./RingCentral.Net/Definitions/WirelessPointsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API Explorer.


## Create Wireless Point

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().POST(ringCentralCreateWirelessPoint);
}
```

- Parameter `ringCentralCreateWirelessPoint` is of type [RingCentral.CreateWirelessPoint](./RingCentral.Net/Definitions/RingCentral.CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Get Wireless Point

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().GET();
}
```


- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API Explorer.


## Update Wireless Point

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().PUT(ringCentralUpdateWirelessPoint);
}
```

- Parameter `ringCentralUpdateWirelessPoint` is of type [RingCentral.UpdateWirelessPoint](./RingCentral.Net/Definitions/RingCentral.UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API Explorer.


## Create Multiple Wireless Points

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().POST(ringCentralCreateMultipleWirelessPointsRequest);
}
```

- Parameter `ringCentralCreateMultipleWirelessPointsRequest` is of type [RingCentral.CreateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/RingCentral.CreateMultipleWirelessPointsRequest.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in API Explorer.


## Update Multiple Wireless Points

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().POST(ringCentralUpdateMultipleWirelessPointsRequest);
}
```

- Parameter `ringCentralUpdateMultipleWirelessPointsRequest` is of type [RingCentral.UpdateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/RingCentral.UpdateMultipleWirelessPointsRequest.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in API Explorer.


## Validate Multiple Wireless Points

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().POST(ringCentralValidateMultipleWirelessPointsRequest);
}
```

- Parameter `ringCentralValidateMultipleWirelessPointsRequest` is of type [RingCentral.ValidateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/RingCentral.ValidateMultipleWirelessPointsRequest.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints) in API Explorer.


## Get Wireless Point List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).GET(listWirelessPointsParameters);
}
```

- Parameter `listWirelessPointsParameters` is of type [ListWirelessPointsParameters](./RingCentral.Net/Definitions/ListWirelessPointsParameters.cs)
- `result` is of type [WirelessPointsList](./RingCentral.Net/Definitions/WirelessPointsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API Explorer.


## Create Wireless Point

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).POST(ringCentralCreateWirelessPoint);
}
```

- Parameter `ringCentralCreateWirelessPoint` is of type [RingCentral.CreateWirelessPoint](./RingCentral.Net/Definitions/RingCentral.CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Get Wireless Point

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).GET();
}
```


- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API Explorer.


## Update Wireless Point

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).PUT(ringCentralUpdateWirelessPoint);
}
```

- Parameter `ringCentralUpdateWirelessPoint` is of type [RingCentral.UpdateWirelessPoint](./RingCentral.Net/Definitions/RingCentral.UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API Explorer.


## Add Emergency Location

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().POST(ringCentralEmergencyLocationInfoRequest);
}
```

- Parameter `ringCentralEmergencyLocationInfoRequest` is of type [RingCentral.EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/RingCentral.EmergencyLocationInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().GET(listEmergencyLocationsParameters);
}
```

- Parameter `listEmergencyLocationsParameters` is of type [ListEmergencyLocationsParameters](./RingCentral.Net/Definitions/ListEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationList](./RingCentral.Net/Definitions/EmergencyLocationList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API Explorer.


## Get Emergency Location

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().GET();
}
```


- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API Explorer.


## Update Emergency Location

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().PUT(ringCentralEmergencyLocationInfoRequest);
}
```

- Parameter `ringCentralEmergencyLocationInfoRequest` is of type [RingCentral.EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/RingCentral.EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Add Emergency Location

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).POST(ringCentralEmergencyLocationInfoRequest);
}
```

- Parameter `ringCentralEmergencyLocationInfoRequest` is of type [RingCentral.EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/RingCentral.EmergencyLocationInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).GET(listEmergencyLocationsParameters);
}
```

- Parameter `listEmergencyLocationsParameters` is of type [ListEmergencyLocationsParameters](./RingCentral.Net/Definitions/ListEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationList](./RingCentral.Net/Definitions/EmergencyLocationList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API Explorer.


## Get Emergency Location

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).GET();
}
```


- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API Explorer.


## Update Emergency Location

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ConfigureEmergencyMaps`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).PUT(ringCentralEmergencyLocationInfoRequest);
}
```

- Parameter `ringCentralEmergencyLocationInfoRequest` is of type [RingCentral.EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/RingCentral.EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Get Extension List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().GET(listExtensionsParameters);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- `result` is of type [GetExtensionListResponse](./RingCentral.Net/Definitions/GetExtensionListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listExtensions) in API Explorer.


## Create Extension

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AddRemoveUsers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().POST(ringCentralExtensionCreationRequest);
}
```

- Parameter `ringCentralExtensionCreationRequest` is of type [RingCentral.ExtensionCreationRequest](./RingCentral.Net/Definitions/RingCentral.ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().GET();
}
```


- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtension) in API Explorer.


## Update Extension

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo OR EditUserCredentials`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().PUT(ringCentralExtensionUpdateRequest);
}
```

- Parameter `ringCentralExtensionUpdateRequest` is of type [RingCentral.ExtensionUpdateRequest](./RingCentral.Net/Definitions/RingCentral.ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AddRemoveUsers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().DELETE(deleteExtensionParameters);
}
```

- Parameter `deleteExtensionParameters` is of type [DeleteExtensionParameters](./RingCentral.Net/Definitions/DeleteExtensionParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteExtension) in API Explorer.


## Get Extension List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).GET(listExtensionsParameters);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- `result` is of type [GetExtensionListResponse](./RingCentral.Net/Definitions/GetExtensionListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listExtensions) in API Explorer.


## Create Extension

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AddRemoveUsers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).POST(ringCentralExtensionCreationRequest);
}
```

- Parameter `ringCentralExtensionCreationRequest` is of type [RingCentral.ExtensionCreationRequest](./RingCentral.Net/Definitions/RingCentral.ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).GET();
}
```


- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtension) in API Explorer.


## Update Extension

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo OR EditUserCredentials`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PUT(ringCentralExtensionUpdateRequest);
}
```

- Parameter `ringCentralExtensionUpdateRequest` is of type [RingCentral.ExtensionUpdateRequest](./RingCentral.Net/Definitions/RingCentral.ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AddRemoveUsers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).DELETE(deleteExtensionParameters);
}
```

- Parameter `deleteExtensionParameters` is of type [DeleteExtensionParameters](./RingCentral.Net/Definitions/DeleteExtensionParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteExtension) in API Explorer.


## Get User Active Calls

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().GET(listExtensionActiveCallsParameters);
}
```

- Parameter `listExtensionActiveCallsParameters` is of type [ListExtensionActiveCallsParameters](./RingCentral.Net/Definitions/ListExtensionActiveCallsParameters.cs)
- `result` is of type [UserActiveCallsResponse](./RingCentral.Net/Definitions/UserActiveCallsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listExtensionActiveCalls) in API Explorer.


## Address Book Synchronization

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().GET(syncAddressBookParameters);
}
```

- Parameter `syncAddressBookParameters` is of type [SyncAddressBookParameters](./RingCentral.Net/Definitions/SyncAddressBookParameters.cs)
- `result` is of type [AddressBookSync](./RingCentral.Net/Definitions/AddressBookSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-syncAddressBook) in API Explorer.


## Get Contact List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().GET(listContactsParameters);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- `result` is of type [ContactList](./RingCentral.Net/Definitions/ContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.


## Create Contact

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().POST(ringCentralPersonalContactRequest, createContactParameters);
}
```

- Parameter `ringCentralPersonalContactRequest` is of type [RingCentral.PersonalContactRequest](./RingCentral.Net/Definitions/RingCentral.PersonalContactRequest.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.


## Get Contact

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().GET();
}
```


- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.


## Update Contact

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().PUT(ringCentralPersonalContactRequest, updateContactParameters);
}
```

- Parameter `ringCentralPersonalContactRequest` is of type [RingCentral.PersonalContactRequest](./RingCentral.Net/Definitions/RingCentral.PersonalContactRequest.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.


## Delete Contact

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.


## Get Contact List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).GET(listContactsParameters);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- `result` is of type [ContactList](./RingCentral.Net/Definitions/ContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.


## Create Contact

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).POST(ringCentralPersonalContactRequest, createContactParameters);
}
```

- Parameter `ringCentralPersonalContactRequest` is of type [RingCentral.PersonalContactRequest](./RingCentral.Net/Definitions/RingCentral.PersonalContactRequest.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.


## Get Contact

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).GET();
}
```


- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.


## Update Contact

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).PUT(ringCentralPersonalContactRequest, updateContactParameters);
}
```

- Parameter `ringCentralPersonalContactRequest` is of type [RingCentral.PersonalContactRequest](./RingCentral.Net/Definitions/RingCentral.PersonalContactRequest.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.


## Delete Contact

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.


## Get Call Handling Rules

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().GET(listAnsweringRulesParameters);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- `result` is of type [UserAnsweringRuleList](./RingCentral.Net/Definitions/UserAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listAnsweringRules) in API Explorer.


## Create Call Handling Rule

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().POST(ringCentralCreateAnsweringRuleRequest);
}
```

- Parameter `ringCentralCreateAnsweringRuleRequest` is of type [RingCentral.CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().GET(readAnsweringRuleParameters);
}
```

- Parameter `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./RingCentral.Net/Definitions/ReadAnsweringRuleParameters.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readAnsweringRule) in API Explorer.


## Update Call Handling Rule

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().PUT(ringCentralUpdateAnsweringRuleRequest);
}
```

- Parameter `ringCentralUpdateAnsweringRuleRequest` is of type [RingCentral.UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteAnsweringRule) in API Explorer.


## Get Call Handling Rules

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).GET(listAnsweringRulesParameters);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- `result` is of type [UserAnsweringRuleList](./RingCentral.Net/Definitions/UserAnsweringRuleList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listAnsweringRules) in API Explorer.


## Create Call Handling Rule

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).POST(ringCentralCreateAnsweringRuleRequest);
}
```

- Parameter `ringCentralCreateAnsweringRuleRequest` is of type [RingCentral.CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).GET(readAnsweringRuleParameters);
}
```

- Parameter `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./RingCentral.Net/Definitions/ReadAnsweringRuleParameters.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readAnsweringRule) in API Explorer.


## Update Call Handling Rule

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).PUT(ringCentralUpdateAnsweringRuleRequest);
}
```

- Parameter `ringCentralUpdateAnsweringRuleRequest` is of type [RingCentral.UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/RingCentral.UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-deleteAnsweringRule) in API Explorer.


## Get Authorization Profile

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().GET();
}
```


- `result` is of type [AuthProfileResource](./RingCentral.Net/Definitions/AuthProfileResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readAuthorizationProfile) in API Explorer.


## Check User Permission

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().GET(checkUserPermissionParameters);
}
```

- Parameter `checkUserPermissionParameters` is of type [CheckUserPermissionParameters](./RingCentral.Net/Definitions/CheckUserPermissionParameters.cs)
- `result` is of type [AuthProfileCheckResource](./RingCentral.Net/Definitions/AuthProfileCheckResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-checkUserPermission) in API Explorer.


## Get User Business Hours

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().GET();
}
```


- `result` is of type [GetUserBusinessHoursResponse](./RingCentral.Net/Definitions/GetUserBusinessHoursResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readUserBusinessHours) in API Explorer.


## Update User Business Hours

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().PUT(ringCentralUserBusinessHoursUpdateRequest);
}
```

- Parameter `ringCentralUserBusinessHoursUpdateRequest` is of type [RingCentral.UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/RingCentral.UserBusinessHoursUpdateRequest.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./RingCentral.Net/Definitions/UserBusinessHoursUpdateResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.


## Get User Call Log Records

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().GET(readUserCallLogParameters);
}
```

- Parameter `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./RingCentral.Net/Definitions/ReadUserCallLogParameters.cs)
- `result` is of type [UserCallLogResponse](./RingCentral.Net/Definitions/UserCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.


## Delete User Call Log

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditCallLog`</td></tr><tr><td>User Permission Required</td><td>`EditCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().DELETE(deleteUserCallLogParameters);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.


## Get User Call Record

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().GET(readUserCallRecordParameters);
}
```

- Parameter `readUserCallRecordParameters` is of type [ReadUserCallRecordParameters](./RingCentral.Net/Definitions/ReadUserCallRecordParameters.cs)
- `result` is of type [UserCallLogRecord](./RingCentral.Net/Definitions/UserCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.


## Sync User Call Log

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().GET(syncUserCallLogParameters);
}
```

- Parameter `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./RingCentral.Net/Definitions/SyncUserCallLogParameters.cs)
- `result` is of type [CallLogSync](./RingCentral.Net/Definitions/CallLogSync.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncUserCallLog) in API Explorer.


## Get User Call Log Records

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).GET(readUserCallLogParameters);
}
```

- Parameter `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./RingCentral.Net/Definitions/ReadUserCallLogParameters.cs)
- `result` is of type [UserCallLogResponse](./RingCentral.Net/Definitions/UserCallLogResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.


## Delete User Call Log

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditCallLog`</td></tr><tr><td>User Permission Required</td><td>`EditCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).DELETE(deleteUserCallLogParameters);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.


## Get User Call Record

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallLog`</td></tr><tr><td>User Permission Required</td><td>`ReadCallLog`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).GET(readUserCallRecordParameters);
}
```

- Parameter `readUserCallRecordParameters` is of type [ReadUserCallRecordParameters](./RingCentral.Net/Definitions/ReadUserCallRecordParameters.cs)
- `result` is of type [UserCallLogRecord](./RingCentral.Net/Definitions/UserCallLogRecord.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.


## Update User Call Queues

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Accounts`</td></tr><tr><td>User Permission Required</td><td>`JoinLeaveCallQueue`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().PUT(ringCentralUserCallQueues);
}
```

- Parameter `ringCentralUserCallQueues` is of type [RingCentral.UserCallQueues](./RingCentral.Net/Definitions/RingCentral.UserCallQueues.cs)
- `result` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.


## Get Caller Blocking Settings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().GET();
}
```


- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readCallerBlockingSettings) in API Explorer.


## Update Caller Blocking Settings

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PUT(ringCentralCallerBlockingSettingsUpdate);
}
```

- Parameter `ringCentralCallerBlockingSettingsUpdate` is of type [RingCentral.CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/RingCentral.CallerBlockingSettingsUpdate.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API Explorer.


## Get Blocked/Allowed Phone Numbers

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().GET(listBlockedAllowedNumbersParameters);
}
```

- Parameter `listBlockedAllowedNumbersParameters` is of type [ListBlockedAllowedNumbersParameters](./RingCentral.Net/Definitions/ListBlockedAllowedNumbersParameters.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumbersList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-listBlockedAllowedNumbers) in API Explorer.


## Add Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().POST(ringCentralAddBlockedAllowedPhoneNumber);
}
```

- Parameter `ringCentralAddBlockedAllowedPhoneNumber` is of type [RingCentral.AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/RingCentral.AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().GET();
}
```


- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readBlockedAllowedNumber) in API Explorer.


## Delete Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.


## Update Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().PUT(ringCentralAddBlockedAllowedPhoneNumber);
}
```

- Parameter `ringCentralAddBlockedAllowedPhoneNumber` is of type [RingCentral.AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/RingCentral.AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Phone Numbers

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).GET(listBlockedAllowedNumbersParameters);
}
```

- Parameter `listBlockedAllowedNumbersParameters` is of type [ListBlockedAllowedNumbersParameters](./RingCentral.Net/Definitions/ListBlockedAllowedNumbersParameters.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumbersList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-listBlockedAllowedNumbers) in API Explorer.


## Add Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).POST(ringCentralAddBlockedAllowedPhoneNumber);
}
```

- Parameter `ringCentralAddBlockedAllowedPhoneNumber` is of type [RingCentral.AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/RingCentral.AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).GET();
}
```


- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readBlockedAllowedNumber) in API Explorer.


## Delete Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.


## Update Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditBlockedNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).PUT(ringCentralAddBlockedAllowedPhoneNumber);
}
```

- Parameter `ringCentralAddBlockedAllowedPhoneNumber` is of type [RingCentral.AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/RingCentral.AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Extension Caller ID

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCallerIDSettings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().GET();
}
```


- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtensionCallerId) in API Explorer.


## Update Extension Caller ID

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditCallerIDSettings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().PUT(ringCentralExtensionCallerIdInfo);
}
```

- Parameter `ringCentralExtensionCallerIdInfo` is of type [RingCentral.ExtensionCallerIdInfo](./RingCentral.Net/Definitions/RingCentral.ExtensionCallerIdInfo.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtensionCallerId) in API Explorer.


## Create Internal Text Message

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`InternalMessages`</td></tr><tr><td>User Permission Required</td><td>`InternalSMS`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().POST(ringCentralCreateInternalTextMessageRequest);
}
```

- Parameter `ringCentralCreateInternalTextMessageRequest` is of type [RingCentral.CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/RingCentral.CreateInternalTextMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Pager-Messages-createInternalTextMessage) in API Explorer.


## Get User Conferencing Settings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`OrganizeConference`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().GET(readConferencingSettingsParameters);
}
```

- Parameter `readConferencingSettingsParameters` is of type [ReadConferencingSettingsParameters](./RingCentral.Net/Definitions/ReadConferencingSettingsParameters.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readConferencingSettings) in API Explorer.


## Update User Conferencing Settings

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`OrganizeConference`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().PUT(ringCentralUpdateConferencingInfoRequest);
}
```

- Parameter `ringCentralUpdateConferencingInfoRequest` is of type [RingCentral.UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/RingCentral.UpdateConferencingInfoRequest.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.


## Get Extension Device List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/device`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserDevices`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().GET(listExtensionDevicesParameters);
}
```

- Parameter `listExtensionDevicesParameters` is of type [ListExtensionDevicesParameters](./RingCentral.Net/Definitions/ListExtensionDevicesParameters.cs)
- `result` is of type [GetExtensionDevicesResponse](./RingCentral.Net/Definitions/GetExtensionDevicesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-listExtensionDevices) in API Explorer.


## Get Favorite Contact List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadContacts`</td></tr><tr><td>User Permission Required</td><td>`ReadPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().GET();
}
```


- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listFavoriteContacts) in API Explorer.


## Update Favorite Contact List

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Contacts`</td></tr><tr><td>User Permission Required</td><td>`EditPersonalContacts`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().PUT(ringCentralFavoriteCollection);
}
```

- Parameter `ringCentralFavoriteCollection` is of type [RingCentral.FavoriteCollection](./RingCentral.Net/Definitions/RingCentral.FavoriteCollection.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API Explorer.


## Create Fax Message

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Faxes`</td></tr><tr><td>User Permission Required</td><td>`OutboundFaxes`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().POST(createFaxMessageRequest);
}
```

- Parameter `createFaxMessageRequest` is of type [CreateFaxMessageRequest](./RingCentral.Net/Definitions/CreateFaxMessageRequest.cs)
- `result` is of type [FaxResponse](./RingCentral.Net/Definitions/FaxResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-createFaxMessage) in API Explorer.


## Get User Features

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/features`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Features().GET(readUserFeaturesParameters);
}
```

- Parameter `readUserFeaturesParameters` is of type [ReadUserFeaturesParameters](./RingCentral.Net/Definitions/ReadUserFeaturesParameters.cs)
- `result` is of type [FeatureList](./RingCentral.Net/Definitions/FeatureList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Features-readUserFeatures) in API Explorer.


## Get Forwarding Number List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().GET(listForwardingNumbersParameters);
}
```

- Parameter `listForwardingNumbersParameters` is of type [ListForwardingNumbersParameters](./RingCentral.Net/Definitions/ListForwardingNumbersParameters.cs)
- `result` is of type [GetExtensionForwardingNumberListResponse](./RingCentral.Net/Definitions/GetExtensionForwardingNumberListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-listForwardingNumbers) in API Explorer.


## Create Forwarding Number

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().POST(ringCentralCreateForwardingNumberRequest);
}
```

- Parameter `ringCentralCreateForwardingNumberRequest` is of type [RingCentral.CreateForwardingNumberRequest](./RingCentral.Net/Definitions/RingCentral.CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().GET();
}
```


- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-readForwardingNumber) in API Explorer.


## Update Forwarding Number

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().PUT(ringCentralUpdateForwardingNumberRequest);
}
```

- Parameter `ringCentralUpdateForwardingNumberRequest` is of type [RingCentral.UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/RingCentral.UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.


## Get Forwarding Number List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).GET(listForwardingNumbersParameters);
}
```

- Parameter `listForwardingNumbersParameters` is of type [ListForwardingNumbersParameters](./RingCentral.Net/Definitions/ListForwardingNumbersParameters.cs)
- `result` is of type [GetExtensionForwardingNumberListResponse](./RingCentral.Net/Definitions/GetExtensionForwardingNumberListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-listForwardingNumbers) in API Explorer.


## Create Forwarding Number

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).POST(ringCentralCreateForwardingNumberRequest);
}
```

- Parameter `ringCentralCreateForwardingNumberRequest` is of type [RingCentral.CreateForwardingNumberRequest](./RingCentral.Net/Definitions/RingCentral.CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).GET();
}
```


- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-readForwardingNumber) in API Explorer.


## Update Forwarding Number

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).PUT(ringCentralUpdateForwardingNumberRequest);
}
```

- Parameter `ringCentralUpdateForwardingNumberRequest` is of type [RingCentral.UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/RingCentral.UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserForwardingFlipNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.


## Get Extension Grant List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().GET(listExtensionGrantsParameters);
}
```

- Parameter `listExtensionGrantsParameters` is of type [ListExtensionGrantsParameters](./RingCentral.Net/Definitions/ListExtensionGrantsParameters.cs)
- `result` is of type [GetExtensionGrantListResponse](./RingCentral.Net/Definitions/GetExtensionGrantListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-listExtensionGrants) in API Explorer.


## Create Custom User Greeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().POST(createCustomUserGreetingRequest);
}
```

- Parameter `createCustomUserGreetingRequest` is of type [CreateCustomUserGreetingRequest](./RingCentral.Net/Definitions/CreateCustomUserGreetingRequest.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCustomUserGreeting) in API Explorer.


## Get Custom Greeting

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().GET();
}
```


- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCustomGreeting) in API Explorer.


## Create Custom User Greeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserAnsweringRules`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).POST(createCustomUserGreetingRequest);
}
```

- Parameter `createCustomUserGreetingRequest` is of type [CreateCustomUserGreetingRequest](./RingCentral.Net/Definitions/CreateCustomUserGreetingRequest.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCustomUserGreeting) in API Explorer.


## Get Custom Greeting

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).GET();
}
```


- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readCustomGreeting) in API Explorer.


## Get Scheduled Meetings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().GET();
}
```


- `result` is of type [MeetingsResource](./RingCentral.Net/Definitions/MeetingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-listMeetings) in API Explorer.


## Create Meeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().POST(ringCentralMeetingRequestResource);
}
```

- Parameter `ringCentralMeetingRequestResource` is of type [RingCentral.MeetingRequestResource](./RingCentral.Net/Definitions/RingCentral.MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get Meeting Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().GET();
}
```


- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeeting) in API Explorer.


## Update Meeting

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().PUT(ringCentralMeetingRequestResource);
}
```

- Parameter `ringCentralMeetingRequestResource` is of type [RingCentral.MeetingRequestResource](./RingCentral.Net/Definitions/RingCentral.MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-deleteMeeting) in API Explorer.


## Get User Meeting Recordings List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`MeetingsRecordings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingRecordings().GET(listUserMeetingRecordingsParameters);
}
```

- Parameter `listUserMeetingRecordingsParameters` is of type [ListUserMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListUserMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listUserMeetingRecordings) in API Explorer.


## Get Meeting Service Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().GET();
}
```


- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readMeetingServiceInfo) in API Explorer.


## Update Meeting Service Info

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().PATCH(ringCentralMeetingServiceInfoRequest);
}
```

- Parameter `ringCentralMeetingServiceInfoRequest` is of type [RingCentral.MeetingServiceInfoRequest](./RingCentral.Net/Definitions/RingCentral.MeetingServiceInfoRequest.cs)
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-updateMeetingServiceInfo) in API Explorer.


## Get Scheduled Meetings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).GET();
}
```


- `result` is of type [MeetingsResource](./RingCentral.Net/Definitions/MeetingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-listMeetings) in API Explorer.


## Create Meeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).POST(ringCentralMeetingRequestResource);
}
```

- Parameter `ringCentralMeetingRequestResource` is of type [RingCentral.MeetingRequestResource](./RingCentral.Net/Definitions/RingCentral.MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get Meeting Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).GET();
}
```


- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeeting) in API Explorer.


## Update Meeting

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).PUT(ringCentralMeetingRequestResource);
}
```

- Parameter `ringCentralMeetingRequestResource` is of type [RingCentral.MeetingRequestResource](./RingCentral.Net/Definitions/RingCentral.MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-deleteMeeting) in API Explorer.


## End Meeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).End().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-endMeeting) in API Explorer.


## Get Assistants

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assistants().GET();
}
```


- `result` is of type [AssistantsResource](./RingCentral.Net/Definitions/AssistantsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistants) in API Explorer.


## Get Assisted Users

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`Meetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assisted().GET();
}
```


- `result` is of type [AssistedUsersResource](./RingCentral.Net/Definitions/AssistedUsersResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistedUsers) in API Explorer.


## Get Message List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().GET(listMessagesParameters);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- `result` is of type [GetMessageList](./RingCentral.Net/Definitions/GetMessageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-listMessages) in API Explorer.


## Get Message

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().GET();
}
```


- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.


## Update Message List

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditMessages`</td></tr><tr><td>User Permission Required</td><td>`EditMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().PUT(ringCentralUpdateMessageRequest, updateMessageParameters);
}
```

- Parameter `ringCentralUpdateMessageRequest` is of type [RingCentral.UpdateMessageRequest](./RingCentral.Net/Definitions/RingCentral.UpdateMessageRequest.cs)
- Parameter `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditMessages`</td></tr><tr><td>User Permission Required</td><td>`EditMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().DELETE(deleteMessageParameters);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.


## Get Message List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).GET(listMessagesParameters);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- `result` is of type [GetMessageList](./RingCentral.Net/Definitions/GetMessageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-listMessages) in API Explorer.


## Get Message

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).GET();
}
```


- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.


## Update Message List

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditMessages`</td></tr><tr><td>User Permission Required</td><td>`EditMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).PUT(ringCentralUpdateMessageRequest, updateMessageParameters);
}
```

- Parameter `ringCentralUpdateMessageRequest` is of type [RingCentral.UpdateMessageRequest](./RingCentral.Net/Definitions/RingCentral.UpdateMessageRequest.cs)
- Parameter `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditMessages`</td></tr><tr><td>User Permission Required</td><td>`EditMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).DELETE(deleteMessageParameters);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.


## Get Message Content

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessageContent`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).GET(readMessageContentParameters);
}
```

- Parameter `readMessageContentParameters` is of type [ReadMessageContentParameters](./RingCentral.Net/Definitions/ReadMessageContentParameters.cs)
- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageContent) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Sync Messages

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`ReadMessages`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().GET(syncMessagesParameters);
}
```

- Parameter `syncMessagesParameters` is of type [SyncMessagesParameters](./RingCentral.Net/Definitions/SyncMessagesParameters.cs)
- `result` is of type [GetMessageSyncResponse](./RingCentral.Net/Definitions/GetMessageSyncResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-syncMessages) in API Explorer.


## Create MMS Message

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/mms`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`SMS`</td></tr><tr><td>User Permission Required</td><td>`OutboundSMS`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().POST(ringCentralCreateMmsMessage);
}
```

- Parameter `ringCentralCreateMmsMessage` is of type [RingCentral.CreateMMSMessage](./RingCentral.Net/Definitions/RingCentral.CreateMMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#MMS-createMMS) in API Explorer.


## Get Notification Settings

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadMessagesNotificationsSettings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().GET();
}
```


- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readNotificationSettings) in API Explorer.


## Update Notification Settings

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditMessagesNotificationsSettings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().PUT(ringCentralNotificationSettingsUpdateRequest);
}
```

- Parameter `ringCentralNotificationSettingsUpdateRequest` is of type [RingCentral.NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/RingCentral.NotificationSettingsUpdateRequest.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateNotificationSettings) in API Explorer.


## Get Extension Phone Number List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserPhoneNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().GET(listExtensionPhoneNumbersParameters);
}
```

- Parameter `listExtensionPhoneNumbersParameters` is of type [ListExtensionPhoneNumbersParameters](./RingCentral.Net/Definitions/ListExtensionPhoneNumbersParameters.cs)
- `result` is of type [GetExtensionPhoneNumbersResponse](./RingCentral.Net/Definitions/GetExtensionPhoneNumbersResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listExtensionPhoneNumbers) in API Explorer.


## Get User Presence Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadPresence`</td></tr><tr><td>User Permission Required</td><td>`ReadPresenceStatus`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().GET(readUserPresenceStatusParameters);
}
```

- Parameter `readUserPresenceStatusParameters` is of type [ReadUserPresenceStatusParameters](./RingCentral.Net/Definitions/ReadUserPresenceStatusParameters.cs)
- `result` is of type [GetPresenceInfo](./RingCentral.Net/Definitions/GetPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUserPresenceStatus) in API Explorer.


## Update User Presence Status

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditPresence`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().PUT(ringCentralPresenceInfoResource);
}
```

- Parameter `ringCentralPresenceInfoResource` is of type [RingCentral.PresenceInfoResource](./RingCentral.Net/Definitions/RingCentral.PresenceInfoResource.cs)
- `result` is of type [PresenceInfoResponse](./RingCentral.Net/Definitions/PresenceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.


## Get User Profile Image

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Upload User Profile Image

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().POST(createUserProfileImageRequest);
}
```

- Parameter `createUserProfileImageRequest` is of type [CreateUserProfileImageRequest](./RingCentral.Net/Definitions/CreateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-createUserProfileImage) in API Explorer.


## Update User Profile Image

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().PUT(updateUserProfileImageRequest);
}
```

- Parameter `updateUserProfileImageRequest` is of type [UpdateUserProfileImageRequest](./RingCentral.Net/Definitions/UpdateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.


## Get Scaled User Profile Image

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledPofileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get User Profile Image

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Upload User Profile Image

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).POST(createUserProfileImageRequest);
}
```

- Parameter `createUserProfileImageRequest` is of type [CreateUserProfileImageRequest](./RingCentral.Net/Definitions/CreateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-createUserProfileImage) in API Explorer.


## Update User Profile Image

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditExtensions`</td></tr><tr><td>User Permission Required</td><td>`EditUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).PUT(updateUserProfileImageRequest);
}
```

- Parameter `updateUserProfileImageRequest` is of type [UpdateUserProfileImageRequest](./RingCentral.Net/Definitions/UpdateUserProfileImageRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.


## Get Scaled User Profile Image

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadExtensions`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledPofileImage) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Make RingOut Call

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().POST(ringCentralMakeRingOutRequest);
}
```

- Parameter `ringCentralMakeRingOutRequest` is of type [RingCentral.MakeRingOutRequest](./RingCentral.Net/Definitions/RingCentral.MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().GET();
}
```


- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Make RingOut Call

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).POST(ringCentralMakeRingOutRequest);
}
```

- Parameter `ringCentralMakeRingOutRequest` is of type [RingCentral.MakeRingOutRequest](./RingCentral.Net/Definitions/RingCentral.MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).GET();
}
```


- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Make RingOut Call

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().POST(ringCentralMakeRingOutRequest);
}
```

- Parameter `ringCentralMakeRingOutRequest` is of type [RingCentral.MakeRingOutRequest](./RingCentral.Net/Definitions/RingCentral.MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().GET();
}
```


- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Make RingOut Call

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).POST(ringCentralMakeRingOutRequest);
}
```

- Parameter `ringCentralMakeRingOutRequest` is of type [RingCentral.MakeRingOutRequest](./RingCentral.Net/Definitions/RingCentral.MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).GET();
}
```


- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.


## Cancel RingOut Call

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`RingOut`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.


## Send SMS

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`SMS`</td></tr><tr><td>User Permission Required</td><td>`OutboundSMS`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().POST(ringCentralCreateSmsMessage);
}
```

- Parameter `ringCentralCreateSmsMessage` is of type [RingCentral.CreateSMSMessage](./RingCentral.Net/Definitions/RingCentral.CreateSMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.


## Get Unified Presence

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadPresence`</td></tr><tr><td>User Permission Required</td><td>`ReadPresenceStatus`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().GET();
}
```


- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUnifiedPresence) in API Explorer.


## Update Unified Presence

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditPresence`</td></tr><tr><td>User Permission Required</td><td>`EditPresenceStatus`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().PATCH(ringCentralUpdateUnifiedPresence);
}
```

- Parameter `ringCentralUpdateUnifiedPresence` is of type [RingCentral.UpdateUnifiedPresence](./RingCentral.Net/Definitions/RingCentral.UpdateUnifiedPresence.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.


## Create Company Greeting

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/greeting`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().POST(createCompanyGreetingRequest);
}
```

- Parameter `createCompanyGreetingRequest` is of type [CreateCompanyGreetingRequest](./RingCentral.Net/Definitions/CreateCompanyGreetingRequest.cs)
- `result` is of type [CustomCompanyGreetingInfo](./RingCentral.Net/Definitions/CustomCompanyGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyGreeting) in API Explorer.


## Create IVR Menu

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().POST(ringCentralIvrMenuInfo);
}
```

- Parameter `ringCentralIvrMenuInfo` is of type [RingCentral.IVRMenuInfo](./RingCentral.Net/Definitions/RingCentral.IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRMenu) in API Explorer.


## Get IVR Menu

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().GET();
}
```


- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRMenu) in API Explorer.


## Update IVR Menu

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().PUT(ringCentralIvrMenuInfo);
}
```

- Parameter `ringCentralIvrMenuInfo` is of type [RingCentral.IVRMenuInfo](./RingCentral.Net/Definitions/RingCentral.IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRMenu) in API Explorer.


## Create IVR Menu

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).POST(ringCentralIvrMenuInfo);
}
```

- Parameter `ringCentralIvrMenuInfo` is of type [RingCentral.IVRMenuInfo](./RingCentral.Net/Definitions/RingCentral.IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRMenu) in API Explorer.


## Get IVR Menu

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).GET();
}
```


- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRMenu) in API Explorer.


## Update IVR Menu

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`AutoReceptionist`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).PUT(ringCentralIvrMenuInfo);
}
```

- Parameter `ringCentralIvrMenuInfo` is of type [RingCentral.IVRMenuInfo](./RingCentral.Net/Definitions/RingCentral.IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRMenu) in API Explorer.


## Create IVR Prompts

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().POST(createIvrPromptRequest);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRPrompt) in API Explorer.


## Get IVR Prompt List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().GET();
}
```


- `result` is of type [IVRPrompts](./RingCentral.Net/Definitions/IVRPrompts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-listIVRPrompts) in API Explorer.


## Get IVR Prompt

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().GET();
}
```


- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRPrompt) in API Explorer.


## Delete IVR Prompt

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-deleteIVRPrompt) in API Explorer.


## Update IVR Prompt

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().PUT(ringCentralUpdateIvrPromptRequest);
}
```

- Parameter `ringCentralUpdateIvrPromptRequest` is of type [RingCentral.UpdateIVRPromptRequest](./RingCentral.Net/Definitions/RingCentral.UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRPrompt) in API Explorer.


## Create IVR Prompts

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).POST(createIvrPromptRequest);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRPrompt) in API Explorer.


## Get IVR Prompt List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).GET();
}
```


- `result` is of type [IVRPrompts](./RingCentral.Net/Definitions/IVRPrompts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-listIVRPrompts) in API Explorer.


## Get IVR Prompt

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).GET();
}
```


- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRPrompt) in API Explorer.


## Delete IVR Prompt

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-deleteIVRPrompt) in API Explorer.


## Update IVR Prompt

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`EditCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).PUT(ringCentralUpdateIvrPromptRequest);
}
```

- Parameter `ringCentralUpdateIvrPromptRequest` is of type [RingCentral.UpdateIVRPromptRequest](./RingCentral.Net/Definitions/RingCentral.UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRPrompt) in API Explorer.


## Get IVR Prompt Content

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyGreetings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-readIVRPromptContent) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get Account Meeting Recordings List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/meeting-recordings`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Meetings`</td></tr><tr><td>User Permission Required</td><td>`MeetingsRecordings`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MeetingRecordings().GET(listAccountMeetingRecordingsParameters);
}
```

- Parameter `listAccountMeetingRecordingsParameters` is of type [ListAccountMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListAccountMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listAccountMeetingRecordings) in API Explorer.


## Get Message Store Configuration

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-configuration`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AccountAdministration`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().GET();
}
```


- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageStoreConfiguration) in API Explorer.


## Update Message Store Configuration

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-configuration`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`AccountAdministration`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().PUT(ringCentralMessageStoreConfiguration);
}
```

- Parameter `ringCentralMessageStoreConfiguration` is of type [RingCentral.MessageStoreConfiguration](./RingCentral.Net/Definitions/RingCentral.MessageStoreConfiguration.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API Explorer.


## Create Message Store Report

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().POST(ringCentralCreateMessageStoreReportRequest);
}
```

- Parameter `ringCentralCreateMessageStoreReportRequest` is of type [RingCentral.CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/RingCentral.CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().GET();
}
```


- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API Explorer.


## Create Message Store Report

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).POST(ringCentralCreateMessageStoreReportRequest);
}
```

- Parameter `ringCentralCreateMessageStoreReportRequest` is of type [RingCentral.CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/RingCentral.CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).GET();
}
```


- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API Explorer.


## Get Message Store Report Archive

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().GET();
}
```


- `result` is of type [MessageStoreReportArchive](./RingCentral.Net/Definitions/MessageStoreReportArchive.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API Explorer.


## Get Message Store Report Archive Content

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().GET();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchiveContent) in API Explorer.


## Get Message Store Report Archive

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).GET();
}
```


- `result` is of type [MessageStoreReportArchive](./RingCentral.Net/Definitions/MessageStoreReportArchive.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API Explorer.


## Get Message Store Report Archive Content

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadMessages`</td></tr><tr><td>User Permission Required</td><td>`Users`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).GET();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchiveContent) in API Explorer.


## Assign Paging Group Users and Devices

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`Groups`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().POST(ringCentralEditPagingGroupRequest);
}
```

- Parameter `ringCentralEditPagingGroupRequest` is of type [RingCentral.EditPagingGroupRequest](./RingCentral.Net/Definitions/RingCentral.EditPagingGroupRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices) in API Explorer.


## Get Paging Group Devices

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyDevices`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().GET(listPagingGroupDevicesParameters);
}
```

- Parameter `listPagingGroupDevicesParameters` is of type [ListPagingGroupDevicesParameters](./RingCentral.Net/Definitions/ListPagingGroupDevicesParameters.cs)
- `result` is of type [PagingOnlyGroupDevices](./RingCentral.Net/Definitions/PagingOnlyGroupDevices.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupDevices) in API Explorer.


## Get Paging Group Users

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadUserInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().GET(listPagingGroupUsersParameters);
}
```

- Parameter `listPagingGroupUsersParameters` is of type [ListPagingGroupUsersParameters](./RingCentral.Net/Definitions/ListPagingGroupUsersParameters.cs)
- `result` is of type [PagingOnlyGroupUsers](./RingCentral.Net/Definitions/PagingOnlyGroupUsers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupUsers) in API Explorer.


## Get Company Phone Number List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/phone-number`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyPhoneNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().GET(listAccountPhoneNumbersParameters);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- `result` is of type [AccountPhoneNumbers](./RingCentral.Net/Definitions/AccountPhoneNumbers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbers) in API Explorer.


## Get Phone Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyPhoneNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().GET();
}
```


- `result` is of type [CompanyPhoneNumberInfo](./RingCentral.Net/Definitions/CompanyPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.


## Get Company Phone Number List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/phone-number`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyPhoneNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).GET(listAccountPhoneNumbersParameters);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- `result` is of type [AccountPhoneNumbers](./RingCentral.Net/Definitions/AccountPhoneNumbers.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbers) in API Explorer.


## Get Phone Number

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyPhoneNumbers`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).GET();
}
```


- `result` is of type [CompanyPhoneNumberInfo](./RingCentral.Net/Definitions/CompanyPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.


## Get User Presence Status List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/presence`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadPresence`</td></tr><tr><td>User Permission Required</td><td>`ReadPresenceStatus`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Presence().GET(readAccountPresenceParameters);
}
```

- Parameter `readAccountPresenceParameters` is of type [ReadAccountPresenceParameters](./RingCentral.Net/Definitions/ReadAccountPresenceParameters.cs)
- `result` is of type [AccountPresenceInfo](./RingCentral.Net/Definitions/AccountPresenceInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readAccountPresence) in API Explorer.


## Get Call Recording

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/recording/{recordingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallRecording`</td></tr><tr><td>User Permission Required</td><td>`ReadCallRecording`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).GET();
}
```


- `result` is of type [GetCallRecordingResponse](./RingCentral.Net/Definitions/GetCallRecordingResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecording) in API Explorer.


## Get Call Recordings Data

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/recording/{recordingId}/content`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`ReadCallRecording`</td></tr><tr><td>User Permission Required</td><td>`ReadCallRecording`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-listCallRecordingData) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get Account Service Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/service-info`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadServicePlanInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().GET();
}
```


- `result` is of type [GetServiceInfoResponse](./RingCentral.Net/Definitions/GetServiceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountServiceInfo) in API Explorer.


## Make CallOut

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/call-out`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().POST(ringCentralMakeCallOutRequest);
}
```

- Parameter `ringCentralMakeCallOutRequest` is of type [RingCentral.MakeCallOutRequest](./RingCentral.Net/Definitions/RingCentral.MakeCallOutRequest.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallOutCallSession) in API Explorer.


## Get Call Session Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).GET(readCallSessionStatusParameters);
}
```

- Parameter `readCallSessionStatusParameters` is of type [ReadCallSessionStatusParameters](./RingCentral.Net/Definitions/ReadCallSessionStatusParameters.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallSessionStatus) in API Explorer.


## Drop Call Session

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallSession) in API Explorer.


## Get Call Party Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).GET();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallPartyStatus) in API Explorer.


## Update Call Party

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).PATCH(ringCentralPartyUpdateRequest);
}
```

- Parameter `ringCentralPartyUpdateRequest` is of type [RingCentral.PartyUpdateRequest](./RingCentral.Net/Definitions/RingCentral.PartyUpdateRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.


## Answer Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().POST(ringCentralAnswerTarget);
}
```

- Parameter `ringCentralAnswerTarget` is of type [RingCentral.AnswerTarget](./RingCentral.Net/Definitions/RingCentral.AnswerTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-answerCallParty) in API Explorer.


## Call Flip on Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().POST(ringCentralCallPartyFlip);
}
```

- Parameter `ringCentralCallPartyFlip` is of type [RingCentral.CallPartyFlip](./RingCentral.Net/Definitions/RingCentral.CallPartyFlip.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callFlipParty) in API Explorer.


## Forward Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().POST(ringCentralForwardTarget);
}
```

- Parameter `ringCentralForwardTarget` is of type [RingCentral.ForwardTarget](./RingCentral.Net/Definitions/RingCentral.ForwardTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-forwardCallParty) in API Explorer.


## Hold Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().POST();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-holdCallParty) in API Explorer.


## Ignore Call in Queue

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().POST(ringCentralIgnoreRequestBody);
}
```

- Parameter `ringCentralIgnoreRequestBody` is of type [RingCentral.IgnoreRequestBody](./RingCentral.Net/Definitions/RingCentral.IgnoreRequestBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.


## Call Park

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Park().POST();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callParkParty) in API Explorer.


## Pickup Call

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().POST(ringCentralPickupTarget);
}
```

- Parameter `ringCentralPickupTarget` is of type [RingCentral.PickupTarget](./RingCentral.Net/Definitions/RingCentral.PickupTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pickupCallParty) in API Explorer.


## Create Recording

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-startCallRecording) in API Explorer.


## Pause/Resume Recording

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().PATCH(ringCentralCallRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `ringCentralCallRecordingUpdate` is of type [RingCentral.CallRecordingUpdate](./RingCentral.Net/Definitions/RingCentral.CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Create Recording

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-startCallRecording) in API Explorer.


## Pause/Resume Recording

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).PATCH(ringCentralCallRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `ringCentralCallRecordingUpdate` is of type [RingCentral.CallRecordingUpdate](./RingCentral.Net/Definitions/RingCentral.CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Reject Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-rejectParty) in API Explorer.


## Reply with Text

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().POST(ringCentralCallPartyReply);
}
```

- Parameter `ringCentralCallPartyReply` is of type [RingCentral.CallPartyReply](./RingCentral.Net/Definitions/RingCentral.CallPartyReply.cs)
- `result` is of type [ReplyParty](./RingCentral.Net/Definitions/ReplyParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-replyParty) in API Explorer.


## Supervise Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().POST(ringCentralPartySuperviseRequest);
}
```

- Parameter `ringCentralPartySuperviseRequest` is of type [RingCentral.PartySuperviseRequest](./RingCentral.Net/Definitions/RingCentral.PartySuperviseRequest.cs)
- `result` is of type [PartySuperviseResponse](./RingCentral.Net/Definitions/PartySuperviseResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallParty) in API Explorer.


## Transfer Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().POST(ringCentralTransferTarget);
}
```

- Parameter `ringCentralTransferTarget` is of type [RingCentral.TransferTarget](./RingCentral.Net/Definitions/RingCentral.TransferTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-transferCallParty) in API Explorer.


## Unhold Call Party

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().POST();
}
```


- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-unholdCallParty) in API Explorer.


## Supervise Call Session

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`CallControl`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().POST(ringCentralSuperviseCallSessionRequest);
}
```

- Parameter `ringCentralSuperviseCallSessionRequest` is of type [RingCentral.SuperviseCallSessionRequest](./RingCentral.Net/Definitions/RingCentral.SuperviseCallSessionRequest.cs)
- `result` is of type [SuperviseCallSession](./RingCentral.Net/Definitions/SuperviseCallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.


## Get User Template List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/templates`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().GET(listUserTemplatesParameters);
}
```

- Parameter `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./RingCentral.Net/Definitions/ListUserTemplatesParameters.cs)
- `result` is of type [UserTemplates](./RingCentral.Net/Definitions/UserTemplates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listUserTemplates) in API Explorer.


## Get User Template

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/templates/{templateId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().GET();
}
```


- `result` is of type [TemplateInfo](./RingCentral.Net/Definitions/TemplateInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.


## Get User Template List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/templates`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).GET(listUserTemplatesParameters);
}
```

- Parameter `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./RingCentral.Net/Definitions/ListUserTemplatesParameters.cs)
- `result` is of type [UserTemplates](./RingCentral.Net/Definitions/UserTemplates.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listUserTemplates) in API Explorer.


## Get User Template

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/account/{accountId}/templates/{templateId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`ReadCompanyInfo`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).GET();
}
```


- `result` is of type [TemplateInfo](./RingCentral.Net/Definitions/TemplateInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.


## Register SIP Device

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/client-info/sip-provision`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`VoipCalling`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().POST(ringCentralCreateSipRegistrationRequest);
}
```

- Parameter `ringCentralCreateSipRegistrationRequest` is of type [RingCentral.CreateSipRegistrationRequest](./RingCentral.Net/Definitions/RingCentral.CreateSipRegistrationRequest.cs)
- `result` is of type [CreateSipRegistrationResponse](./RingCentral.Net/Definitions/CreateSipRegistrationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#SIP-createSIPRegistration) in API Explorer.


## Get Country List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/country`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country().GET(listCountriesParameters);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listCountries) in API Explorer.


## Get Country

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/country/{countryId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country().GET();
}
```


- `result` is of type [GetCountryInfoDictionaryResponse](./RingCentral.Net/Definitions/GetCountryInfoDictionaryResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.


## Get Country List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/country`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).GET(listCountriesParameters);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listCountries) in API Explorer.


## Get Country

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/country/{countryId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).GET();
}
```


- `result` is of type [GetCountryInfoDictionaryResponse](./RingCentral.Net/Definitions/GetCountryInfoDictionaryResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.


## Get Fax Cover Page List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/fax-cover-page`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().GET(listFaxCoverPagesParameters);
}
```

- Parameter `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./RingCentral.Net/Definitions/ListFaxCoverPagesParameters.cs)
- `result` is of type [ListFaxCoverPagesResponse](./RingCentral.Net/Definitions/ListFaxCoverPagesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Fax-listFaxCoverPages) in API Explorer.


## Get Standard Greeting List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/greeting`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().GET(listStandardGreetingsParameters);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- `result` is of type [DictionaryGreetingList](./RingCentral.Net/Definitions/DictionaryGreetingList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listStandardGreetings) in API Explorer.


## Get Standard Greeting

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/greeting/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().GET();
}
```


- `result` is of type [DictionaryGreetingInfo](./RingCentral.Net/Definitions/DictionaryGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readStandardGreeting) in API Explorer.


## Get Standard Greeting List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/greeting`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).GET(listStandardGreetingsParameters);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- `result` is of type [DictionaryGreetingList](./RingCentral.Net/Definitions/DictionaryGreetingList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-listStandardGreetings) in API Explorer.


## Get Standard Greeting

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/greeting/{greetingId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).GET();
}
```


- `result` is of type [DictionaryGreetingInfo](./RingCentral.Net/Definitions/DictionaryGreetingInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-readStandardGreeting) in API Explorer.


## Get Language List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/language`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language().GET();
}
```


- `result` is of type [LanguageList](./RingCentral.Net/Definitions/LanguageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLanguages) in API Explorer.


## Get Language

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/language/{languageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language().GET();
}
```


- `result` is of type [LanguageInfo](./RingCentral.Net/Definitions/LanguageInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.


## Get Language List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/language`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).GET();
}
```


- `result` is of type [LanguageList](./RingCentral.Net/Definitions/LanguageList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLanguages) in API Explorer.


## Get Language

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/language/{languageId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).GET();
}
```


- `result` is of type [LanguageInfo](./RingCentral.Net/Definitions/LanguageInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.


## Get Location List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/location`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Location().GET(listLocationsParameters);
}
```

- Parameter `listLocationsParameters` is of type [ListLocationsParameters](./RingCentral.Net/Definitions/ListLocationsParameters.cs)
- `result` is of type [GetLocationListResponse](./RingCentral.Net/Definitions/GetLocationListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLocations) in API Explorer.


## Get States List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/state`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State().GET(listStatesParameters);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- `result` is of type [GetStateListResponse](./RingCentral.Net/Definitions/GetStateListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listStates) in API Explorer.


## Get State

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/state/{stateId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State().GET();
}
```


- `result` is of type [GetStateInfoResponse](./RingCentral.Net/Definitions/GetStateInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.


## Get States List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/state`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).GET(listStatesParameters);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- `result` is of type [GetStateListResponse](./RingCentral.Net/Definitions/GetStateListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listStates) in API Explorer.


## Get State

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/state/{stateId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).GET();
}
```


- `result` is of type [GetStateInfoResponse](./RingCentral.Net/Definitions/GetStateInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.


## Get Timezone List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/timezone`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().GET(listTimezonesParameters);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- `result` is of type [GetTimezoneListResponse](./RingCentral.Net/Definitions/GetTimezoneListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listTimezones) in API Explorer.


## Get Timezone

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/timezone/{timezoneId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().GET(readTimezoneParameters);
}
```

- Parameter `readTimezoneParameters` is of type [ReadTimezoneParameters](./RingCentral.Net/Definitions/ReadTimezoneParameters.cs)
- `result` is of type [GetTimezoneInfoResponse](./RingCentral.Net/Definitions/GetTimezoneInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.


## Get Timezone List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/timezone`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).GET(listTimezonesParameters);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- `result` is of type [GetTimezoneListResponse](./RingCentral.Net/Definitions/GetTimezoneListResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listTimezones) in API Explorer.


## Get Timezone

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/dictionary/timezone/{timezoneId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).GET(readTimezoneParameters);
}
```

- Parameter `readTimezoneParameters` is of type [ReadTimezoneParameters](./RingCentral.Net/Definitions/ReadTimezoneParameters.cs)
- `result` is of type [GetTimezoneInfoResponse](./RingCentral.Net/Definitions/GetTimezoneInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.


## Create Card

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().POST(ringCentralGlipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `ringCentralGlipMessageAttachmentInfoRequest` is of type [RingCentral.GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/RingCentral.GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipCard) in API Explorer.


## Get Card

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().GET();
}
```


- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipCard) in API Explorer.


## Update Card

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().PUT(ringCentralGlipMessageAttachmentInfoRequest);
}
```

- Parameter `ringCentralGlipMessageAttachmentInfoRequest` is of type [RingCentral.GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/RingCentral.GlipMessageAttachmentInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipCard) in API Explorer.


## Delete Card

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipCard) in API Explorer.


## Create Card

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).POST(ringCentralGlipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `ringCentralGlipMessageAttachmentInfoRequest` is of type [RingCentral.GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/RingCentral.GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipCard) in API Explorer.


## Get Card

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).GET();
}
```


- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipCard) in API Explorer.


## Update Card

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).PUT(ringCentralGlipMessageAttachmentInfoRequest);
}
```

- Parameter `ringCentralGlipMessageAttachmentInfoRequest` is of type [RingCentral.GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/RingCentral.GlipMessageAttachmentInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipCard) in API Explorer.


## Delete Card

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/cards/{cardId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipCard) in API Explorer.


## Get Chats

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats().GET(listGlipChatsParameters);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- `result` is of type [GlipChatsList](./RingCentral.Net/Definitions/GlipChatsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChats) in API Explorer.


## Get Chat

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats().GET();
}
```


- `result` is of type [GlipChatInfo](./RingCentral.Net/Definitions/GlipChatInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChat) in API Explorer.


## Get Chats

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).GET(listGlipChatsParameters);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- `result` is of type [GlipChatsList](./RingCentral.Net/Definitions/GlipChatsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChats) in API Explorer.


## Get Chat

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).GET();
}
```


- `result` is of type [GlipChatInfo](./RingCentral.Net/Definitions/GlipChatInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChat) in API Explorer.


## Add Chat to Favorites

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/favorite`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Favorite().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-favoriteGlipChat) in API Explorer.


## Create Note

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/notes`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().POST(ringCentralGlipNoteCreate);
}
```

- Parameter `ringCentralGlipNoteCreate` is of type [RingCentral.GlipNoteCreate](./RingCentral.Net/Definitions/RingCentral.GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNote) in API Explorer.


## Get Chat Notes

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/notes`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().GET(listChatNotesParameters);
}
```

- Parameter `listChatNotesParameters` is of type [ListChatNotesParameters](./RingCentral.Net/Definitions/ListChatNotesParameters.cs)
- `result` is of type [GlipNotesInfo](./RingCentral.Net/Definitions/GlipNotesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-listChatNotes) in API Explorer.


## Get Posts

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().GET(readGlipPostsParameters);
}
```

- Parameter `readGlipPostsParameters` is of type [ReadGlipPostsParameters](./RingCentral.Net/Definitions/ReadGlipPostsParameters.cs)
- `result` is of type [GlipPostsList](./RingCentral.Net/Definitions/GlipPostsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPosts) in API Explorer.


## Create Post

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().POST(ringCentralGlipPostPostBody);
}
```

- Parameter `ringCentralGlipPostPostBody` is of type [RingCentral.GlipPostPostBody](./RingCentral.Net/Definitions/RingCentral.GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().GET();
}
```


- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPost) in API Explorer.


## Update Post

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().PATCH(ringCentralGlipPatchPostBody);
}
```

- Parameter `ringCentralGlipPatchPostBody` is of type [RingCentral.GlipPatchPostBody](./RingCentral.Net/Definitions/RingCentral.GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPost) in API Explorer.


## Get Posts

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).GET(readGlipPostsParameters);
}
```

- Parameter `readGlipPostsParameters` is of type [ReadGlipPostsParameters](./RingCentral.Net/Definitions/ReadGlipPostsParameters.cs)
- `result` is of type [GlipPostsList](./RingCentral.Net/Definitions/GlipPostsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPosts) in API Explorer.


## Create Post

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).POST(ringCentralGlipPostPostBody);
}
```

- Parameter `ringCentralGlipPostPostBody` is of type [RingCentral.GlipPostPostBody](./RingCentral.Net/Definitions/RingCentral.GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).GET();
}
```


- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPost) in API Explorer.


## Update Post

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).PATCH(ringCentralGlipPatchPostBody);
}
```

- Parameter `ringCentralGlipPatchPostBody` is of type [RingCentral.GlipPatchPostBody](./RingCentral.Net/Definitions/RingCentral.GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPost) in API Explorer.


## Mark Chat as Read

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/read`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`GlipInternal`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Read().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatRead) in API Explorer.


## Get Chat Tasks

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/tasks`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().GET(listChatTasksParameters);
}
```

- Parameter `listChatTasksParameters` is of type [ListChatTasksParameters](./RingCentral.Net/Definitions/ListChatTasksParameters.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-listChatTasks) in API Explorer.


## Create Task

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/tasks`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().POST(ringCentralGlipCreateTask);
}
```

- Parameter `ringCentralGlipCreateTask` is of type [RingCentral.GlipCreateTask](./RingCentral.Net/Definitions/RingCentral.GlipCreateTask.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTask) in API Explorer.


## Remove Chat from Favorites

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/unfavorite`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unfavorite().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-unfavoriteGlipChat) in API Explorer.


## Mark Chat as Unread

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/chats/{chatId}/unread`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`GlipInternal`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unread().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatUnread) in API Explorer.


## Get Company Info

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/companies/{companyId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Companies(companyId).GET();
}
```


- `result` is of type [GlipCompany](./RingCentral.Net/Definitions/GlipCompany.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipCompany) in API Explorer.


## Get Conversations

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().GET(listGlipConversationsParameters);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- `result` is of type [GlipConversationsList](./RingCentral.Net/Definitions/GlipConversationsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversations) in API Explorer.


## Create/Open Conversation

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().POST(ringCentralCreateGlipConversationRequest);
}
```

- Parameter `ringCentralCreateGlipConversationRequest` is of type [RingCentral.CreateGlipConversationRequest](./RingCentral.Net/Definitions/RingCentral.CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().GET();
}
```


- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversation) in API Explorer.


## Get Conversations

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).GET(listGlipConversationsParameters);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- `result` is of type [GlipConversationsList](./RingCentral.Net/Definitions/GlipConversationsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversations) in API Explorer.


## Create/Open Conversation

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).POST(ringCentralCreateGlipConversationRequest);
}
```

- Parameter `ringCentralCreateGlipConversationRequest` is of type [RingCentral.CreateGlipConversationRequest](./RingCentral.Net/Definitions/RingCentral.CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/conversations/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).GET();
}
```


- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversation) in API Explorer.


## Create Data Export Task

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().POST(ringCentralCreateDataExportTaskRequest);
}
```

- Parameter `ringCentralCreateDataExportTaskRequest` is of type [RingCentral.CreateDataExportTaskRequest](./RingCentral.Net/Definitions/RingCentral.CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().GET(listDataExportTasksParameters);
}
```

- Parameter `listDataExportTasksParameters` is of type [ListDataExportTasksParameters](./RingCentral.Net/Definitions/ListDataExportTasksParameters.cs)
- `result` is of type [DataExportTaskList](./RingCentral.Net/Definitions/DataExportTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-listDataExportTasks) in API Explorer.


## Get Data Export Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().GET();
}
```


- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTask) in API Explorer.


## Create Data Export Task

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).POST(ringCentralCreateDataExportTaskRequest);
}
```

- Parameter `ringCentralCreateDataExportTaskRequest` is of type [RingCentral.CreateDataExportTaskRequest](./RingCentral.Net/Definitions/RingCentral.CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).GET(listDataExportTasksParameters);
}
```

- Parameter `listDataExportTasksParameters` is of type [ListDataExportTasksParameters](./RingCentral.Net/Definitions/ListDataExportTasksParameters.cs)
- `result` is of type [DataExportTaskList](./RingCentral.Net/Definitions/DataExportTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-listDataExportTasks) in API Explorer.


## Get Data Export Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).GET();
}
```


- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTask) in API Explorer.


## Get Data Export Task Dataset

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Datasets(datasetId).GET();
}
```


- `result` is of type `byte[]`
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTaskDataset) in API Explorer.

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).


## Get User Events List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().GET(readGlipEventsParameters);
}
```

- Parameter `readGlipEventsParameters` is of type [ReadGlipEventsParameters](./RingCentral.Net/Definitions/ReadGlipEventsParameters.cs)
- `result` is of type [GlipEventsInfo](./RingCentral.Net/Definitions/GlipEventsInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEvents) in API Explorer.


## Create Event

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().POST(ringCentralGlipEventCreate);
}
```

- Parameter `ringCentralGlipEventCreate` is of type [RingCentral.GlipEventCreate](./RingCentral.Net/Definitions/RingCentral.GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().GET();
}
```


- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEvent) in API Explorer.


## Update Event

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().PUT(ringCentralGlipEventCreate);
}
```

- Parameter `ringCentralGlipEventCreate` is of type [RingCentral.GlipEventCreate](./RingCentral.Net/Definitions/RingCentral.GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEvent) in API Explorer.


## Get User Events List

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).GET(readGlipEventsParameters);
}
```

- Parameter `readGlipEventsParameters` is of type [ReadGlipEventsParameters](./RingCentral.Net/Definitions/ReadGlipEventsParameters.cs)
- `result` is of type [GlipEventsInfo](./RingCentral.Net/Definitions/GlipEventsInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEvents) in API Explorer.


## Create Event

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).POST(ringCentralGlipEventCreate);
}
```

- Parameter `ringCentralGlipEventCreate` is of type [RingCentral.GlipEventCreate](./RingCentral.Net/Definitions/RingCentral.GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).GET();
}
```


- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEvent) in API Explorer.


## Update Event

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).PUT(ringCentralGlipEventCreate);
}
```

- Parameter `ringCentralGlipEventCreate` is of type [RingCentral.GlipEventCreate](./RingCentral.Net/Definitions/RingCentral.GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/events/{eventId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEvent) in API Explorer.


## Get Everyone Chat

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/everyone`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().GET();
}
```


- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipEveryone) in API Explorer.


## Update Everyone Сhat

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/everyone`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().PATCH(ringCentralUpdateGlipEveryoneRequest);
}
```

- Parameter `ringCentralUpdateGlipEveryoneRequest` is of type [RingCentral.UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/RingCentral.UpdateGlipEveryoneRequest.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryone) in API Explorer.


## Get Favorite Chats

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/favorites`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Favorites().GET(listFavoriteChatsParameters);
}
```

- Parameter `listFavoriteChatsParameters` is of type [ListFavoriteChatsParameters](./RingCentral.Net/Definitions/ListFavoriteChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listFavoriteChats) in API Explorer.


## Get User Groups

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().GET(listGlipGroupsParameters);
}
```

- Parameter `listGlipGroupsParameters` is of type [ListGlipGroupsParameters](./RingCentral.Net/Definitions/ListGlipGroupsParameters.cs)
- `result` is of type [GlipGroupList](./RingCentral.Net/Definitions/GlipGroupList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipGroups) in API Explorer.


## Create Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().POST(ringCentralGlipCreateGroup);
}
```

- Parameter `ringCentralGlipCreateGroup` is of type [RingCentral.GlipCreateGroup](./RingCentral.Net/Definitions/RingCentral.GlipCreateGroup.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-createGlipGroup) in API Explorer.


## Get Group

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().GET();
}
```


- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipGroup) in API Explorer.


## Get User Groups

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).GET(listGlipGroupsParameters);
}
```

- Parameter `listGlipGroupsParameters` is of type [ListGlipGroupsParameters](./RingCentral.Net/Definitions/ListGlipGroupsParameters.cs)
- `result` is of type [GlipGroupList](./RingCentral.Net/Definitions/GlipGroupList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipGroups) in API Explorer.


## Create Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).POST(ringCentralGlipCreateGroup);
}
```

- Parameter `ringCentralGlipCreateGroup` is of type [RingCentral.GlipCreateGroup](./RingCentral.Net/Definitions/RingCentral.GlipCreateGroup.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-createGlipGroup) in API Explorer.


## Get Group

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).GET();
}
```


- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipGroup) in API Explorer.


## Edit Group Members

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/bulk-assign`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).BulkAssign().POST(ringCentralEditGroupRequest);
}
```

- Parameter `ringCentralEditGroupRequest` is of type [RingCentral.EditGroupRequest](./RingCentral.Net/Definitions/RingCentral.EditGroupRequest.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-assignGlipGroupMembers) in API Explorer.


## Create Event by Group ID

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().POST(ringCentralGlipEventCreate);
}
```

- Parameter `ringCentralGlipEventCreate` is of type [RingCentral.GlipEventCreate](./RingCentral.Net/Definitions/RingCentral.GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventbyGroupId) in API Explorer.


## Get Group Events

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/events`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().GET();
}
```


- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-listGroupEvents) in API Explorer.


## Get Group Posts

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().GET(listGlipGroupPostsParameters);
}
```

- Parameter `listGlipGroupPostsParameters` is of type [ListGlipGroupPostsParameters](./RingCentral.Net/Definitions/ListGlipGroupPostsParameters.cs)
- `result` is of type [GlipPosts](./RingCentral.Net/Definitions/GlipPosts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-listGlipGroupPosts) in API Explorer.


## Create Post in Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().POST(ringCentralGlipCreatePost);
}
```

- Parameter `ringCentralGlipCreatePost` is of type [RingCentral.GlipCreatePost](./RingCentral.Net/Definitions/RingCentral.GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipGroupPost) in API Explorer.


## Update Post

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts(postId).Text().PUT(string);
}
```

- Parameter `string` is of type [string](./RingCentral.Net/Definitions/string.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipPostText) in API Explorer.


## Create Webhook in Group

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/webhooks`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().POST();
}
```


- `result` is of type [GlipWebhookInfo](./RingCentral.Net/Definitions/GlipWebhookInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-createGlipGroupWebhook) in API Explorer.


## Get Webhooks in Group

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/groups/{groupId}/webhooks`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().GET();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipGroupWebhooks) in API Explorer.


## Get Note

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).GET();
}
```


- `result` is of type [GetGlipNoteInfo](./RingCentral.Net/Definitions/GetGlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-readUserNote) in API Explorer.


## Update Note

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).PATCH(ringCentralGlipNoteCreate);
}
```

- Parameter `ringCentralGlipNoteCreate` is of type [RingCentral.GlipNoteCreate](./RingCentral.Net/Definitions/RingCentral.GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNote) in API Explorer.


## Delete Note

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-deleteNote) in API Explorer.


## Lock Note

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}/lock`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Lock().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-lockNote) in API Explorer.


## Publish Note

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}/publish`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Publish().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-publishNote) in API Explorer.


## Unlock Note

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/notes/{noteId}/unlock`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Unlock().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-unlockNote) in API Explorer.


## Get Person

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/persons/{personId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Persons(personId).GET();
}
```


- `result` is of type [GlipPersonInfo](./RingCentral.Net/Definitions/GlipPersonInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPerson) in API Explorer.


## Get Posts

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Posts().GET(listGlipPostsParameters);
}
```

- Parameter `listGlipPostsParameters` is of type [ListGlipPostsParameters](./RingCentral.Net/Definitions/ListGlipPostsParameters.cs)
- `result` is of type [GlipPosts](./RingCentral.Net/Definitions/GlipPosts.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-listGlipPosts) in API Explorer.


## Create Post

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/posts`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Posts().POST(ringCentralGlipCreatePost);
}
```

- Parameter `ringCentralGlipCreatePost` is of type [RingCentral.GlipCreatePost](./RingCentral.Net/Definitions/RingCentral.GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createPost) in API Explorer.


## Get Preferences

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/preferences`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Preferences().GET();
}
```


- `result` is of type [GlipPreferencesInfo](./RingCentral.Net/Definitions/GlipPreferencesInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPreferences) in API Explorer.


## Get Recent Chats

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/recent/chats`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Recent().Chats().GET(listRecentChatsParameters);
}
```

- Parameter `listRecentChatsParameters` is of type [ListRecentChatsParameters](./RingCentral.Net/Definitions/ListRecentChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listRecentChats) in API Explorer.


## Get Task

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/tasks/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).GET();
}
```


- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-readTask) in API Explorer.


## Patch Task

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/tasks/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).PATCH(ringCentralGlipUpdateTask);
}
```

- Parameter `ringCentralGlipUpdateTask` is of type [RingCentral.GlipUpdateTask](./RingCentral.Net/Definitions/RingCentral.GlipUpdateTask.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTask) in API Explorer.


## Delete Task

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/tasks/{taskId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-deleteTask) in API Explorer.


## Complete Task

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/tasks/{taskId}/complete`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Complete().POST(ringCentralGlipCompleteTask);
}
```

- Parameter `ringCentralGlipCompleteTask` is of type [RingCentral.GlipCompleteTask](./RingCentral.Net/Definitions/RingCentral.GlipCompleteTask.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTask) in API Explorer.


## Get Teams

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().GET(listGlipTeamsParameters);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- `result` is of type [GlipTeamsList](./RingCentral.Net/Definitions/GlipTeamsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeams) in API Explorer.


## Create Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().POST(ringCentralGlipPostTeamBody);
}
```

- Parameter `ringCentralGlipPostTeamBody` is of type [RingCentral.GlipPostTeamBody](./RingCentral.Net/Definitions/RingCentral.GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().GET();
}
```


- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeam) in API Explorer.


## Update Team

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().PATCH(ringCentralGlipPatchTeamBody);
}
```

- Parameter `ringCentralGlipPatchTeamBody` is of type [RingCentral.GlipPatchTeamBody](./RingCentral.Net/Definitions/RingCentral.GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeam) in API Explorer.


## Get Teams

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).GET(listGlipTeamsParameters);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- `result` is of type [GlipTeamsList](./RingCentral.Net/Definitions/GlipTeamsList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeams) in API Explorer.


## Create Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).POST(ringCentralGlipPostTeamBody);
}
```

- Parameter `ringCentralGlipPostTeamBody` is of type [RingCentral.GlipPostTeamBody](./RingCentral.Net/Definitions/RingCentral.GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).GET();
}
```


- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeam) in API Explorer.


## Update Team

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).PATCH(ringCentralGlipPatchTeamBody);
}
```

- Parameter `ringCentralGlipPatchTeamBody` is of type [RingCentral.GlipPatchTeamBody](./RingCentral.Net/Definitions/RingCentral.GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeam) in API Explorer.


## Add Team Members

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/add`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().POST(ringCentralGlipPostMembersListBody);
}
```

- Parameter `ringCentralGlipPostMembersListBody` is of type [RingCentral.GlipPostMembersListBody](./RingCentral.Net/Definitions/RingCentral.GlipPostMembersListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembers) in API Explorer.


## Archive Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/archive`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Archive().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-archiveGlipTeam) in API Explorer.


## Join Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/join`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Join().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-joinGlipTeam) in API Explorer.


## Leave Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/leave`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Leave().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-leaveGlipTeam) in API Explorer.


## Remove Team Members

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/remove`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().POST(ringCentralGlipPostMembersIdsListBody);
}
```

- Parameter `ringCentralGlipPostMembersIdsListBody` is of type [RingCentral.GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/RingCentral.GlipPostMembersIdsListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembers) in API Explorer.


## Unarchive Team

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/teams/{chatId}/unarchive`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Unarchive().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-unarchiveGlipTeam) in API Explorer.


## Get Webhooks

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().GET();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipWebhooks) in API Explorer.


## Get Webhook

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().GET();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-readGlipWebhook) in API Explorer.


## Delete Webhook

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-deleteGlipWebhook) in API Explorer.


## Get Webhooks

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).GET();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipWebhooks) in API Explorer.


## Get Webhook

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).GET();
}
```


- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-readGlipWebhook) in API Explorer.


## Delete Webhook

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-deleteGlipWebhook) in API Explorer.


## Activate Webhook

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}/activate`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Activate().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-activateGlipWebhook) in API Explorer.


## Suspend Webhook

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/glip/webhooks/{webhookId}/suspend`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`Glip`</td></tr><tr><td>User Permission Required</td><td>`Glip`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Suspend().POST();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-suspendGlipWebhook) in API Explorer.


## Parse Phone Number

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/number-parser/parse`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().POST(ringCentralParsePhoneNumberRequest, parsePhoneNumberParameters);
}
```

- Parameter `ringCentralParsePhoneNumberRequest` is of type [RingCentral.ParsePhoneNumberRequest](./RingCentral.Net/Definitions/RingCentral.ParsePhoneNumberRequest.cs)
- Parameter `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- `result` is of type [ParsePhoneNumberResponse](./RingCentral.Net/Definitions/ParsePhoneNumberResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-parsePhoneNumber) in API Explorer.


## Get Service Status

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/status`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Status().GET();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIStatus) in API Explorer.


## Get Subscriptions

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().GET();
}
```


- `result` is of type [RecordsCollectionResourceSubscriptionResponse](./RingCentral.Net/Definitions/RecordsCollectionResourceSubscriptionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-listSubscriptions) in API Explorer.


## Create Subscription

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().POST(ringCentralCreateSubscriptionRequest);
}
```

- Parameter `ringCentralCreateSubscriptionRequest` is of type [RingCentral.CreateSubscriptionRequest](./RingCentral.Net/Definitions/RingCentral.CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().GET();
}
```


- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-readSubscription) in API Explorer.


## Renew Subscription / Update Event Filters

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().PUT(ringCentralModifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `ringCentralModifySubscriptionRequest` is of type [RingCentral.ModifySubscriptionRequest](./RingCentral.Net/Definitions/RingCentral.ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.


## Get Subscriptions

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).GET();
}
```


- `result` is of type [RecordsCollectionResourceSubscriptionResponse](./RingCentral.Net/Definitions/RecordsCollectionResourceSubscriptionResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-listSubscriptions) in API Explorer.


## Create Subscription

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).POST(ringCentralCreateSubscriptionRequest);
}
```

- Parameter `ringCentralCreateSubscriptionRequest` is of type [RingCentral.CreateSubscriptionRequest](./RingCentral.Net/Definitions/RingCentral.CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).GET();
}
```


- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-readSubscription) in API Explorer.


## Renew Subscription / Update Event Filters

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).PUT(ringCentralModifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `ringCentralModifySubscriptionRequest` is of type [RingCentral.ModifySubscriptionRequest](./RingCentral.Net/Definitions/RingCentral.ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}`</td></tr><tr><td>Rate Limit Group</td><td>`Medium`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).DELETE();
}
```


- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.


## Renew Subscription

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/restapi/v1.0/subscription/{subscriptionId}/renew`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().POST();
}
```


- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-renewSubscription) in API Explorer.


## Get Service Provider Config

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/ServiceProviderConfig`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).ServiceProviderConfig().GET();
}
```


- `result` is of type [ServiceProviderConfig](./RingCentral.Net/Definitions/ServiceProviderConfig.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readServiceProviderConfig2) in API Explorer.


## Search/List Users

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().GET(searchViaGet2Parameters);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaGet2) in API Explorer.


## Create User

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().POST(ringCentralCreateUser);
}
```

- Parameter `ringCentralCreateUser` is of type [RingCentral.CreateUser](./RingCentral.Net/Definitions/RingCentral.CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Get User

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().GET();
}
```


- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readUser2) in API Explorer.


## Update/Replace User

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().PUT(ringCentralUser);
}
```

- Parameter `ringCentralUser` is of type [RingCentral.User](./RingCentral.Net/Definitions/RingCentral.User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DELETE();
}
```


- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-deleteUser2) in API Explorer.


## Update/Patch User

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().PATCH(ringCentralUserPatch);
}
```

- Parameter `ringCentralUserPatch` is of type [RingCentral.UserPatch](./RingCentral.Net/Definitions/RingCentral.UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Search/List Users

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/.search`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DotSearch().POST(ringCentralSearchRequest);
}
```

- Parameter `ringCentralSearchRequest` is of type [RingCentral.SearchRequest](./RingCentral.Net/Definitions/RingCentral.SearchRequest.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaPost2) in API Explorer.


## Search/List Users

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).GET(searchViaGet2Parameters);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaGet2) in API Explorer.


## Create User

<table><tr><td>HTTP Method</td><td>`POST`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).POST(ringCentralCreateUser);
}
```

- Parameter `ringCentralCreateUser` is of type [RingCentral.CreateUser](./RingCentral.Net/Definitions/RingCentral.CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Get User

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Light`</td></tr><tr><td>App Permission Required</td><td>`ReadAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).GET();
}
```


- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readUser2) in API Explorer.


## Update/Replace User

<table><tr><td>HTTP Method</td><td>`PUT`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).PUT(ringCentralUser);
}
```

- Parameter `ringCentralUser` is of type [RingCentral.User](./RingCentral.Net/Definitions/RingCentral.User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

<table><tr><td>HTTP Method</td><td>`DELETE`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).DELETE();
}
```


- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-deleteUser2) in API Explorer.


## Update/Patch User

<table><tr><td>HTTP Method</td><td>`PATCH`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/Users/{id}`</td></tr><tr><td>Rate Limit Group</td><td>`Heavy`</td></tr><tr><td>App Permission Required</td><td>`EditAccounts`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).PATCH(ringCentralUserPatch);
}
```

- Parameter `ringCentralUserPatch` is of type [RingCentral.UserPatch](./RingCentral.Net/Definitions/RingCentral.UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Check Health

<table><tr><td>HTTP Method</td><td>`GET`</td></tr><tr><td>Endpoint</td><td>`/scim/v2/health`</td></tr><tr><td>Rate Limit Group</td><td>`NoThrottling`</td></tr><tr><td>App Permission Required</td><td>`N/A`</td></tr><tr><td>User Permission Required</td><td>`N/A`</td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Health().GET();
}
```


- `result` is an empty string
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-checkHealth2) in API Explorer.