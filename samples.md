# RingCentral.Net SDK Code Samples


## Get API Versions

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/{apiVersion}</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/oauth/revoke</code></td></tr><tr><td>Rate Limit Group</td><td><code>Auth</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/oauth/token</code></td></tr><tr><td>Rate Limit Group</td><td><code>Auth</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/{apiVersion}</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/active-calls</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().POST(companyAnsweringRuleRequest);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().PUT(companyAnsweringRuleUpdate);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).POST(companyAnsweringRuleRequest);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createCompanyAnsweringRule) in API Explorer.


## Get Company Call Handling Rule List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).PUT(companyAnsweringRuleUpdate);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCompanyAnsweringRule) in API Explorer.


## Delete Company Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/business-address</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/business-address</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyInfo</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().PUT(modifyAccountBusinessAddressRequest);
}
```

- Parameter `modifyAccountBusinessAddressRequest` is of type [ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/ModifyAccountBusinessAddressRequest.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.


## Get Company Business Hours

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/business-hours</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/business-hours</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().PUT(companyBusinessHoursUpdateRequest);
}
```

- Parameter `companyBusinessHoursUpdateRequest` is of type [CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/CompanyBusinessHoursUpdateRequest.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateCompanyBusinessHours) in API Explorer.


## Get Company Call Log Records

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>FullCompanyCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-log/{callRecordId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>FullCompanyCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-log-sync</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>FullCompanyCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-log/{callRecordId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>FullCompanyCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().POST(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().PUT(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).POST(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.


## Get Call Monitoring Groups List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).PUT(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.


## Delete Call Monitoring Group

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().POST(callMonitoringBulkAssign);
}
```

- Parameter `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./RingCentral.Net/Definitions/CallMonitoringBulkAssign.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in API Explorer.


## Get Call Monitoring Group Member List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-queues</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().POST(callQueueBulkAssignResource);
}
```

- Parameter `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./RingCentral.Net/Definitions/CallQueueBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API Explorer.


## Get Call Queue Members

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyInfo</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().PUT(callRecordingSettingsResource);
}
```

- Parameter `callRecordingSettingsResource` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingSettings) in API Explorer.


## Update Call Recording Extension List

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().POST(bulkAccountCallRecordingsResource);
}
```

- Parameter `bulkAccountCallRecordingsResource` is of type [BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/BulkAccountCallRecordingsResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateCallRecordingExtensionList) in API Explorer.


## Get Call Recording Custom Greeting List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/custom-greetings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/custom-greetings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/call-recording/extensions</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().POST(customFieldCreateRequest);
}
```

- Parameter `customFieldCreateRequest` is of type [CustomFieldCreateRequest](./RingCentral.Net/Definitions/CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.


## Get Custom Field List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().PUT(customFieldUpdateRequest);
}
```

- Parameter `customFieldUpdateRequest` is of type [CustomFieldUpdateRequest](./RingCentral.Net/Definitions/CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.


## Delete Custom Field

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).POST(customFieldCreateRequest);
}
```

- Parameter `customFieldCreateRequest` is of type [CustomFieldCreateRequest](./RingCentral.Net/Definitions/CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.


## Get Custom Field List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).PUT(customFieldUpdateRequest);
}
```

- Parameter `customFieldUpdateRequest` is of type [CustomFieldUpdateRequest](./RingCentral.Net/Definitions/CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.


## Delete Custom Field

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/custom-fields/{fieldId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/department/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>UserGroups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Department().BulkAssign().POST(departmentBulkAssignResource);
}
```

- Parameter `departmentBulkAssignResource` is of type [DepartmentBulkAssignResource](./RingCentral.Net/Definitions/DepartmentBulkAssignResource.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleDepartmentMembers) in API Explorer.


## Get Department Member List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/department/{departmentId}/members</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/device/{deviceId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyDevices</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/device/{deviceId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyDevices</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).PUT(accountDeviceUpdate, updateDeviceParameters);
}
```

- Parameter `accountDeviceUpdate` is of type [AccountDeviceUpdate](./RingCentral.Net/Definitions/AccountDeviceUpdate.cs)
- Parameter `updateDeviceParameters` is of type [UpdateDeviceParameters](./RingCentral.Net/Definitions/UpdateDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.


## Get Company Directory Entries

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/entries</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/entries/{entryId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/entries/search</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().POST(searchDirectoryEntriesRequest);
}
```

- Parameter `searchDirectoryEntriesRequest` is of type [SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/SearchDirectoryEntriesRequest.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.


## Get Company Directory Entries

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/entries</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/entries/{entryId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/directory/federation</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().POST(assignMultipleDevicesAutomaticLocationUpdates);
}
```

- Parameter `assignMultipleDevicesAutomaticLocationUpdates` is of type [AssignMultipleDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/AssignMultipleDevicesAutomaticLocationUpdates.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.


## Get Network Map

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().POST(createNetworkRequest);
}
```

- Parameter `createNetworkRequest` is of type [CreateNetworkRequest](./RingCentral.Net/Definitions/CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().PUT(updateNetworkRequest);
}
```

- Parameter `updateNetworkRequest` is of type [UpdateNetworkRequest](./RingCentral.Net/Definitions/UpdateNetworkRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).POST(createNetworkRequest);
}
```

- Parameter `createNetworkRequest` is of type [CreateNetworkRequest](./RingCentral.Net/Definitions/CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.


## Get Network

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).PUT(updateNetworkRequest);
}
```

- Parameter `updateNetworkRequest` is of type [UpdateNetworkRequest](./RingCentral.Net/Definitions/UpdateNetworkRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.


## Delete Network

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().POST(createSwitchInfo);
}
```

- Parameter `createSwitchInfo` is of type [CreateSwitchInfo](./RingCentral.Net/Definitions/CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Get Switch

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().PUT(updateSwitchInfo);
}
```

- Parameter `updateSwitchInfo` is of type [UpdateSwitchInfo](./RingCentral.Net/Definitions/UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().POST(createMultipleSwitchesRequest);
}
```

- Parameter `createMultipleSwitchesRequest` is of type [CreateMultipleSwitchesRequest](./RingCentral.Net/Definitions/CreateMultipleSwitchesRequest.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./RingCentral.Net/Definitions/CreateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API Explorer.


## Update Multiple Switches

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().POST(updateMultipleSwitchesRequest);
}
```

- Parameter `updateMultipleSwitchesRequest` is of type [UpdateMultipleSwitchesRequest](./RingCentral.Net/Definitions/UpdateMultipleSwitchesRequest.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./RingCentral.Net/Definitions/UpdateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API Explorer.


## Validate Multiple Switches

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().POST(validateMultipleSwitchesRequest);
}
```

- Parameter `validateMultipleSwitchesRequest` is of type [ValidateMultipleSwitchesRequest](./RingCentral.Net/Definitions/ValidateMultipleSwitchesRequest.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./RingCentral.Net/Definitions/ValidateMultipleSwitchesResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API Explorer.


## Get Account Switch List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).POST(createSwitchInfo);
}
```

- Parameter `createSwitchInfo` is of type [CreateSwitchInfo](./RingCentral.Net/Definitions/CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.


## Get Switch

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).PUT(updateSwitchInfo);
}
```

- Parameter `updateSwitchInfo` is of type [UpdateSwitchInfo](./RingCentral.Net/Definitions/UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.


## Delete Switch

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().POST(bulkAssignAutomaticaLocationUpdatesUsers);
}
```

- Parameter `bulkAssignAutomaticaLocationUpdatesUsers` is of type [BulkAssignAutomaticaLocationUpdatesUsers](./RingCentral.Net/Definitions/BulkAssignAutomaticaLocationUpdatesUsers.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.


## Get Wireless Point List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().POST(createWirelessPoint);
}
```

- Parameter `createWirelessPoint` is of type [CreateWirelessPoint](./RingCentral.Net/Definitions/CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Get Wireless Point

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().PUT(updateWirelessPoint);
}
```

- Parameter `updateWirelessPoint` is of type [UpdateWirelessPoint](./RingCentral.Net/Definitions/UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().POST(createMultipleWirelessPointsRequest);
}
```

- Parameter `createMultipleWirelessPointsRequest` is of type [CreateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsRequest.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in API Explorer.


## Update Multiple Wireless Points

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().POST(updateMultipleWirelessPointsRequest);
}
```

- Parameter `updateMultipleWirelessPointsRequest` is of type [UpdateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsRequest.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in API Explorer.


## Validate Multiple Wireless Points

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().POST(validateMultipleWirelessPointsRequest);
}
```

- Parameter `validateMultipleWirelessPointsRequest` is of type [ValidateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsRequest.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints) in API Explorer.


## Get Wireless Point List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).POST(createWirelessPoint);
}
```

- Parameter `createWirelessPoint` is of type [CreateWirelessPoint](./RingCentral.Net/Definitions/CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.


## Get Wireless Point

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).PUT(updateWirelessPoint);
}
```

- Parameter `updateWirelessPoint` is of type [UpdateWirelessPoint](./RingCentral.Net/Definitions/UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.


## Delete Wireless Point

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().POST(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().PUT(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Add Emergency Location

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).POST(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.


## Get Emergency Location List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/emergency-locations/{locationId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ConfigureEmergencyMaps</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).PUT(emergencyLocationInfoRequest);
}
```

- Parameter `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.


## Get Extension List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AddRemoveUsers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().POST(extensionCreationRequest);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo OR EditUserCredentials</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().PUT(extensionUpdateRequest);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AddRemoveUsers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AddRemoveUsers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).POST(extensionCreationRequest);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.


## Get Extension

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo OR EditUserCredentials</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PUT(extensionUpdateRequest);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.


## Delete Extension

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AddRemoveUsers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().POST(personalContactRequest, createContactParameters);
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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().PUT(personalContactRequest, updateContactParameters);
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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).POST(personalContactRequest, createContactParameters);
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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).PUT(personalContactRequest, updateContactParameters);
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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().POST(createAnsweringRuleRequest);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().PUT(updateAnsweringRuleRequest);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).POST(createAnsweringRuleRequest);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-createAnsweringRule) in API Explorer.


## Get Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).PUT(updateAnsweringRuleRequest);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Rule-Management-updateAnsweringRule) in API Explorer.


## Delete Call Handling Rule

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().PUT(userBusinessHoursUpdateRequest);
}
```

- Parameter `userBusinessHoursUpdateRequest` is of type [UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/UserBusinessHoursUpdateRequest.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./RingCentral.Net/Definitions/UserBusinessHoursUpdateResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.


## Get User Call Log Records

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>EditCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>EditCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallLog</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallLog</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queues</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Accounts</code></td></tr><tr><td>User Permission Required</td><td><code>JoinLeaveCallQueue</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().PUT(userCallQueues);
}
```

- Parameter `userCallQueues` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- `result` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.


## Get Caller Blocking Settings

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PUT(callerBlockingSettingsUpdate);
}
```

- Parameter `callerBlockingSettingsUpdate` is of type [CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/CallerBlockingSettingsUpdate.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API Explorer.


## Get Blocked/Allowed Phone Numbers

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().POST(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().PUT(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Phone Numbers

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).POST(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.


## Get Blocked/Allowed Number

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditBlockedNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).PUT(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.


## Get Extension Caller ID

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallerIDSettings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditCallerIDSettings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().PUT(extensionCallerIdInfo);
}
```

- Parameter `extensionCallerIdInfo` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtensionCallerId) in API Explorer.


## Create Internal Text Message

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>InternalMessages</code></td></tr><tr><td>User Permission Required</td><td><code>InternalSMS</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().POST(createInternalTextMessageRequest);
}
```

- Parameter `createInternalTextMessageRequest` is of type [CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/CreateInternalTextMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Pager-Messages-createInternalTextMessage) in API Explorer.


## Get User Conferencing Settings

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>OrganizeConference</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>OrganizeConference</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().PUT(updateConferencingInfoRequest);
}
```

- Parameter `updateConferencingInfoRequest` is of type [UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/UpdateConferencingInfoRequest.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.


## Get Extension Device List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/device</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserDevices</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadContacts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPersonalContacts</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Contacts</code></td></tr><tr><td>User Permission Required</td><td><code>EditPersonalContacts</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().PUT(favoriteCollection);
}
```

- Parameter `favoriteCollection` is of type [FavoriteCollection](./RingCentral.Net/Definitions/FavoriteCollection.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API Explorer.


## Create Fax Message

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Faxes</code></td></tr><tr><td>User Permission Required</td><td><code>OutboundFaxes</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/features</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().POST(createForwardingNumberRequest);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().PUT(updateForwardingNumberRequest);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).POST(createForwardingNumberRequest);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.


## Get Forwarding Number

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).PUT(updateForwardingNumberRequest);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.


## Delete Forwarding Number

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserForwardingFlipNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserAnsweringRules</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().POST(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get Meeting Info

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().PUT(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>MeetingsRecordings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().PATCH(meetingServiceInfoRequest);
}
```

- Parameter `meetingServiceInfoRequest` is of type [MeetingServiceInfoRequest](./RingCentral.Net/Definitions/MeetingServiceInfoRequest.cs)
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-updateMeetingServiceInfo) in API Explorer.


## Get Scheduled Meetings

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).POST(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.


## Get Meeting Info

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).PUT(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.


## Delete Meeting

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>Meetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditMessages</code></td></tr><tr><td>User Permission Required</td><td><code>EditMessages</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().PUT(updateMessageRequest, updateMessageParameters);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- Parameter `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditMessages</code></td></tr><tr><td>User Permission Required</td><td><code>EditMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditMessages</code></td></tr><tr><td>User Permission Required</td><td><code>EditMessages</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).PUT(updateMessageRequest, updateMessageParameters);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- Parameter `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.


## Delete Message

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditMessages</code></td></tr><tr><td>User Permission Required</td><td><code>EditMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessageContent</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessages</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/mms</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>SMS</code></td></tr><tr><td>User Permission Required</td><td><code>OutboundSMS</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().POST(createMmsMessage);
}
```

- Parameter `createMmsMessage` is of type [CreateMMSMessage](./RingCentral.Net/Definitions/CreateMMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#MMS-createMMS) in API Explorer.


## Get Notification Settings

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadMessagesNotificationsSettings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditMessagesNotificationsSettings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().PUT(notificationSettingsUpdateRequest);
}
```

- Parameter `notificationSettingsUpdateRequest` is of type [NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/NotificationSettingsUpdateRequest.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateNotificationSettings) in API Explorer.


## Get Extension Phone Number List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserPhoneNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadPresence</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPresenceStatus</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditPresence</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().PUT(presenceInfoResource);
}
```

- Parameter `presenceInfoResource` is of type [PresenceInfoResource](./RingCentral.Net/Definitions/PresenceInfoResource.cs)
- `result` is of type [PresenceInfoResponse](./RingCentral.Net/Definitions/PresenceInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.


## Get User Profile Image

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditExtensions</code></td></tr><tr><td>User Permission Required</td><td><code>EditUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadExtensions</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().POST(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).POST(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().POST(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).POST(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.


## Get RingOut Call Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>RingOut</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>SMS</code></td></tr><tr><td>User Permission Required</td><td><code>OutboundSMS</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().POST(createSmsMessage);
}
```

- Parameter `createSmsMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.


## Get Unified Presence

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadPresence</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPresenceStatus</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditPresence</code></td></tr><tr><td>User Permission Required</td><td><code>EditPresenceStatus</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().PATCH(updateUnifiedPresence);
}
```

- Parameter `updateUnifiedPresence` is of type [UpdateUnifiedPresence](./RingCentral.Net/Definitions/UpdateUnifiedPresence.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.


## Create Company Greeting

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/greeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().POST(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRMenu) in API Explorer.


## Get IVR Menu

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().PUT(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRMenu) in API Explorer.


## Create IVR Menu

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).POST(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-createIVRMenu) in API Explorer.


## Get IVR Menu

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AutoReceptionist</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).PUT(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRMenu) in API Explorer.


## Create IVR Prompts

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().PUT(updateIvrPromptRequest);
}
```

- Parameter `updateIvrPromptRequest` is of type [UpdateIVRPromptRequest](./RingCentral.Net/Definitions/UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRPrompt) in API Explorer.


## Create IVR Prompts

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>EditCompanyGreetings</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).PUT(updateIvrPromptRequest);
}
```

- Parameter `updateIvrPromptRequest` is of type [UpdateIVRPromptRequest](./RingCentral.Net/Definitions/UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Routing-updateIVRPrompt) in API Explorer.


## Get IVR Prompt Content

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyGreetings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/meeting-recordings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Meetings</code></td></tr><tr><td>User Permission Required</td><td><code>MeetingsRecordings</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-configuration</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AccountAdministration</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-configuration</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>AccountAdministration</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().PUT(messageStoreConfiguration);
}
```

- Parameter `messageStoreConfiguration` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API Explorer.


## Create Message Store Report

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().POST(createMessageStoreReportRequest);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).POST(createMessageStoreReportRequest);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.


## Get Message Store Report Task

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadMessages</code></td></tr><tr><td>User Permission Required</td><td><code>Users</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>Groups</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().POST(editPagingGroupRequest);
}
```

- Parameter `editPagingGroupRequest` is of type [EditPagingGroupRequest](./RingCentral.Net/Definitions/EditPagingGroupRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices) in API Explorer.


## Get Paging Group Devices

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyDevices</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadUserInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/phone-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyPhoneNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyPhoneNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/phone-number</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyPhoneNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyPhoneNumbers</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/presence</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadPresence</code></td></tr><tr><td>User Permission Required</td><td><code>ReadPresenceStatus</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/recording/{recordingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallRecording</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallRecording</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/recording/{recordingId}/content</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>ReadCallRecording</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCallRecording</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/service-info</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadServicePlanInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/call-out</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().POST(makeCallOutRequest);
}
```

- Parameter `makeCallOutRequest` is of type [MakeCallOutRequest](./RingCentral.Net/Definitions/MakeCallOutRequest.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallOutCallSession) in API Explorer.


## Get Call Session Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).PATCH(partyUpdateRequest);
}
```

- Parameter `partyUpdateRequest` is of type [PartyUpdateRequest](./RingCentral.Net/Definitions/PartyUpdateRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.


## Answer Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().POST(answerTarget);
}
```

- Parameter `answerTarget` is of type [AnswerTarget](./RingCentral.Net/Definitions/AnswerTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-answerCallParty) in API Explorer.


## Call Flip on Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().POST(callPartyFlip);
}
```

- Parameter `callPartyFlip` is of type [CallPartyFlip](./RingCentral.Net/Definitions/CallPartyFlip.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callFlipParty) in API Explorer.


## Forward Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().POST(forwardTarget);
}
```

- Parameter `forwardTarget` is of type [ForwardTarget](./RingCentral.Net/Definitions/ForwardTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-forwardCallParty) in API Explorer.


## Hold Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().POST(ignoreRequestBody);
}
```

- Parameter `ignoreRequestBody` is of type [IgnoreRequestBody](./RingCentral.Net/Definitions/IgnoreRequestBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.


## Call Park

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().POST(pickupTarget);
}
```

- Parameter `pickupTarget` is of type [PickupTarget](./RingCentral.Net/Definitions/PickupTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pickupCallParty) in API Explorer.


## Create Recording

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().PATCH(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Create Recording

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).PATCH(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.


## Reject Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().POST(callPartyReply);
}
```

- Parameter `callPartyReply` is of type [CallPartyReply](./RingCentral.Net/Definitions/CallPartyReply.cs)
- `result` is of type [ReplyParty](./RingCentral.Net/Definitions/ReplyParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-replyParty) in API Explorer.


## Supervise Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().POST(partySuperviseRequest);
}
```

- Parameter `partySuperviseRequest` is of type [PartySuperviseRequest](./RingCentral.Net/Definitions/PartySuperviseRequest.cs)
- `result` is of type [PartySuperviseResponse](./RingCentral.Net/Definitions/PartySuperviseResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallParty) in API Explorer.


## Transfer Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().POST(transferTarget);
}
```

- Parameter `transferTarget` is of type [TransferTarget](./RingCentral.Net/Definitions/TransferTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-transferCallParty) in API Explorer.


## Unhold Call Party

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>CallControl</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().POST(superviseCallSessionRequest);
}
```

- Parameter `superviseCallSessionRequest` is of type [SuperviseCallSessionRequest](./RingCentral.Net/Definitions/SuperviseCallSessionRequest.cs)
- `result` is of type [SuperviseCallSession](./RingCentral.Net/Definitions/SuperviseCallSession.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.


## Get User Template List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/templates</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/templates/{templateId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/templates</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/account/{accountId}/templates/{templateId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>ReadCompanyInfo</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/client-info/sip-provision</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>VoipCalling</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().POST(createSipRegistrationRequest);
}
```

- Parameter `createSipRegistrationRequest` is of type [CreateSipRegistrationRequest](./RingCentral.Net/Definitions/CreateSipRegistrationRequest.cs)
- `result` is of type [CreateSipRegistrationResponse](./RingCentral.Net/Definitions/CreateSipRegistrationResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#SIP-createSIPRegistration) in API Explorer.


## Get Country List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/country</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/country/{countryId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/country</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/country/{countryId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/fax-cover-page</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/greeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/greeting/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/greeting</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/greeting/{greetingId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/language</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/language/{languageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/language</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/language/{languageId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/location</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/state</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/state/{stateId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/state</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/state/{stateId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/timezone</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/timezone/{timezoneId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/timezone</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/dictionary/timezone/{timezoneId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().POST(glipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipCard) in API Explorer.


## Get Card

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards().PUT(glipMessageAttachmentInfoRequest);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipCard) in API Explorer.


## Delete Card

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).POST(glipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- `result` is of type [GlipMessageAttachmentInfo](./RingCentral.Net/Definitions/GlipMessageAttachmentInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipCard) in API Explorer.


## Get Card

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).PUT(glipMessageAttachmentInfoRequest);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-updateGlipCard) in API Explorer.


## Delete Card

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/cards/{cardId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/favorite</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/notes</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().POST(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNote) in API Explorer.


## Get Chat Notes

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/notes</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().POST(glipPostPostBody);
}
```

- Parameter `glipPostPostBody` is of type [GlipPostPostBody](./RingCentral.Net/Definitions/GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().PATCH(glipPatchPostBody);
}
```

- Parameter `glipPatchPostBody` is of type [GlipPatchPostBody](./RingCentral.Net/Definitions/GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).POST(glipPostPostBody);
}
```

- Parameter `glipPostPostBody` is of type [GlipPostPostBody](./RingCentral.Net/Definitions/GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.


## Get Post

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).PATCH(glipPatchPostBody);
}
```

- Parameter `glipPatchPostBody` is of type [GlipPatchPostBody](./RingCentral.Net/Definitions/GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.


## Delete Post

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/posts/{postId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/read</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>GlipInternal</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/tasks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/tasks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().POST(glipCreateTask);
}
```

- Parameter `glipCreateTask` is of type [GlipCreateTask](./RingCentral.Net/Definitions/GlipCreateTask.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTask) in API Explorer.


## Remove Chat from Favorites

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/unfavorite</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/chats/{chatId}/unread</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>GlipInternal</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/companies/{companyId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().POST(createGlipConversationRequest);
}
```

- Parameter `createGlipConversationRequest` is of type [CreateGlipConversationRequest](./RingCentral.Net/Definitions/CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).POST(createGlipConversationRequest);
}
```

- Parameter `createGlipConversationRequest` is of type [CreateGlipConversationRequest](./RingCentral.Net/Definitions/CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.


## Get Conversation

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/conversations/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().POST(createDataExportTaskRequest);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).POST(createDataExportTaskRequest);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.


## Get Data Export Task List

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/data-export/{taskId}/datasets/{datasetId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().POST(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().PUT(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).POST(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.


## Get Event

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).PUT(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.


## Delete Event

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/events/{eventId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/everyone</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/everyone</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().PATCH(updateGlipEveryoneRequest);
}
```

- Parameter `updateGlipEveryoneRequest` is of type [UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/UpdateGlipEveryoneRequest.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryone) in API Explorer.


## Get Favorite Chats

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/favorites</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups().POST(glipCreateGroup);
}
```

- Parameter `glipCreateGroup` is of type [GlipCreateGroup](./RingCentral.Net/Definitions/GlipCreateGroup.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-createGlipGroup) in API Explorer.


## Get Group

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).POST(glipCreateGroup);
}
```

- Parameter `glipCreateGroup` is of type [GlipCreateGroup](./RingCentral.Net/Definitions/GlipCreateGroup.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-createGlipGroup) in API Explorer.


## Get Group

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/bulk-assign</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).BulkAssign().POST(editGroupRequest);
}
```

- Parameter `editGroupRequest` is of type [EditGroupRequest](./RingCentral.Net/Definitions/EditGroupRequest.cs)
- `result` is of type [GlipGroupInfo](./RingCentral.Net/Definitions/GlipGroupInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Chats-assignGlipGroupMembers) in API Explorer.


## Create Event by Group ID

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().POST(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventbyGroupId) in API Explorer.


## Get Group Events

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/events</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().POST(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipGroupPost) in API Explorer.


## Update Post

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/webhooks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/groups/{groupId}/webhooks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).PATCH(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNote) in API Explorer.


## Delete Note

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}/lock</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}/publish</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/notes/{noteId}/unlock</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/persons/{personId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/posts</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Posts().POST(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createPost) in API Explorer.


## Get Preferences

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/preferences</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/recent/chats</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/tasks/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/tasks/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).PATCH(glipUpdateTask);
}
```

- Parameter `glipUpdateTask` is of type [GlipUpdateTask](./RingCentral.Net/Definitions/GlipUpdateTask.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTask) in API Explorer.


## Delete Task

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/tasks/{taskId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/tasks/{taskId}/complete</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Complete().POST(glipCompleteTask);
}
```

- Parameter `glipCompleteTask` is of type [GlipCompleteTask](./RingCentral.Net/Definitions/GlipCompleteTask.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTask) in API Explorer.


## Get Teams

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().POST(glipPostTeamBody);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().PATCH(glipPatchTeamBody);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).POST(glipPostTeamBody);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.


## Get Team

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).PATCH(glipPatchTeamBody);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.


## Delete Team

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/add</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().POST(glipPostMembersListBody);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembers) in API Explorer.


## Archive Team

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/archive</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/join</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/leave</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/remove</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().POST(glipPostMembersIdsListBody);
}
```

- Parameter `glipPostMembersIdsListBody` is of type [GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/GlipPostMembersIdsListBody.cs)
- `result` is an empty string
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembers) in API Explorer.


## Unarchive Team

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/teams/{chatId}/unarchive</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}/activate</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/glip/webhooks/{webhookId}/suspend</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>Glip</code></td></tr><tr><td>User Permission Required</td><td><code>Glip</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/number-parser/parse</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().POST(parsePhoneNumberRequest, parsePhoneNumberParameters);
}
```

- Parameter `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./RingCentral.Net/Definitions/ParsePhoneNumberRequest.cs)
- Parameter `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- `result` is of type [ParsePhoneNumberResponse](./RingCentral.Net/Definitions/ParsePhoneNumberResponse.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-parsePhoneNumber) in API Explorer.


## Get Service Status

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/status</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().POST(createSubscriptionRequest);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().PUT(modifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).POST(createSubscriptionRequest);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.


## Get Subscription

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).PUT(modifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.


## Cancel Subscription

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Medium</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/restapi/v1.0/subscription/{subscriptionId}/renew</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/ServiceProviderConfig</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().POST(createUser);
}
```

- Parameter `createUser` is of type [CreateUser](./RingCentral.Net/Definitions/CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Get User

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().PUT(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().PATCH(userPatch);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Search/List Users

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/.search</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DotSearch().POST(searchRequest);
}
```

- Parameter `searchRequest` is of type [SearchRequest](./RingCentral.Net/Definitions/SearchRequest.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaPost2) in API Explorer.


## Search/List Users

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>POST</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).POST(createUser);
}
```

- Parameter `createUser` is of type [CreateUser](./RingCentral.Net/Definitions/CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.


## Get User

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Light</code></td></tr><tr><td>App Permission Required</td><td><code>ReadAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PUT</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).PUT(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.


## Delete User

<table><tr><td>HTTP Method</td><td><code>DELETE</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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

<table><tr><td>HTTP Method</td><td><code>PATCH</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/Users/{id}</code></td></tr><tr><td>Rate Limit Group</td><td><code>Heavy</code></td></tr><tr><td>App Permission Required</td><td><code>EditAccounts</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).PATCH(userPatch);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)
- Parameter `version` is optional with default value `v2`

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.


## Check Health

<table><tr><td>HTTP Method</td><td><code>GET</code></td></tr><tr><td>Endpoint</td><td><code>/scim/v2/health</code></td></tr><tr><td>Rate Limit Group</td><td><code>NoThrottling</code></td></tr><tr><td>App Permission Required</td><td><code>N/A</code></td></tr><tr><td>User Permission Required</td><td><code>N/A</code></td></tr></table>

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