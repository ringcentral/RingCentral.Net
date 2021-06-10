# RingCentral.Net SDK Code Samples

## readAPIVersions
Get API Versions

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
    var result = await rc.Restapi().List();
}
```

- `result` is of type [GetVersionsResponse](./RingCentral.Net/Definitions/GetVersionsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersions) in API Explorer.

## readAPIVersion
Get Version Info

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
    var result = await rc.Restapi(apiVersion).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetVersionResponse](./RingCentral.Net/Definitions/GetVersionResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.

## searchViaGet2
Search/List Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Users`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().List(searchViaGet2Parameters);
}
```

- Parameter `version` is optional with default value `v2`
- `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaGet2) in API Explorer.

## createUser2
Create User

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/{version}/Users`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().Post(createUser);
}
```

- Parameter `version` is optional with default value `v2`
- `createUser` is of type [CreateUser](./RingCentral.Net/Definitions/CreateUser.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-createUser2) in API Explorer.

## readUser2
Get User

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Users/{id}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Get();
}
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readUser2) in API Explorer.

## replaceUser2
Update/Replace User

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/scim/{version}/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Put(user);
}
```

- Parameter `version` is optional with default value `v2`
- `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-replaceUser2) in API Explorer.

## deleteUser2
Delete User

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/scim/{version}/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Delete();
}
```

- Parameter `version` is optional with default value `v2`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-deleteUser2) in API Explorer.

## patchUser2
Update/Patch User

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/scim/{version}/Users/{id}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users(id).Patch(userPatch);
}
```

- Parameter `version` is optional with default value `v2`
- `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- `result` is of type [UserResponse](./RingCentral.Net/Definitions/UserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-patchUser2) in API Explorer.

## authorize
Authorize

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/oauth/authorize`
Rate Limit Group|`undefined`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi().Oauth().Authorize().Post(authorizeRequest);
}
```

- `authorizeRequest` is of type [AuthorizeRequest](./RingCentral.Net/Definitions/AuthorizeRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-authorize) in API Explorer.

## getToken
Get Token

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
    var result = await rc.Restapi().Oauth().Token().Post(getTokenRequest);
}
```

- `getTokenRequest` is of type [GetTokenRequest](./RingCentral.Net/Definitions/GetTokenRequest.cs)
- `result` is of type [TokenInfo](./RingCentral.Net/Definitions/TokenInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-getToken) in API Explorer.

## readAccountInfo
Get Account Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [GetAccountInfoResponse](./RingCentral.Net/Definitions/GetAccountInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountInfo) in API Explorer.

## revokeToken
Revoke Token

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
    var result = await rc.Restapi().Oauth().Revoke().Post(revokeTokenRequest);
}
```

- `revokeTokenRequest` is of type [RevokeTokenRequest](./RingCentral.Net/Definitions/RevokeTokenRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth-2.0-revokeToken) in API Explorer.

## readCompanyCallLog
Get Company Call Log Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().List(readCompanyCallLogParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCompanyCallLogParameters` is of type [ReadCompanyCallLogParameters](./RingCentral.Net/Definitions/ReadCompanyCallLogParameters.cs)
- `result` is of type [AccountCallLogResponse](./RingCentral.Net/Definitions/AccountCallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.

## readCompanyCallRecord
Get Company Call Log Record(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).Get(readCompanyCallRecordParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCompanyCallRecordParameters` is of type [ReadCompanyCallRecordParameters](./RingCentral.Net/Definitions/ReadCompanyCallRecordParameters.cs)
- `result` is of type [CompanyCallLogRecord](./RingCentral.Net/Definitions/CompanyCallLogRecord.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.

## readDevice
Get Device

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/device/{deviceId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Get(readDeviceParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readDeviceParameters` is of type [ReadDeviceParameters](./RingCentral.Net/Definitions/ReadDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-readDevice) in API Explorer.

## updateDevice
Update Device

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/device/{deviceId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Put(accountDeviceUpdate, updateDeviceParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `accountDeviceUpdate` is of type [AccountDeviceUpdate](./RingCentral.Net/Definitions/AccountDeviceUpdate.cs)
- `updateDeviceParameters` is of type [UpdateDeviceParameters](./RingCentral.Net/Definitions/UpdateDeviceParameters.cs)
- `result` is of type [GetDeviceInfoResponse](./RingCentral.Net/Definitions/GetDeviceInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.

## listExtensions
Get Extension List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().List(listExtensionsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- `result` is of type [GetExtensionListResponse](./RingCentral.Net/Definitions/GetExtensionListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listExtensions) in API Explorer.

## createExtension
Create Extension

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`AddRemoveUsers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Post(extensionCreationRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./RingCentral.Net/Definitions/ExtensionCreationResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-createExtension) in API Explorer.

## readExtension
Get Extension

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtension) in API Explorer.

## updateExtension
Update Extension

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserInfo OR EditUserCredentials`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./RingCentral.Net/Definitions/GetExtensionInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.

## deleteExtension
Delete Extension

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`AddRemoveUsers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Delete(deleteExtensionParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteExtensionParameters` is of type [DeleteExtensionParameters](./RingCentral.Net/Definitions/DeleteExtensionParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteExtension) in API Explorer.

## createCompanyGreeting
Create Company Greeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/greeting`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().Post(createCompanyGreetingRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCompanyGreetingRequest` is of type [CreateCompanyGreetingRequest](./RingCentral.Net/Definitions/CreateCompanyGreetingRequest.cs)
- `result` is of type [CustomCompanyGreetingInfo](./RingCentral.Net/Definitions/CustomCompanyGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-createCompanyGreeting) in API Explorer.

## createIVRMenu
Create IVR Menu

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-menus`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Post(iVRMenuInfo);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `iVRMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-createIVRMenu) in API Explorer.

## readIVRMenu
Get IVR Menu

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRMenu) in API Explorer.

## updateIVRMenu
Update IVR Menu

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-menus/{ivrMenuId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`AutoReceptionist`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Put(iVRMenuInfo);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `iVRMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-updateIVRMenu) in API Explorer.

## readAccountPresence
Get User Presence Status List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/presence`
Rate Limit Group|`Heavy`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Presence().Get(readAccountPresenceParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readAccountPresenceParameters` is of type [ReadAccountPresenceParameters](./RingCentral.Net/Definitions/ReadAccountPresenceParameters.cs)
- `result` is of type [AccountPresenceInfo](./RingCentral.Net/Definitions/AccountPresenceInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readAccountPresence) in API Explorer.

## readCallRecording
Get Call Recording

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/recording/{recordingId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallRecording`
User Permission|`ReadCallRecording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [GetCallRecordingResponse](./RingCentral.Net/Definitions/GetCallRecordingResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecording) in API Explorer.

## listUserTemplates
Get User Template List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/templates`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().List(listUserTemplatesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./RingCentral.Net/Definitions/ListUserTemplatesParameters.cs)
- `result` is of type [UserTemplates](./RingCentral.Net/Definitions/UserTemplates.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-listUserTemplates) in API Explorer.

## readUserTemplate
Get User Template

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/templates/{templateId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [TemplateInfo](./RingCentral.Net/Definitions/TemplateInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.

## listStates
Get States List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/state`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State().List(listStatesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- `result` is of type [GetStateListResponse](./RingCentral.Net/Definitions/GetStateListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listStates) in API Explorer.

## readState
Get State

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/state/{stateId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetStateInfoResponse](./RingCentral.Net/Definitions/GetStateInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.

## listGlipChats
Get Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats().List(listGlipChatsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- `result` is of type [GlipChatsList](./RingCentral.Net/Definitions/GlipChatsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChats) in API Explorer.

## readGlipChat
Get Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipChatInfo](./RingCentral.Net/Definitions/GlipChatInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChat) in API Explorer.

## listChatNotes
Get Chat Notes

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/notes`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Get(listChatNotesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listChatNotesParameters` is of type [ListChatNotesParameters](./RingCentral.Net/Definitions/ListChatNotesParameters.cs)
- `result` is of type [GlipNotesInfo](./RingCentral.Net/Definitions/GlipNotesInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-listChatNotes) in API Explorer.

## createChatNote
Create Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/notes`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Notes().Post(glipNoteCreate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNote) in API Explorer.

## readGlipPosts
Get Posts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().List(readGlipPostsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `readGlipPostsParameters` is of type [ReadGlipPostsParameters](./RingCentral.Net/Definitions/ReadGlipPostsParameters.cs)
- `result` is of type [GlipPostsList](./RingCentral.Net/Definitions/GlipPostsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPosts) in API Explorer.

## createGlipPost
Create Post

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts().Post(glipPostPostBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPostPostBody` is of type [GlipPostPostBody](./RingCentral.Net/Definitions/GlipPostPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPost) in API Explorer.

## readGlipPost
Get Post

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPost) in API Explorer.

## deleteGlipPost
Delete Post

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPost) in API Explorer.

## patchGlipPost
Update Post

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Posts(postId).Patch(glipPatchPostBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPatchPostBody` is of type [GlipPatchPostBody](./RingCentral.Net/Definitions/GlipPatchPostBody.cs)
- `result` is of type [GlipPostInfo](./RingCentral.Net/Definitions/GlipPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPost) in API Explorer.

## markChatRead
Mark Chat as Read

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/read`
Rate Limit Group|`Medium`
App Permission|`GlipInternal`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Read().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatRead) in API Explorer.

## listChatTasks
Get Chat Tasks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/tasks`
Rate Limit Group|`Heavy`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Get(listChatTasksParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listChatTasksParameters` is of type [ListChatTasksParameters](./RingCentral.Net/Definitions/ListChatTasksParameters.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-listChatTasks) in API Explorer.

## createTask
Create Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/tasks`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Tasks().Post(glipCreateTask);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipCreateTask` is of type [GlipCreateTask](./RingCentral.Net/Definitions/GlipCreateTask.cs)
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTask) in API Explorer.

## readGlipCompany
Get Company Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/companies/{companyId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Companies(companyId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipCompany](./RingCentral.Net/Definitions/GlipCompany.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipCompany) in API Explorer.

## listDataExportTasks
Get Data Export Task List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/data-export`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().List(listDataExportTasksParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listDataExportTasksParameters` is of type [ListDataExportTasksParameters](./RingCentral.Net/Definitions/ListDataExportTasksParameters.cs)
- `result` is of type [DataExportTaskList](./RingCentral.Net/Definitions/DataExportTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-listDataExportTasks) in API Explorer.

## createDataExportTask
Create Data Export Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/data-export`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport().Post(createDataExportTaskRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-createDataExportTask) in API Explorer.

## readDataExportTask
Get Data Export Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/data-export/{taskId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [DataExportTask](./RingCentral.Net/Definitions/DataExportTask.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTask) in API Explorer.

## readGlipEveryone
Get Everyone Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/everyone`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipEveryone) in API Explorer.

## patchGlipEveryone
Update Everyone Сhat

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/glip/everyone`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Patch(updateGlipEveryoneRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `updateGlipEveryoneRequest` is of type [UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/UpdateGlipEveryoneRequest.cs)
- `result` is of type [GlipEveryoneInfo](./RingCentral.Net/Definitions/GlipEveryoneInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryone) in API Explorer.

## listFavoriteChats
Get Favorite Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/favorites`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Favorites().Get(listFavoriteChatsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listFavoriteChatsParameters` is of type [ListFavoriteChatsParameters](./RingCentral.Net/Definitions/ListFavoriteChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listFavoriteChats) in API Explorer.

## readUserNote
Get Note

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetGlipNoteInfo](./RingCentral.Net/Definitions/GetGlipNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-readUserNote) in API Explorer.

## deleteNote
Delete Note

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-deleteNote) in API Explorer.

## patchNote
Update Note

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Patch(glipNoteCreate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- `result` is of type [GlipNoteInfo](./RingCentral.Net/Definitions/GlipNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNote) in API Explorer.

## readTask
Get Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipTaskInfo](./RingCentral.Net/Definitions/GlipTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-readTask) in API Explorer.

## deleteTask
Delete Task

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-deleteTask) in API Explorer.

## patchTask
Patch Task

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/glip/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Patch(glipUpdateTask);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipUpdateTask` is of type [GlipUpdateTask](./RingCentral.Net/Definitions/GlipUpdateTask.cs)
- `result` is of type [GlipTaskList](./RingCentral.Net/Definitions/GlipTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTask) in API Explorer.

## listGlipTeams
Get Teams

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/teams`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().List(listGlipTeamsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- `result` is of type [GlipTeamsList](./RingCentral.Net/Definitions/GlipTeamsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeams) in API Explorer.

## createGlipTeam
Create Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams().Post(glipPostTeamBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeam) in API Explorer.

## readGlipTeam
Get Team

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeam) in API Explorer.

## deleteGlipTeam
Delete Team

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeam) in API Explorer.

## patchGlipTeam
Update Team

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Patch(glipPatchTeamBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- `result` is of type [GlipTeamInfo](./RingCentral.Net/Definitions/GlipTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeam) in API Explorer.

## readGlipEvents
Get User Events List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().List(readGlipEventsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `readGlipEventsParameters` is of type [ReadGlipEventsParameters](./RingCentral.Net/Definitions/ReadGlipEventsParameters.cs)
- `result` is of type [GlipEventsInfo](./RingCentral.Net/Definitions/GlipEventsInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEvents) in API Explorer.

## createEvent
Create Event

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events().Post(glipEventCreate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEvent) in API Explorer.

## readEvent
Get Event

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEvent) in API Explorer.

## updateEvent
Update Event

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Put(glipEventCreate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEvent) in API Explorer.

## deleteEvent
Delete Event

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEvent) in API Explorer.

## lockNote
Lock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}/lock`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Lock().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-lockNote) in API Explorer.

## readGlipPerson
Get Person

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/persons/{personId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Persons(personId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipPersonInfo](./RingCentral.Net/Definitions/GlipPersonInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPerson) in API Explorer.

## addGlipTeamMembers
Add Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/add`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().Post(glipPostMembersListBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembers) in API Explorer.

## removeGlipTeamMembers
Remove Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/remove`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().Post(glipPostMembersIdsListBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipPostMembersIdsListBody` is of type [GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/GlipPostMembersIdsListBody.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembers) in API Explorer.

## listGlipWebhooks
Get Webhooks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipWebhooks) in API Explorer.

## readGlipWebhook
Get Webhook

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-readGlipWebhook) in API Explorer.

## deleteGlipWebhook
Delete Webhook

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/glip/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-deleteGlipWebhook) in API Explorer.

## listSubscriptions
Get Subscription List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/subscription`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [RecordsCollectionResourceSubscriptionResponse](./RingCentral.Net/Definitions/RecordsCollectionResourceSubscriptionResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-listSubscriptions) in API Explorer.

## createSubscription
Create Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/subscription`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription().Post(createSubscriptionRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-createSubscription) in API Explorer.

## readSubscription
Get Subscription

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/subscription/{subscriptionId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-readSubscription) in API Explorer.

## updateSubscription
Update Subscription

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/subscription/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Put(modifySubscriptionRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-updateSubscription) in API Explorer.

## deleteSubscription
Cancel Subscription

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/subscription/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.

## searchViaPost2
Search/List Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/{version}/Users/dotSearch`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).Users().DotSearch().Post(searchRequest);
}
```

- Parameter `version` is optional with default value `v2`
- `searchRequest` is of type [SearchRequest](./RingCentral.Net/Definitions/SearchRequest.cs)
- `result` is of type [UserSearchResponse](./RingCentral.Net/Definitions/UserSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-searchViaPost2) in API Explorer.

## joinGlipTeam
Join Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/join`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Join().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-joinGlipTeam) in API Explorer.

## readGlipPreferences
Get Preferences

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/preferences`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Preferences().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipPreferencesInfo](./RingCentral.Net/Definitions/GlipPreferencesInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Profile-readGlipPreferences) in API Explorer.

## leaveGlipTeam
Leave Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/leave`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Leave().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-leaveGlipTeam) in API Explorer.

## createA2PSMS
Send A2P SMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/batch`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Batch().Post(createSMSMessageBatchRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createSMSMessageBatchRequest` is of type [CreateSMSMessageBatchRequest](./RingCentral.Net/Definitions/CreateSMSMessageBatchRequest.cs)
- `result` is of type [CreateMessageBatchResponse](./RingCentral.Net/Definitions/CreateMessageBatchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-createA2PSMS) in API Explorer.

## readA2PBatch
Get A2P SMS Batch

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/batch/{batchId}`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Batch(batchId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageBatchResponse](./RingCentral.Net/Definitions/MessageBatchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-readA2PBatch) in API Explorer.

## listA2PSMS
Get A2P SMS List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/messages`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Messages().List(listA2PSMSParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listA2PSMSParameters` is of type [ListA2PSMSParameters](./RingCentral.Net/Definitions/ListA2PSMSParameters.cs)
- `result` is of type [MessageListResponse](./RingCentral.Net/Definitions/MessageListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-listA2PSMS) in API Explorer.

## readA2PSMS
Get A2P SMS

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/messages/{messageId}`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Messages(messageId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageDetailsResponse](./RingCentral.Net/Definitions/MessageDetailsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-readA2PSMS) in API Explorer.

## readA2PSMSOptOuts
Get Opted Out Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/opt-outs`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().OptOuts().Get(readA2PSMSOptOutsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readA2PSMSOptOutsParameters` is of type [ReadA2PSMSOptOutsParameters](./RingCentral.Net/Definitions/ReadA2PSMSOptOutsParameters.cs)
- `result` is of type [OptOutListResponse](./RingCentral.Net/Definitions/OptOutListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-readA2PSMSOptOuts) in API Explorer.

## listCompanyActiveCalls
Get Company Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCompanyActiveCallsParameters` is of type [ListCompanyActiveCallsParameters](./RingCentral.Net/Definitions/ListCompanyActiveCallsParameters.cs)
- `result` is of type [CompanyActiveCallsResponse](./RingCentral.Net/Definitions/CompanyActiveCallsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listCompanyActiveCalls) in API Explorer.

## listCompanyAnsweringRules
Get Company Call Handling Rule List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().List(listCompanyAnsweringRulesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCompanyAnsweringRulesParameters` is of type [ListCompanyAnsweringRulesParameters](./RingCentral.Net/Definitions/ListCompanyAnsweringRulesParameters.cs)
- `result` is of type [CompanyAnsweringRuleList](./RingCentral.Net/Definitions/CompanyAnsweringRuleList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-listCompanyAnsweringRules) in API Explorer.

## createCompanyAnsweringRule
Create Company Call Handling Rule

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-createCompanyAnsweringRule) in API Explorer.

## readCompanyAnsweringRule
Get Company Call Handling Rule

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-readCompanyAnsweringRule) in API Explorer.

## updateCompanyAnsweringRule
Update Company Call Handling Rule

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./RingCentral.Net/Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateCompanyAnsweringRule) in API Explorer.

## deleteCompanyAnsweringRule
Delete Company Call Handling Rule

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteCompanyAnsweringRule) in API Explorer.

## readAccountBusinessAddress
Get Account Business Address

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/business-address`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountBusinessAddress) in API Explorer.

## updateAccountBusinessAddress
Update Company Business Address

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/business-address`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `modifyAccountBusinessAddressRequest` is of type [ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/ModifyAccountBusinessAddressRequest.cs)
- `result` is of type [AccountBusinessAddressResource](./RingCentral.Net/Definitions/AccountBusinessAddressResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.

## readCompanyBusinessHours
Get Company Business Hours

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/business-hours`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readCompanyBusinessHours) in API Explorer.

## updateCompanyBusinessHours
Update Company Business Hours

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/business-hours`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyBusinessHoursUpdateRequest` is of type [CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/CompanyBusinessHoursUpdateRequest.cs)
- `result` is of type [CompanyBusinessHours](./RingCentral.Net/Definitions/CompanyBusinessHours.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateCompanyBusinessHours) in API Explorer.

## syncAccountCallLog
Sync Company Call Log

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-log-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLogSync().Get(syncAccountCallLogParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `syncAccountCallLogParameters` is of type [SyncAccountCallLogParameters](./RingCentral.Net/Definitions/SyncAccountCallLogParameters.cs)
- `result` is of type [AccountCallLogSyncResponse](./RingCentral.Net/Definitions/AccountCallLogSyncResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncAccountCallLog) in API Explorer.

## listCallQueues
Get Call Queue List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().List(listCallQueuesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallQueuesParameters` is of type [ListCallQueuesParameters](./RingCentral.Net/Definitions/ListCallQueuesParameters.cs)
- `result` is of type [CallQueues](./RingCentral.Net/Definitions/CallQueues.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueues) in API Explorer.

## readCallQueueInfo
Get Call Queue

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallQueueDetails](./RingCentral.Net/Definitions/CallQueueDetails.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-readCallQueueInfo) in API Explorer.

## updateCallQueueInfo
Update Call Queue

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Put(callQueueUpdateDetails);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueUpdateDetails` is of type [CallQueueUpdateDetails](./RingCentral.Net/Definitions/CallQueueUpdateDetails.cs)
- `result` is of type [CallQueueDetails](./RingCentral.Net/Definitions/CallQueueDetails.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateCallQueueInfo) in API Explorer.

## readCallRecordingSettings
Get Call Recording Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-readCallRecordingSettings) in API Explorer.

## updateCallRecordingSettings
Update Call Recording Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Put(callRecordingSettingsResource);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callRecordingSettingsResource` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- `result` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingSettings) in API Explorer.

## listCustomFields
Get Custom Field List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CustomFieldsResource](./RingCentral.Net/Definitions/CustomFieldsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-listCustomFields) in API Explorer.

## createCustomField
Create Custom Field

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Post(customFieldCreateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `customFieldCreateRequest` is of type [CustomFieldCreateRequest](./RingCentral.Net/Definitions/CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.

## updateCustomField
Update Сustom Field

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Put(customFieldUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `customFieldUpdateRequest` is of type [CustomFieldUpdateRequest](./RingCentral.Net/Definitions/CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldResource](./RingCentral.Net/Definitions/CustomFieldResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.

## deleteCustomField
Delete Custom Field

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-deleteCustomField) in API Explorer.

## listDirectoryEntries
Get Company Directory Entries

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/directory/entries`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-listDirectoryEntries) in API Explorer.

## readDirectoryEntry
Get Corporate Directory Entry

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/directory/entries/{entryId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [ContactResource](./RingCentral.Net/Definitions/ContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.

## readUserCallLog
Get User Call Log Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./RingCentral.Net/Definitions/ReadUserCallLogParameters.cs)
- `result` is of type [UserCallLogResponse](./RingCentral.Net/Definitions/UserCallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.

## deleteUserCallLog
Delete User Call Log

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`EditCallLog`
User Permission|`EditCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.

## readUserCallRecord
Get User Call Record

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(readUserCallRecordParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserCallRecordParameters` is of type [ReadUserCallRecordParameters](./RingCentral.Net/Definitions/ReadUserCallRecordParameters.cs)
- `result` is of type [UserCallLogRecord](./RingCentral.Net/Definitions/UserCallLogRecord.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.

## listExtensionDevices
Get Extension Device List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/device`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionDevicesParameters` is of type [ListExtensionDevicesParameters](./RingCentral.Net/Definitions/ListExtensionDevicesParameters.cs)
- `result` is of type [GetExtensionDevicesResponse](./RingCentral.Net/Definitions/GetExtensionDevicesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-listExtensionDevices) in API Explorer.

## createFaxMessage
Create Fax Message

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/fax`
Rate Limit Group|`Heavy`
App Permission|`Faxes`
User Permission|`OutboundFaxes`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().Post(createFaxMessageRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createFaxMessageRequest` is of type [CreateFaxMessageRequest](./RingCentral.Net/Definitions/CreateFaxMessageRequest.cs)
- `result` is of type [FaxResponse](./RingCentral.Net/Definitions/FaxResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Fax-createFaxMessage) in API Explorer.

## listExtensionGrants
Get Extension Grant List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/grant`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionGrantsParameters` is of type [ListExtensionGrantsParameters](./RingCentral.Net/Definitions/ListExtensionGrantsParameters.cs)
- `result` is of type [GetExtensionGrantListResponse](./RingCentral.Net/Definitions/GetExtensionGrantListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-listExtensionGrants) in API Explorer.

## createCustomUserGreeting
Create Custom User Greeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Post(createCustomUserGreetingRequest, createCustomUserGreetingParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createCustomUserGreetingRequest` is of type [CreateCustomUserGreetingRequest](./RingCentral.Net/Definitions/CreateCustomUserGreetingRequest.cs)
- `createCustomUserGreetingParameters` is of type [CreateCustomUserGreetingParameters](./RingCentral.Net/Definitions/CreateCustomUserGreetingParameters.cs)
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-createCustomUserGreeting) in API Explorer.

## readCustomGreeting
Get Custom Greeting

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [CustomUserGreetingInfo](./RingCentral.Net/Definitions/CustomUserGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readCustomGreeting) in API Explorer.

## listMeetings
Get Scheduled Meetings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [MeetingsResource](./RingCentral.Net/Definitions/MeetingsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-listMeetings) in API Explorer.

## createMeeting
Create Meeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Post(meetingRequestResource);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-createMeeting) in API Explorer.

## readMeeting
Get Meeting Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeeting) in API Explorer.

## updateMeeting
Update Meeting

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Put(meetingRequestResource);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- `result` is of type [MeetingResponseResource](./RingCentral.Net/Definitions/MeetingResponseResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-updateMeeting) in API Explorer.

## deleteMeeting
Delete Meeting

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-deleteMeeting) in API Explorer.

## createMMS
Send MMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/mms`
Rate Limit Group|`Medium`
App Permission|`SMS`
User Permission|`OutboundSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().Post(CreateMMSMessage);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `CreateMMSMessage` is of type [CreateMMSMessage](./RingCentral.Net/Definitions/CreateMMSMessage.cs)
- `result` is of type [GetSMSMessageInfoResponse](./RingCentral.Net/Definitions/GetSMSMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createMMS) in API Explorer.

## createRingOutCall
Make RingOut Call

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out`
Rate Limit Group|`Heavy`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-createRingOutCall) in API Explorer.

## readRingOutCallStatus
Get RingOut Call Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`
Rate Limit Group|`Light`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetRingOutStatusResponse](./RingCentral.Net/Definitions/GetRingOutStatusResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-readRingOutCallStatus) in API Explorer.

## deleteRingOutCall
Cancel RingOut Call

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`
Rate Limit Group|`Heavy`
App Permission|`RingOut`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.

## createSMSMessage
Send SMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/sms`
Rate Limit Group|`Medium`
App Permission|`SMS`
User Permission|`OutboundSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().Post(CreateSMSMessage);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `CreateSMSMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- `result` is of type [GetSMSMessageInfoResponse](./RingCentral.Net/Definitions/GetSMSMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.

## listIVRPrompts
Get IVR Prompt List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [IVRPrompts](./RingCentral.Net/Definitions/IVRPrompts.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-listIVRPrompts) in API Explorer.

## createIVRPrompt
Create IVR Prompts

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Post(createIVRPromptRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createIVRPromptRequest` is of type [CreateIVRPromptRequest](./RingCentral.Net/Definitions/CreateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-createIVRPrompt) in API Explorer.

## readIVRPrompt
Get IVR Prompt

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRPrompt) in API Explorer.

## updateIVRPrompt
Update IVR Prompt

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Put(updateIVRPromptRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateIVRPromptRequest` is of type [UpdateIVRPromptRequest](./RingCentral.Net/Definitions/UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./RingCentral.Net/Definitions/PromptInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-updateIVRPrompt) in API Explorer.

## deleteIVRPrompt
Delete IVR Prompt

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#IVR-deleteIVRPrompt) in API Explorer.

## listAccountPhoneNumbers
Get Company Phone Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/phone-number`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- `result` is of type [AccountPhoneNumbers](./RingCentral.Net/Definitions/AccountPhoneNumbers.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbers) in API Explorer.

## readAccountPhoneNumber
Get Phone Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/phone-number/{phoneNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyPhoneNumberInfo](./RingCentral.Net/Definitions/CompanyPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.

## listCallRecordingData
Get Call Recordings Data

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/recording/{recordingId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadCallRecording`
User Permission|`ReadCallRecording`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-listCallRecordingData) in API Explorer.

## readAccountServiceInfo
Get Account Service Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/service-info`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadServicePlanInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [GetServiceInfoResponse](./RingCentral.Net/Definitions/GetServiceInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountServiceInfo) in API Explorer.

## createSIPRegistration
Register Device

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/client-info/sip-provision`
Rate Limit Group|`Heavy`
App Permission|`VoipCalling`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().Post(createSipRegistrationRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createSipRegistrationRequest` is of type [CreateSipRegistrationRequest](./RingCentral.Net/Definitions/CreateSipRegistrationRequest.cs)
- `result` is of type [CreateSipRegistrationResponse](./RingCentral.Net/Definitions/CreateSipRegistrationResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Device-SIP-Registration-createSIPRegistration) in API Explorer.

## listCountries
Get Country List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/country`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country().List(listCountriesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listCountries) in API Explorer.

## readCountry
Get Country

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/country/{countryId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetCountryInfoDictionaryResponse](./RingCentral.Net/Definitions/GetCountryInfoDictionaryResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.

## listFaxCoverPages
Get Fax Cover Page List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/fax-cover-page`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./RingCentral.Net/Definitions/ListFaxCoverPagesParameters.cs)
- `result` is of type [ListFaxCoverPagesResponse](./RingCentral.Net/Definitions/ListFaxCoverPagesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Fax-listFaxCoverPages) in API Explorer.

## listStandardGreetings
Get Standard Greeting List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/greeting`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().List(listStandardGreetingsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- `result` is of type [DictionaryGreetingList](./RingCentral.Net/Definitions/DictionaryGreetingList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-listStandardGreetings) in API Explorer.

## readStandardGreeting
Get Standard Greeting

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/greeting/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [DictionaryGreetingInfo](./RingCentral.Net/Definitions/DictionaryGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readStandardGreeting) in API Explorer.

## listLanguages
Get Language List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/language`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [LanguageList](./RingCentral.Net/Definitions/LanguageList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLanguages) in API Explorer.

## readLanguage
Get Language

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/language/{languageId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [LanguageInfo](./RingCentral.Net/Definitions/LanguageInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.

## listLocations
Get Location List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/location`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Location().Get(listLocationsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listLocationsParameters` is of type [ListLocationsParameters](./RingCentral.Net/Definitions/ListLocationsParameters.cs)
- `result` is of type [GetLocationListResponse](./RingCentral.Net/Definitions/GetLocationListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLocations) in API Explorer.

## listTimezones
Get Timezone List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/timezone`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().List(listTimezonesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- `result` is of type [GetTimezoneListResponse](./RingCentral.Net/Definitions/GetTimezoneListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listTimezones) in API Explorer.

## readTimezone
Get Timezone

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/timezone/{timezoneId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).Get(readTimezoneParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `readTimezoneParameters` is of type [ReadTimezoneParameters](./RingCentral.Net/Definitions/ReadTimezoneParameters.cs)
- `result` is of type [GetTimezoneInfoResponse](./RingCentral.Net/Definitions/GetTimezoneInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.

## favoriteGlipChat
Add Chat to Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/favorite`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Favorite().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-favoriteGlipChat) in API Explorer.

## unfavoriteGlipChat
Remove Chat from Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/unfavorite`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unfavorite().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-unfavoriteGlipChat) in API Explorer.

## markChatUnread
Mark Chat as Unread

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/chats/{chatId}/unread`
Rate Limit Group|`Medium`
App Permission|`GlipInternal`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unread().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-markChatUnread) in API Explorer.

## listGlipConversations
Get Conversations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/conversations`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().List(listGlipConversationsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- `result` is of type [GlipConversationsList](./RingCentral.Net/Definitions/GlipConversationsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversations) in API Explorer.

## createGlipConversation
Create/Open Conversation

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/conversations`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations().Post(createGlipConversationRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createGlipConversationRequest` is of type [CreateGlipConversationRequest](./RingCentral.Net/Definitions/CreateGlipConversationRequest.cs)
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversation) in API Explorer.

## readGlipConversation
Get Conversation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/conversations/{chatId}`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipConversationInfo](./RingCentral.Net/Definitions/GlipConversationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversation) in API Explorer.

## readDataExportTaskDataset
Get Data Export Task Dataset

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/data-export/{taskId}/datasets/{datasetId}`
Rate Limit Group|`Heavy`
App Permission|`Glip`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Datasets(datasetId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Compliance-Exports-readDataExportTaskDataset) in API Explorer.

## listGroupEvents
Get Group Events

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-listGroupEvents) in API Explorer.

## createEventByGroupId
Create Event by Group ID

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Post(glipEventCreate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- `result` is of type [GlipEventInfo](./RingCentral.Net/Definitions/GlipEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventByGroupId) in API Explorer.

## listGlipGroupWebhooks
Get Webhooks in Group

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipWebhookList](./RingCentral.Net/Definitions/GlipWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-listGlipGroupWebhooks) in API Explorer.

## createGlipGroupWebhook
Create Webhook in Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GlipWebhookInfo](./RingCentral.Net/Definitions/GlipWebhookInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-createGlipGroupWebhook) in API Explorer.

## publishNote
Publish Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}/publish`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Publish().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-publishNote) in API Explorer.

## unlockNote
Unlock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/notes/{noteId}/unlock`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Unlock().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-unlockNote) in API Explorer.

## listRecentChats
Get Recent Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/glip/recent/chats`
Rate Limit Group|`Light`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Recent().Chats().Get(listRecentChatsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listRecentChatsParameters` is of type [ListRecentChatsParameters](./RingCentral.Net/Definitions/ListRecentChatsParameters.cs)
- `result` is of type [GlipChatsListWithoutNavigation](./RingCentral.Net/Definitions/GlipChatsListWithoutNavigation.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listRecentChats) in API Explorer.

## completeTask
Complete Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/tasks/{taskId}/complete`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Tasks(taskId).Complete().Post(glipCompleteTask);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `glipCompleteTask` is of type [GlipCompleteTask](./RingCentral.Net/Definitions/GlipCompleteTask.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTask) in API Explorer.

## archiveGlipTeam
Archive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/archive`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Archive().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-archiveGlipTeam) in API Explorer.

## unarchiveGlipTeam
Unarchive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/teams/{chatId}/unarchive`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Unarchive().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-unarchiveGlipTeam) in API Explorer.

## activateGlipWebhook
Activate Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/webhooks/{webhookId}/activate`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Activate().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-activateGlipWebhook) in API Explorer.

## suspendGlipWebhook
Suspend Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/glip/webhooks/{webhookId}/suspend`
Rate Limit Group|`Medium`
App Permission|`Glip`
User Permission|`Glip`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Suspend().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Glip-Webhooks-suspendGlipWebhook) in API Explorer.

## parsePhoneNumber
Parse Phone Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/number-parser/parse`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./RingCentral.Net/Definitions/ParsePhoneNumberRequest.cs)
- `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- `result` is of type [ParsePhoneNumberResponse](./RingCentral.Net/Definitions/ParsePhoneNumberResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-parsePhoneNumber) in API Explorer.

## renewSubscription
Renew Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/subscription/{subscriptionId}/renew`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [SubscriptionInfo](./RingCentral.Net/Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-renewSubscription) in API Explorer.

## readServiceProviderConfig2
Get Service Provider Config

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/ServiceProviderConfig`
Rate Limit Group|`NoThrottling`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Scim(version).ServiceProviderConfig().Get();
}
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ServiceProviderConfig](./RingCentral.Net/Definitions/ServiceProviderConfig.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-readServiceProviderConfig2) in API Explorer.

## addressBookBulkUpload
Update Multiple Contacts

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AddressBookBulkUpload().Post(addressBookBulkUploadRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `addressBookBulkUploadRequest` is of type [AddressBookBulkUploadRequest](./RingCentral.Net/Definitions/AddressBookBulkUploadRequest.cs)
- `result` is of type [AddressBookBulkUploadResponse](./RingCentral.Net/Definitions/AddressBookBulkUploadResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-addressBookBulkUpload) in API Explorer.

## listCallMonitoringGroups
Get Call Monitoring Groups List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Get(listCallMonitoringGroupsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- `result` is of type [CallMonitoringGroups](./RingCentral.Net/Definitions/CallMonitoringGroups.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API Explorer.

## createCallMonitoringGroup
Create Call Monitoring Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API Explorer.

## updateCallMonitoringGroup
Updates Call Monitoring Group

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./RingCentral.Net/Definitions/CallMonitoringGroup.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API Explorer.

## deleteCallMonitoringGroup
Delete Call Monitoring Group

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API Explorer.

## assignMultipleCallQueueMembers
Assign Multiple Call Queue Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./RingCentral.Net/Definitions/CallQueueBulkAssignResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API Explorer.

## listCallQueueMembers
Get Call Queue Members

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/members`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallQueueMembersParameters` is of type [ListCallQueueMembersParameters](./RingCentral.Net/Definitions/ListCallQueueMembersParameters.cs)
- `result` is of type [CallQueueMembers](./RingCentral.Net/Definitions/CallQueueMembers.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-listCallQueueMembers) in API Explorer.

## readCallQueuePresence
Get Call Queue Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallQueuePresence](./RingCentral.Net/Definitions/CallQueuePresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readCallQueuePresence) in API Explorer.

## updateCallQueuePresence
Update Call Queue Presence

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Put(callQueueUpdatePresence);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueUpdatePresence` is of type [CallQueueUpdatePresence](./RingCentral.Net/Definitions/CallQueueUpdatePresence.cs)
- `result` is of type [CallQueuePresence](./RingCentral.Net/Definitions/CallQueuePresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateCallQueuePresence) in API Explorer.

## updateCallRecordingExtensionList
Update Call Recording Extension List

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording/bulk-assign`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bulkAccountCallRecordingsResource` is of type [BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/BulkAccountCallRecordingsResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingExtensionList) in API Explorer.

## listCallRecordingExtensions
Get Call Recording Extension List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording/extensions`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallRecordingExtensions](./RingCentral.Net/Definitions/CallRecordingExtensions.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingExtensions) in API Explorer.

## searchDirectoryEntries
Search Company Directory Entries

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/directory/entries/search`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `searchDirectoryEntriesRequest` is of type [SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/SearchDirectoryEntriesRequest.cs)
- `result` is of type [DirectoryResource](./RingCentral.Net/Definitions/DirectoryResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.

## readAccountFederation
Get Account Federation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/directory/federation`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [FederationResource](./RingCentral.Net/Definitions/FederationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readAccountFederation) in API Explorer.

## listEmergencyLocations
Get Emergency Location List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().List(listEmergencyLocationsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listEmergencyLocationsParameters` is of type [ListEmergencyLocationsParameters](./RingCentral.Net/Definitions/ListEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationList](./RingCentral.Net/Definitions/EmergencyLocationList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API Explorer.

## createEmergencyLocation
Add Emergency Location

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().Post(emergencyLocationInfoRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API Explorer.

## readEmergencyLocation
Get Emergency Location

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API Explorer.

## updateEmergencyLocation
Update Emergency Location

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Put(emergencyLocationInfoRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `emergencyLocationInfoRequest` is of type [EmergencyLocationInfoRequest](./RingCentral.Net/Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationInfo](./RingCentral.Net/Definitions/EmergencyLocationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API Explorer.

## deleteEmergencyLocation
Delete Emergency Location

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Delete(deleteEmergencyLocationParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `deleteEmergencyLocationParameters` is of type [DeleteEmergencyLocationParameters](./RingCentral.Net/Definitions/DeleteEmergencyLocationParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteEmergencyLocation) in API Explorer.

## extensionBulkUpdate
Update Multiple Extensions

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension-bulk-update`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditExtensionInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ExtensionBulkUpdate().Post(extensionBulkUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `extensionBulkUpdateRequest` is of type [ExtensionBulkUpdateRequest](./RingCentral.Net/Definitions/ExtensionBulkUpdateRequest.cs)
- `result` is of type [ExtensionBulkUpdateTaskResource](./RingCentral.Net/Definitions/ExtensionBulkUpdateTaskResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-extensionBulkUpdate) in API Explorer.

## getExtensionBulkUpdateTask
Get Update Task Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension-bulk-update/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditExtensionInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).ExtensionBulkUpdate().Tasks(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [ExtensionBulkUpdateTaskResource](./RingCentral.Net/Definitions/ExtensionBulkUpdateTaskResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-getExtensionBulkUpdateTask) in API Explorer.

## listExtensionActiveCalls
Get User Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionActiveCallsParameters` is of type [ListExtensionActiveCallsParameters](./RingCentral.Net/Definitions/ListExtensionActiveCallsParameters.cs)
- `result` is of type [UserActiveCallsResponse](./RingCentral.Net/Definitions/UserActiveCallsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listExtensionActiveCalls) in API Explorer.

## syncAddressBook
Address Book Synchronization

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncAddressBookParameters` is of type [SyncAddressBookParameters](./RingCentral.Net/Definitions/SyncAddressBookParameters.cs)
- `result` is of type [AddressBookSync](./RingCentral.Net/Definitions/AddressBookSync.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-syncAddressBook) in API Explorer.

## listAnsweringRules
Get Call Handling Rules

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- `result` is of type [UserAnsweringRuleList](./RingCentral.Net/Definitions/UserAnsweringRuleList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-listAnsweringRules) in API Explorer.

## createAnsweringRule
Create Call Handling Rule

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./RingCentral.Net/Definitions/CustomAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-createAnsweringRule) in API Explorer.

## readAnsweringRule
Get Call Handling Rule

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(readAnsweringRuleParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./RingCentral.Net/Definitions/ReadAnsweringRuleParameters.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-readAnsweringRule) in API Explorer.

## updateAnsweringRule
Update Call Handling Rule

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./RingCentral.Net/Definitions/AnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateAnsweringRule) in API Explorer.

## deleteAnsweringRule
Delete Call Handling Rule

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteAnsweringRule) in API Explorer.

## readAuthorizationProfile
Get Authorization Profile

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [AuthProfileResource](./RingCentral.Net/Definitions/AuthProfileResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readAuthorizationProfile) in API Explorer.

## readUserBusinessHours
Get User Business Hours

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/business-hours`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetUserBusinessHoursResponse](./RingCentral.Net/Definitions/GetUserBusinessHoursResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-readUserBusinessHours) in API Explorer.

## updateUserBusinessHours
Update User Business Hours

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/business-hours`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserAnsweringRules`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `userBusinessHoursUpdateRequest` is of type [UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/UserBusinessHoursUpdateRequest.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./RingCentral.Net/Definitions/UserBusinessHoursUpdateResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.

## syncUserCallLog
Sync User Call Log

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log-sync`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./RingCentral.Net/Definitions/SyncUserCallLogParameters.cs)
- `result` is of type [CallLogSync](./RingCentral.Net/Definitions/CallLogSync.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncUserCallLog) in API Explorer.

## updateUserCallQueues
Update User Call Queues

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`Accounts`
User Permission|`JoinLeaveCallQueue`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().Put(userCallQueues);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `userCallQueues` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)
- `result` is of type [UserCallQueues](./RingCentral.Net/Definitions/UserCallQueues.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.

## readCallerBlockingSettings
Get Caller Blocking Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readCallerBlockingSettings) in API Explorer.

## updateCallerBlockingSettings
Update Caller Blocking Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `callerBlockingSettingsUpdate` is of type [CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/CallerBlockingSettingsUpdate.cs)
- `result` is of type [CallerBlockingSettings](./RingCentral.Net/Definitions/CallerBlockingSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API Explorer.

## readExtensionCallerId
Get Extension Caller ID

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCallerIDSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readExtensionCallerId) in API Explorer.

## updateExtensionCallerId
Update Extension Caller ID

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-id`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditCallerIDSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionCallerIdInfo` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- `result` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtensionCallerId) in API Explorer.

## createInternalTextMessage
Create Internal Text Message

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/company-pager`
Rate Limit Group|`Medium`
App Permission|`InternalMessages`
User Permission|`InternalSMS`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createInternalTextMessageRequest` is of type [CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/CreateInternalTextMessageRequest.cs)
- `result` is of type [GetInternalTextMessageInfoResponse](./RingCentral.Net/Definitions/GetInternalTextMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Pager-Messages-createInternalTextMessage) in API Explorer.

## readConferencingSettings
Get User Conferencing Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/conferencing`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`OrganizeConference`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Get(readConferencingSettingsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readConferencingSettingsParameters` is of type [ReadConferencingSettingsParameters](./RingCentral.Net/Definitions/ReadConferencingSettingsParameters.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readConferencingSettings) in API Explorer.

## updateConferencingSettings
Update User Conferencing Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/conferencing`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`OrganizeConference`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateConferencingInfoRequest` is of type [UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/UpdateConferencingInfoRequest.cs)
- `result` is of type [GetConferencingInfoResponse](./RingCentral.Net/Definitions/GetConferencingInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.

## listFavoriteContacts
Get Favorite Contact List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite`
Rate Limit Group|`Light`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listFavoriteContacts) in API Explorer.

## updateFavoriteContactList
Update Favorite Contact List

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite`
Rate Limit Group|`Medium`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `favoriteCollection` is of type [FavoriteCollection](./RingCentral.Net/Definitions/FavoriteCollection.cs)
- `result` is of type [FavoriteContactList](./RingCentral.Net/Definitions/FavoriteContactList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API Explorer.

## readUserFeatures
Get User Features

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/features`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Features().Get(readUserFeaturesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserFeaturesParameters` is of type [ReadUserFeaturesParameters](./RingCentral.Net/Definitions/ReadUserFeaturesParameters.cs)
- `result` is of type [FeatureList](./RingCentral.Net/Definitions/FeatureList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Features-readUserFeatures) in API Explorer.

## listForwardingNumbers
Get Forwarding Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().List(listForwardingNumbersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listForwardingNumbersParameters` is of type [ListForwardingNumbersParameters](./RingCentral.Net/Definitions/ListForwardingNumbersParameters.cs)
- `result` is of type [GetExtensionForwardingNumberListResponse](./RingCentral.Net/Definitions/GetExtensionForwardingNumberListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-listForwardingNumbers) in API Explorer.

## createForwardingNumber
Create Forwarding Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.

## readForwardingNumber
Get Forwarding Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-readForwardingNumber) in API Explorer.

## updateForwardingNumber
Update Forwarding Number

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./RingCentral.Net/Definitions/ForwardingNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-updateForwardingNumber) in API Explorer.

## deleteForwardingNumber
Delete Forwarding Number

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.

## listUserMeetingRecordings
Get User Meeting Recordings List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting-recordings`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`MeetingsRecordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingRecordings().Get(listUserMeetingRecordingsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listUserMeetingRecordingsParameters` is of type [ListUserMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListUserMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listUserMeetingRecordings) in API Explorer.

## endMeeting
End Meeting

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).End().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-endMeeting) in API Explorer.

## readMeetingInvitation
Get Meeting Invitation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/invitation`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Invitation().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [PublicMeetingInvitationResponse](./RingCentral.Net/Definitions/PublicMeetingInvitationResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Management-readMeetingInvitation) in API Explorer.

## listMessages
Get Message List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- `result` is of type [GetMessageList](./RingCentral.Net/Definitions/GetMessageList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-listMessages) in API Explorer.

## deleteMessageByFilter
Delete Conversation

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().DeleteAll(deleteMessageByFilterParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteMessageByFilterParameters` is of type [DeleteMessageByFilterParameters](./RingCentral.Net/Definitions/DeleteMessageByFilterParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessageByFilter) in API Explorer.

## readMessage
Get Message

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.

## updateMessage
Update Message List

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest, updateMessageParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- `updateMessageParameters` is of type [UpdateMessageParameters](./RingCentral.Net/Definitions/UpdateMessageParameters.cs)
- `result` is of type [GetMessageInfoResponse](./RingCentral.Net/Definitions/GetMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessage) in API Explorer.

## deleteMessage
Delete Message

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.

## syncMessages
Sync Messages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-sync`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncMessagesParameters` is of type [SyncMessagesParameters](./RingCentral.Net/Definitions/SyncMessagesParameters.cs)
- `result` is of type [GetMessageSyncResponse](./RingCentral.Net/Definitions/GetMessageSyncResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-syncMessages) in API Explorer.

## listExtensionPhoneNumbers
Get Extension Phone Number List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/phone-number`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserPhoneNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionPhoneNumbersParameters` is of type [ListExtensionPhoneNumbersParameters](./RingCentral.Net/Definitions/ListExtensionPhoneNumbersParameters.cs)
- `result` is of type [GetExtensionPhoneNumbersResponse](./RingCentral.Net/Definitions/GetExtensionPhoneNumbersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listExtensionPhoneNumbers) in API Explorer.

## readUserPresenceStatus
Get User Presence Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Get(readUserPresenceStatusParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserPresenceStatusParameters` is of type [ReadUserPresenceStatusParameters](./RingCentral.Net/Definitions/ReadUserPresenceStatusParameters.cs)
- `result` is of type [GetPresenceInfo](./RingCentral.Net/Definitions/GetPresenceInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUserPresenceStatus) in API Explorer.

## updateUserPresenceStatus
Update User Presence Status

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Put(presenceInfoRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `presenceInfoRequest` is of type [PresenceInfoRequest](./RingCentral.Net/Definitions/PresenceInfoRequest.cs)
- `result` is of type [PresenceInfoResponse](./RingCentral.Net/Definitions/PresenceInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.

## readUserProfileImage
Get User Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImage) in API Explorer.

## createUserProfileImage
Upload User Profile Image

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Post(createUserProfileImageRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createUserProfileImageRequest` is of type [CreateUserProfileImageRequest](./RingCentral.Net/Definitions/CreateUserProfileImageRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-createUserProfileImage) in API Explorer.

## updateUserProfileImage
Update User Profile Image

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Put(updateUserProfileImageRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateUserProfileImageRequest` is of type [UpdateUserProfileImageRequest](./RingCentral.Net/Definitions/UpdateUserProfileImageRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.

## readScaledProfileImage
Get Scaled User Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledProfileImage) in API Explorer.

## readUnifiedPresence
Get Unified Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/unified-presence`
Rate Limit Group|`Medium`
App Permission|`ReadPresence`
User Permission|`ReadPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readUnifiedPresence) in API Explorer.

## updateUnifiedPresence
Update Unified Presence

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/unified-presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`EditPresenceStatus`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Patch(updateUnifiedPresence);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateUnifiedPresence` is of type [UpdateUnifiedPresence](./RingCentral.Net/Definitions/UpdateUnifiedPresence.cs)
- `result` is of type [UnifiedPresence](./RingCentral.Net/Definitions/UnifiedPresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.

## readIVRPromptContent
Get IVR Prompt Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}/content`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRPromptContent) in API Explorer.

## listAccountMeetingRecordings
Get Account Meeting Recordings List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/meeting-recordings`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`MeetingsRecordings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MeetingRecordings().Get(listAccountMeetingRecordingsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAccountMeetingRecordingsParameters` is of type [ListAccountMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListAccountMeetingRecordingsParameters.cs)
- `result` is of type [ListMeetingRecordingsResponse](./RingCentral.Net/Definitions/ListMeetingRecordingsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-listAccountMeetingRecordings) in API Explorer.

## GetAccountLockedSetting
Get Locked Meeting Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/meeting/locked-settings`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Meeting().LockedSettings().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AccountLockedSettingResponse](./RingCentral.Net/Definitions/AccountLockedSettingResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-GetAccountLockedSetting) in API Explorer.

## readMessageStoreConfiguration
Get Message Store Configuration

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-configuration`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`AccountAdministration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageStoreConfiguration) in API Explorer.

## updateMessageStoreConfiguration
Update Message Store Configuration

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-configuration`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`AccountAdministration`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `messageStoreConfiguration` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- `result` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API Explorer.

## createMessageStoreReport
Create Message Store Report

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-report`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-createMessageStoreReport) in API Explorer.

## readMessageStoreReportTask
Get Message Store Report Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreReport](./RingCentral.Net/Definitions/MessageStoreReport.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API Explorer.

## readMessageStoreReportArchive
Get Message Store Report Archive

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreReportArchive](./RingCentral.Net/Definitions/MessageStoreReportArchive.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API Explorer.

## readMessageStoreReportArchiveContent
Get Message Store Report Archive Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`
Rate Limit Group|`Heavy`
App Permission|`ReadMessages`
User Permission|`Users`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchiveContent) in API Explorer.

## listPagingGroupDevices
Get Paging Group Devices

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyDevices`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listPagingGroupDevicesParameters` is of type [ListPagingGroupDevicesParameters](./RingCentral.Net/Definitions/ListPagingGroupDevicesParameters.cs)
- `result` is of type [PagingOnlyGroupDevices](./RingCentral.Net/Definitions/PagingOnlyGroupDevices.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupDevices) in API Explorer.

## listPagingGroupUsers
Get Paging Group Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listPagingGroupUsersParameters` is of type [ListPagingGroupUsersParameters](./RingCentral.Net/Definitions/ListPagingGroupUsersParameters.cs)
- `result` is of type [PagingOnlyGroupUsers](./RingCentral.Net/Definitions/PagingOnlyGroupUsers.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupUsers) in API Explorer.

## createCallOutCallSession
Make CallOut

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/call-out`
Rate Limit Group|`Heavy`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().Post(makeCallOutRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `makeCallOutRequest` is of type [MakeCallOutRequest](./RingCentral.Net/Definitions/MakeCallOutRequest.cs)
- `result` is of type [CallSession](./RingCentral.Net/Definitions/CallSession.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallOutCallSession) in API Explorer.

## createConferenceCallSession
Start Conference Call Session

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/conference`
Rate Limit Group|`Heavy`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Conference().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallSessionObject](./RingCentral.Net/Definitions/CallSessionObject.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createConferenceCallSession) in API Explorer.

## readCallSessionStatus
Get Call Session Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Get(readCallSessionStatusParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCallSessionStatusParameters` is of type [ReadCallSessionStatusParameters](./RingCentral.Net/Definitions/ReadCallSessionStatusParameters.cs)
- `result` is of type [CallSessionObject](./RingCentral.Net/Definitions/CallSessionObject.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallSessionStatus) in API Explorer.

## deleteCallSession
Drop Call Session

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallSession) in API Explorer.

## readCallPartyStatus
Get Call Party Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallPartyStatus) in API Explorer.

## deleteCallParty
Delete Call Party

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`TelephonySessions`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallParty) in API Explorer.

## updateCallParty
Update Call Party

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Patch(partyUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `partyUpdateRequest` is of type [PartyUpdateRequest](./RingCentral.Net/Definitions/PartyUpdateRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.

## superviseCallSession
Supervise Call Session

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `superviseCallSessionRequest` is of type [SuperviseCallSessionRequest](./RingCentral.Net/Definitions/SuperviseCallSessionRequest.cs)
- `result` is of type [SuperviseCallSession](./RingCentral.Net/Definitions/SuperviseCallSession.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.

## listDomesticCountries
Get Domestic Country List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country/{contractedCountryId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Dictionary().Brand(brandId).ContractedCountry(contractedCountryId).Get(listDomesticCountriesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listDomesticCountriesParameters` is of type [ListDomesticCountriesParameters](./RingCentral.Net/Definitions/ListDomesticCountriesParameters.cs)
- `result` is of type [GetCountryListResponse](./RingCentral.Net/Definitions/GetCountryListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-listDomesticCountries) in API Explorer.

## getAddressBookBulkUploadTask
Get Contacts Update Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).AddressBookBulkUpload().Tasks(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AddressBookBulkUploadResponse](./RingCentral.Net/Definitions/AddressBookBulkUploadResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-getAddressBookBulkUploadTask) in API Explorer.

## updateCallMonitoringGroupList
Update Call Monitoring Group List

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./RingCentral.Net/Definitions/CallMonitoringBulkAssign.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in API Explorer.

## listCallMonitoringGroupMembers
Get Call Monitoring Group Member List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/members`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallMonitoringGroupMembersParameters` is of type [ListCallMonitoringGroupMembersParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupMembersParameters.cs)
- `result` is of type [CallMonitoringGroupMemberList](./RingCentral.Net/Definitions/CallMonitoringGroupMemberList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroupMembers) in API Explorer.

## listCallRecordingCustomGreetings
Get Call Recording Custom Greeting List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Get(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- `result` is of type [CallRecordingCustomGreetings](./RingCentral.Net/Definitions/CallRecordingCustomGreetings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingCustomGreetings) in API Explorer.

## deleteCallRecordingCustomGreetingList
Delete Call Recording Custom Greeting List

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().DeleteAll();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-deleteCallRecordingCustomGreetingList) in API Explorer.

## deleteCallRecordingCustomGreeting
Delete Call Recording Custom Greeting

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings/{greetingId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyInfo`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-deleteCallRecordingCustomGreeting) in API Explorer.

## listDevicesAutomaticLocationUpdates
Get Device List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().Get(listDevicesAutomaticLocationUpdatesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listDevicesAutomaticLocationUpdatesParameters` is of type [ListDevicesAutomaticLocationUpdatesParameters](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdatesParameters.cs)
- `result` is of type [ListDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/ListDevicesAutomaticLocationUpdates.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listDevicesAutomaticLocationUpdates) in API Explorer.

## assignMultipleDevicesAutomaticLocationUpdates
Enable Automatic Location Updates for Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().Post(assignMultipleDevicesAutomaticLocationUpdates);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `assignMultipleDevicesAutomaticLocationUpdates` is of type [AssignMultipleDevicesAutomaticLocationUpdates](./RingCentral.Net/Definitions/AssignMultipleDevicesAutomaticLocationUpdates.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.

## listNetworks
Get Network Map

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().List();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [NetworksList](./RingCentral.Net/Definitions/NetworksList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listNetworks) in API Explorer.

## createNetwork
Create Network

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().Post(createNetworkRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createNetworkRequest` is of type [CreateNetworkRequest](./RingCentral.Net/Definitions/CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createNetwork) in API Explorer.

## readNetwork
Get Network

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [NetworkInfo](./RingCentral.Net/Definitions/NetworkInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readNetwork) in API Explorer.

## updateNetwork
Update Network

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Put(updateNetworkRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateNetworkRequest` is of type [UpdateNetworkRequest](./RingCentral.Net/Definitions/UpdateNetworkRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateNetwork) in API Explorer.

## deleteNetwork
Delete Network

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.

## readAutomaticLocationUpdatesTask
Get Emergency Map Configuration Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AutomaticLocationUpdatesTaskInfo](./RingCentral.Net/Definitions/AutomaticLocationUpdatesTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readAutomaticLocationUpdatesTask) in API Explorer.

## listAutomaticLocationUpdatesUsers
Get User List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().Get(listAutomaticLocationUpdatesUsersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAutomaticLocationUpdatesUsersParameters` is of type [ListAutomaticLocationUpdatesUsersParameters](./RingCentral.Net/Definitions/ListAutomaticLocationUpdatesUsersParameters.cs)
- `result` is of type [AutomaticLocationUpdatesUserList](./RingCentral.Net/Definitions/AutomaticLocationUpdatesUserList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAutomaticLocationUpdatesUsers) in API Explorer.

## assignMultipleAutomaticaLocationUpdatesUsers
Enable Automatic Location Updates for Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().Post(bulkAssignAutomaticLocationUpdatesUsers);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bulkAssignAutomaticLocationUpdatesUsers` is of type [BulkAssignAutomaticLocationUpdatesUsers](./RingCentral.Net/Definitions/BulkAssignAutomaticLocationUpdatesUsers.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.

## listWirelessPoints
Get Wireless Point List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().List(listWirelessPointsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listWirelessPointsParameters` is of type [ListWirelessPointsParameters](./RingCentral.Net/Definitions/ListWirelessPointsParameters.cs)
- `result` is of type [WirelessPointsList](./RingCentral.Net/Definitions/WirelessPointsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API Explorer.

## createWirelessPoint
Create Wireless Point

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().Post(createWirelessPoint);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createWirelessPoint` is of type [CreateWirelessPoint](./RingCentral.Net/Definitions/CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API Explorer.

## readWirelessPoint
Get Wireless Point

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API Explorer.

## updateWirelessPoint
Update Wireless Point

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Put(updateWirelessPoint);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateWirelessPoint` is of type [UpdateWirelessPoint](./RingCentral.Net/Definitions/UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./RingCentral.Net/Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API Explorer.

## deleteWirelessPoint
Delete Wireless Point

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API Explorer.

## listContacts
Get Contact List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- `result` is of type [ContactList](./RingCentral.Net/Definitions/ContactList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.

## createContact
Create Contact

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.

## readContact
Get Contact

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.

## updateContact
Update Contact

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactRequest, updateContactParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `personalContactRequest` is of type [PersonalContactRequest](./RingCentral.Net/Definitions/PersonalContactRequest.cs)
- `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- `result` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.

## deleteContact
Delete Contact

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.

## checkUserPermission
Check User Permission

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile/check`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `checkUserPermissionParameters` is of type [CheckUserPermissionParameters](./RingCentral.Net/Definitions/CheckUserPermissionParameters.cs)
- `result` is of type [AuthProfileCheckResource](./RingCentral.Net/Definitions/AuthProfileCheckResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-checkUserPermission) in API Explorer.

## readExtensionCallQueuePresence
Get Agent’s Call Queue Presence

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence`
Rate Limit Group|`Light`
App Permission|`ReadPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Get(readExtensionCallQueuePresenceParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readExtensionCallQueuePresenceParameters` is of type [ReadExtensionCallQueuePresenceParameters](./RingCentral.Net/Definitions/ReadExtensionCallQueuePresenceParameters.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueuePresenceList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-readExtensionCallQueuePresence) in API Explorer.

## updateExtensionCallQueuePresence
Update Call Queue Presence

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence`
Rate Limit Group|`Medium`
App Permission|`EditPresence`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Put(extensionCallQueueUpdatePresenceList);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionCallQueueUpdatePresenceList` is of type [ExtensionCallQueueUpdatePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueueUpdatePresenceList.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./RingCentral.Net/Definitions/ExtensionCallQueuePresenceList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateExtensionCallQueuePresence) in API Explorer.

## getExtensionEmergencyLocations
Get User Emergency Location List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [UserEmergencyLocationList](./RingCentral.Net/Definitions/UserEmergencyLocationList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-getExtensionEmergencyLocations) in API Explorer.

## readMeetingServiceInfo
Get Meeting Service Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/service-info`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readMeetingServiceInfo) in API Explorer.

## updateMeetingServiceInfo
Update Meeting Service Info

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/service-info`
Rate Limit Group|`Medium`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Patch(meetingServiceInfoRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `meetingServiceInfoRequest` is of type [MeetingServiceInfoRequest](./RingCentral.Net/Definitions/MeetingServiceInfoRequest.cs)
- `result` is of type [MeetingServiceInfoResource](./RingCentral.Net/Definitions/MeetingServiceInfoResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-updateMeetingServiceInfo) in API Explorer.

## GetUserSetting
Get Meeting User Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/user-settings`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().UserSettings().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [MeetingUserSettingsResponse](./RingCentral.Net/Definitions/MeetingUserSettingsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-GetUserSetting) in API Explorer.

## readMessageContent
Get Message Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`
Rate Limit Group|`Medium`
App Permission|`ReadMessages`
User Permission|`ReadMessageContent`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(readMessageContentParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readMessageContentParameters` is of type [ReadMessageContentParameters](./RingCentral.Net/Definitions/ReadMessageContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageContent) in API Explorer.

## readUserVideoConfiguration
Get User Video Configuration

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).VideoConfiguration().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Video-Configuration-readUserVideoConfiguration) in API Explorer.

## updateUserVideoConfiguration
Update User Video Configuration

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).VideoConfiguration().Put(userVideoConfiguration);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `userVideoConfiguration` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)
- `result` is of type [UserVideoConfiguration](./RingCentral.Net/Definitions/UserVideoConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Video-Configuration-updateUserVideoConfiguration) in API Explorer.

## assignMultiplePagingGroupUsersDevices
Assign Paging Group Users and Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`Groups`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `editPagingGroupRequest` is of type [EditPagingGroupRequest](./RingCentral.Net/Definitions/EditPagingGroupRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices) in API Explorer.

## listAccountSwitches
Get Account Switch List

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAccountSwitchesParameters` is of type [ListAccountSwitchesParameters](./RingCentral.Net/Definitions/ListAccountSwitchesParameters.cs)
- `result` is of type [SwitchesList](./RingCentral.Net/Definitions/SwitchesList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API Explorer.

## createSwitch
Create Switch

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().Post(createSwitchInfo);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createSwitchInfo` is of type [CreateSwitchInfo](./RingCentral.Net/Definitions/CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createSwitch) in API Explorer.

## readSwitch
Get Switch

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readSwitch) in API Explorer.

## updateSwitch
Update Switch

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Put(updateSwitchInfo);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateSwitchInfo` is of type [UpdateSwitchInfo](./RingCentral.Net/Definitions/UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./RingCentral.Net/Definitions/SwitchInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateSwitch) in API Explorer.

## deleteSwitch
Delete Switch

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteSwitch) in API Explorer.

## createMultipleSwitches
Create Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-create`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().Post(createMultipleSwitchesRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMultipleSwitchesRequest` is of type [CreateMultipleSwitchesRequest](./RingCentral.Net/Definitions/CreateMultipleSwitchesRequest.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./RingCentral.Net/Definitions/CreateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API Explorer.

## updateMultipleSwitches
Update Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-update`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().Post(updateMultipleSwitchesRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateMultipleSwitchesRequest` is of type [UpdateMultipleSwitchesRequest](./RingCentral.Net/Definitions/UpdateMultipleSwitchesRequest.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./RingCentral.Net/Definitions/UpdateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API Explorer.

## validateMultipleSwitches
Validate Multiple Switches

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-validate`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().Post(validateMultipleSwitchesRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `validateMultipleSwitchesRequest` is of type [ValidateMultipleSwitchesRequest](./RingCentral.Net/Definitions/ValidateMultipleSwitchesRequest.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./RingCentral.Net/Definitions/ValidateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API Explorer.

## createMultipleWirelessPoints
Create Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().Post(createMultipleWirelessPointsRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMultipleWirelessPointsRequest` is of type [CreateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsRequest.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/CreateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in API Explorer.

## updateMultipleWirelessPoints
Update Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().Post(updateMultipleWirelessPointsRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateMultipleWirelessPointsRequest` is of type [UpdateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsRequest.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/UpdateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in API Explorer.

## validateMultipleWirelessPoints
Validate Multiple Wireless Points

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().Post(validateMultipleWirelessPointsRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `validateMultipleWirelessPointsRequest` is of type [ValidateMultipleWirelessPointsRequest](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsRequest.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./RingCentral.Net/Definitions/ValidateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints) in API Explorer.

## listBlockedAllowedNumbers
Get Blocked/Allowed Phone Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedNumbersParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listBlockedAllowedNumbersParameters` is of type [ListBlockedAllowedNumbersParameters](./RingCentral.Net/Definitions/ListBlockedAllowedNumbersParameters.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumbersList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-listBlockedAllowedNumbers) in API Explorer.

## createBlockedAllowedNumber
Add Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-createBlockedAllowedNumber) in API Explorer.

## readBlockedAllowedNumber
Get Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-readBlockedAllowedNumber) in API Explorer.

## updateBlockedAllowedNumber
Update Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./RingCentral.Net/Definitions/BlockedAllowedPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateBlockedAllowedNumber) in API Explorer.

## deleteBlockedAllowedNumber
Delete Blocked/Allowed Number

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditBlockedNumbers`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.

## createUserMeetingProfileImage
Upload User Meeting Profile Image

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting-configuration/profile-image`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingConfiguration().ProfileImage().Post(createUserMeetingProfileImageRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createUserMeetingProfileImageRequest` is of type [CreateUserMeetingProfileImageRequest](./RingCentral.Net/Definitions/CreateUserMeetingProfileImageRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-createUserMeetingProfileImage) in API Explorer.

## readAssistants
Get Assistants

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assistants().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [AssistantsResource](./RingCentral.Net/Definitions/AssistantsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistants) in API Explorer.

## readAssistedUsers
Get Assisted Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted`
Rate Limit Group|`Light`
App Permission|`Meetings`
User Permission|`Meetings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingsConfiguration().Assisted().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [AssistedUsersResource](./RingCentral.Net/Definitions/AssistedUsersResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Configuration-readAssistedUsers) in API Explorer.

## readNotificationSettings
Get Notification Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadMessagesNotificationsSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Get();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readNotificationSettings) in API Explorer.

## updateNotificationSettings
Update Notification Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/notification-settings`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditMessagesNotificationsSettings`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `notificationSettingsUpdateRequest` is of type [NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/NotificationSettingsUpdateRequest.cs)
- `result` is of type [NotificationSettings](./RingCentral.Net/Definitions/NotificationSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateNotificationSettings) in API Explorer.

## createCallPartyWithBringIn
Bring-In Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/bring-in`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties().BringIn().Post(addPartyRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `addPartyRequest` is of type [AddPartyRequest](./RingCentral.Net/Definitions/AddPartyRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-createCallPartyWithBringIn) in API Explorer.

## answerCallParty
Answer Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().Post(answerTarget);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `answerTarget` is of type [AnswerTarget](./RingCentral.Net/Definitions/AnswerTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-answerCallParty) in API Explorer.

## bridgeCallParty
Bridge Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Bridge().Post(bridgeTargetRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bridgeTargetRequest` is of type [BridgeTargetRequest](./RingCentral.Net/Definitions/BridgeTargetRequest.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-bridgeCallParty) in API Explorer.

## callFlipParty
Call Flip on Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().Post(callPartyFlip);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callPartyFlip` is of type [CallPartyFlip](./RingCentral.Net/Definitions/CallPartyFlip.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callFlipParty) in API Explorer.

## forwardCallParty
Forward Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `forwardTarget` is of type [ForwardTarget](./RingCentral.Net/Definitions/ForwardTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-forwardCallParty) in API Explorer.

## holdCallParty
Hold Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-holdCallParty) in API Explorer.

## ignoreCallInQueue
Ignore Call in Queue

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().Post(ignoreRequestBody);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `ignoreRequestBody` is of type [IgnoreRequestBody](./RingCentral.Net/Definitions/IgnoreRequestBody.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.

## callParkParty
Call Park

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Park().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callParkParty) in API Explorer.

## pickupCallParty
Pickup Call

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().Post(pickupTarget);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `pickupTarget` is of type [PickupTarget](./RingCentral.Net/Definitions/PickupTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pickupCallParty) in API Explorer.

## startCallRecording
Create Recording

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-startCallRecording) in API Explorer.

## pauseResumeCallRecording
Pause/Resume Recording

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./RingCentral.Net/Definitions/CallRecording.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-pauseResumeCallRecording) in API Explorer.

## rejectParty
Reject Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-rejectParty) in API Explorer.

## replyParty
Reply with Text

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().Post(callPartyReply);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callPartyReply` is of type [CallPartyReply](./RingCentral.Net/Definitions/CallPartyReply.cs)
- `result` is of type [ReplyParty](./RingCentral.Net/Definitions/ReplyParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-replyParty) in API Explorer.

## superviseCallParty
Supervise Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().Post(partySuperviseRequest);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `partySuperviseRequest` is of type [PartySuperviseRequest](./RingCentral.Net/Definitions/PartySuperviseRequest.cs)
- `result` is of type [PartySuperviseResponse](./RingCentral.Net/Definitions/PartySuperviseResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallParty) in API Explorer.

## transferCallParty
Transfer Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().Post(transferTarget);
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `transferTarget` is of type [TransferTarget](./RingCentral.Net/Definitions/TransferTarget.cs)
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-transferCallParty) in API Explorer.

## unholdCallParty
Unhold Call Party

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().Post();
}
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./RingCentral.Net/Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-unholdCallParty) in API Explorer.