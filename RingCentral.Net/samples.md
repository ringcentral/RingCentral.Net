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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().List();
await rc.Revoke();
```

- `result` is of type [ApiVersionsList](./Definitions/ApiVersionsList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [ApiVersionInfo](./Definitions/ApiVersionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#API-Info-readAPIVersion) in API Explorer.

## scimSearchViaGet2

Search/List Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Users`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users().List(scimSearchViaGet2Parameters);
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `scimSearchViaGet2Parameters` is of type [ScimSearchViaGet2Parameters](./Definitions/ScimSearchViaGet2Parameters.cs)
- `result` is of type [ScimUserSearchResponse](./Definitions/ScimUserSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimSearchViaGet2) in API Explorer.

## scimCreateUser2

Create User

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/{version}/Users`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users().Post(scimUser);
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `scimUser` is of type [ScimUser](./Definitions/ScimUser.cs)
- `result` is of type [ScimUserResponse](./Definitions/ScimUserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimCreateUser2) in API Explorer.

## scimGetUser2

Get User

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Users/{scimUserId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users(scimUserId).Get();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimUserResponse](./Definitions/ScimUserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimGetUser2) in API Explorer.

## scimUpdateUser2

Update/Replace User

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/scim/{version}/Users/{scimUserId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users(scimUserId).Put(scimUser);
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `scimUser` is of type [ScimUser](./Definitions/ScimUser.cs)
- `result` is of type [ScimUserResponse](./Definitions/ScimUserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimUpdateUser2) in API Explorer.

## scimDeleteUser2

Delete User

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/scim/{version}/Users/{scimUserId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users(scimUserId).Delete();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimDeleteUser2) in API Explorer.

## scimPatchUser2

Update/Patch User

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/scim/{version}/Users/{scimUserId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users(scimUserId).Patch(scimUserPatch);
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `scimUserPatch` is of type [ScimUserPatch](./Definitions/ScimUserPatch.cs)
- `result` is of type [ScimUserResponse](./Definitions/ScimUserResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimPatchUser2) in API Explorer.

## scimListSchemas2

List Schemas

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Schemas`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Schemas().List();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimSchemaSearchResponse](./Definitions/ScimSchemaSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimListSchemas2) in API Explorer.

## scimGetSchema2

Get Schema

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/Schemas/{uri}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Schemas(uri).Get();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimSchemaResponse](./Definitions/ScimSchemaResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimGetSchema2) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [GetAccountInfoResponse](./Definitions/GetAccountInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountInfo) in API Explorer.

## caiJobStatusGet

Get Async Task Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/ai/status/v1/jobs/{jobId}`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Status().V1().Jobs(jobId).Get();
await rc.Revoke();
```

- `result` is of type [JobStatusResponse](./Definitions/JobStatusResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Status-caiJobStatusGet) in API Explorer.

## getBridge

Get Bridge

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v2/bridges/{bridgeId}`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Bridges(bridgeId).Get(getBridgeParameters);
await rc.Revoke();
```

- `getBridgeParameters` is of type [GetBridgeParameters](./Definitions/GetBridgeParameters.cs)
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-getBridge) in API Explorer.

## deleteBridge

Delete Bridge

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/rcvideo/v2/bridges/{bridgeId}`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Bridges(bridgeId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-deleteBridge) in API Explorer.

## updateBridge

Update Bridge

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/rcvideo/v2/bridges/{bridgeId}`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Bridges(bridgeId).Patch(updateBridgeRequest);
await rc.Revoke();
```

- `updateBridgeRequest` is of type [UpdateBridgeRequest](./Definitions/UpdateBridgeRequest.cs)
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-updateBridge) in API Explorer.

## getToken

Get OAuth Token

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/oauth/token`
Rate Limit Group|`Auth`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().Oauth().Token().Post(getTokenRequest);
await rc.Revoke();
```

- `getTokenRequest` is of type [GetTokenRequest](./Definitions/GetTokenRequest.cs)
- `result` is of type [TokenInfo](./Definitions/TokenInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#OAuth/OIDC-getToken) in API Explorer.

## scimListResourceTypes2

List Resource Types

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/ResourceTypes`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).ResourceTypes().List();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimResourceTypeSearchResponse](./Definitions/ScimResourceTypeSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimListResourceTypes2) in API Explorer.

## scimGetResourceType2

Get Resource Type

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/ResourceTypes/{type}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).ResourceTypes(type).Get();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimResourceTypeResponse](./Definitions/ScimResourceTypeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimGetResourceType2) in API Explorer.

## caiSpeakerDiarize

Speaker Diarization

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/audio/v1/async/speaker-diarize`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Async().SpeakerDiarize().Post(diarizeInput, caiSpeakerDiarizeParameters);
await rc.Revoke();
```

- `diarizeInput` is of type [DiarizeInput](./Definitions/DiarizeInput.cs)
- `caiSpeakerDiarizeParameters` is of type [CaiSpeakerDiarizeParameters](./Definitions/CaiSpeakerDiarizeParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiSpeakerDiarize) in API Explorer.

## caiSpeakerIdentify

Speaker Identification

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/audio/v1/async/speaker-identify`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Async().SpeakerIdentify().Post(identifyInput, caiSpeakerIdentifyParameters);
await rc.Revoke();
```

- `identifyInput` is of type [IdentifyInput](./Definitions/IdentifyInput.cs)
- `caiSpeakerIdentifyParameters` is of
  type [CaiSpeakerIdentifyParameters](./Definitions/CaiSpeakerIdentifyParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiSpeakerIdentify) in API Explorer.

## caiSpeechToText

Speech to Text Conversion

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/audio/v1/async/speech-to-text`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Async().SpeechToText().Post(asrInput, caiSpeechToTextParameters);
await rc.Revoke();
```

- `asrInput` is of type [AsrInput](./Definitions/AsrInput.cs)
- `caiSpeechToTextParameters` is of type [CaiSpeechToTextParameters](./Definitions/CaiSpeechToTextParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiSpeechToText) in API Explorer.

## caiEnrollmentsList

List Enrolled Speakers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/ai/audio/v1/enrollments`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Enrollments().List(caiEnrollmentsListParameters);
await rc.Revoke();
```

- `caiEnrollmentsListParameters` is of
  type [CaiEnrollmentsListParameters](./Definitions/CaiEnrollmentsListParameters.cs)
- `result` is of type [ListEnrolledSpeakers](./Definitions/ListEnrolledSpeakers.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiEnrollmentsList) in API Explorer.

## caiEnrollmentsCreate

Create Speaker Enrollment

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/audio/v1/enrollments`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Enrollments().Post(enrollmentInput);
await rc.Revoke();
```

- `enrollmentInput` is of type [EnrollmentInput](./Definitions/EnrollmentInput.cs)
- `result` is of type [EnrollmentStatus](./Definitions/EnrollmentStatus.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiEnrollmentsCreate) in API Explorer.

## caiEnrollmentsGet

Get Speaker Enrollment Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/ai/audio/v1/enrollments/{enrollmentId}`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Enrollments(enrollmentId).Get();
await rc.Revoke();
```

- `result` is of type [EnrollmentStatus](./Definitions/EnrollmentStatus.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiEnrollmentsGet) in API Explorer.

## caiEnrollmentsDelete

Delete Speaker Enrollment

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/ai/audio/v1/enrollments/{enrollmentId}`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Enrollments(enrollmentId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiEnrollmentsDelete) in API Explorer.

## caiEnrollmentsUpdate

Update Speaker Enrollment

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/ai/audio/v1/enrollments/{enrollmentId}`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Audio().V1().Enrollments(enrollmentId).Patch(enrollmentPatchInput);
await rc.Revoke();
```

- `enrollmentPatchInput` is of type [EnrollmentPatchInput](./Definitions/EnrollmentPatchInput.cs)
- `result` is of type [EnrollmentStatus](./Definitions/EnrollmentStatus.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audio-caiEnrollmentsUpdate) in API Explorer.

## caiAnalyzeInteraction

Interaction Analytics

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/insights/v1/async/analyze-interaction`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Insights().V1().Async().AnalyzeInteraction().Post(interactionInput, caiAnalyzeInteractionParameters);
await rc.Revoke();
```

- `interactionInput` is of type [InteractionInput](./Definitions/InteractionInput.cs)
- `caiAnalyzeInteractionParameters` is of
  type [CaiAnalyzeInteractionParameters](./Definitions/CaiAnalyzeInteractionParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Insights-caiAnalyzeInteraction) in API Explorer.

## getExtensionRecordings

List User Recordings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v1/account/{accountId}/extension/{extensionId}/recordings`
Rate Limit Group|`Light`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V1().Account(accountId).Extension(extensionId).Recordings().Get(getExtensionRecordingsParameters);
await rc.Revoke();
```

- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `getExtensionRecordingsParameters` is of
  type [GetExtensionRecordingsParameters](./Definitions/GetExtensionRecordingsParameters.cs)
- `result` is of type [CloudRecordings](./Definitions/CloudRecordings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-getExtensionRecordings) in API Explorer.

## rcvListDelegators

Get Delegators

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v1/accounts/{accountId}/extensions/{extensionId}/delegators`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V1().Accounts(accountId).Extensions(extensionId).Delegators().Get(rcvListDelegatorsParameters);
await rc.Revoke();
```

- `rcvListDelegatorsParameters` is of type [RcvListDelegatorsParameters](./Definitions/RcvListDelegatorsParameters.cs)
- `result` is of type [DelegatorsListResult](./Definitions/DelegatorsListResult.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Delegation-Management-rcvListDelegators) in API Explorer.

## createBridge

Create Bridge

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges`
Rate Limit Group|`Heavy`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Account(accountId).Extension(extensionId).Bridges().Post(createBridgeRequest);
await rc.Revoke();
```

- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createBridgeRequest` is of type [CreateBridgeRequest](./Definitions/CreateBridgeRequest.cs)
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-createBridge) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().Oauth().Revoke().Post(revokeTokenRequest);
await rc.Revoke();
```

- `revokeTokenRequest` is of type [RevokeTokenRequest](./Definitions/RevokeTokenRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth/OIDC-revokeToken) in API Explorer.

## getAccountInfoV2

Get Account Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v2/accounts/{accountId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Get();
await rc.Revoke();
```

- `result` is of type [AccountInfo](./Definitions/AccountInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-getAccountInfoV2) in API Explorer.

## addDeviceToInventory

Add Phone to Inventory

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/device-inventory`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).DeviceInventory().Post(addDeviceToInventoryRequest);
await rc.Revoke();
```

- `addDeviceToInventoryRequest` is of type [AddDeviceToInventoryRequest](./Definitions/AddDeviceToInventoryRequest.cs)
- `result` is of type [AddDeviceToInventoryResponse](./Definitions/AddDeviceToInventoryResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-addDeviceToInventory) in API Explorer.

## deleteDeviceFromInventory

Delete Device from Inventory

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v2/accounts/{accountId}/device-inventory`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).DeviceInventory().Delete(deleteDeviceFromInventoryRequest);
await rc.Revoke();
```

- `deleteDeviceFromInventoryRequest` is of
  type [DeleteDeviceFromInventoryRequest](./Definitions/DeleteDeviceFromInventoryRequest.cs)
- `result` is of type [DeleteDeviceFromInventoryResponse](./Definitions/DeleteDeviceFromInventoryResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-deleteDeviceFromInventory) in API Explorer.

## bulkAddDevicesV2

Add BYOD Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/devices/bulk-add`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`AddRemoveDevices`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Devices().BulkAdd().Post(bulkAddDevicesRequest);
await rc.Revoke();
```

- `bulkAddDevicesRequest` is of type [BulkAddDevicesRequest](./Definitions/BulkAddDevicesRequest.cs)
- `result` is of type [BulkAddDevicesResponse](./Definitions/BulkAddDevicesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-bulkAddDevicesV2) in API Explorer.

## bulkAssignLicensesV2

Assign Account Licenses

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/licenses/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Licenses().BulkAssign().Post(bulkManageLicensesRequest);
await rc.Revoke();
```

- `bulkManageLicensesRequest` is of type [BulkManageLicensesRequest](./Definitions/BulkManageLicensesRequest.cs)
- `result` is of type [BulkManageLicensesResponse](./Definitions/BulkManageLicensesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Licenses-bulkAssignLicensesV2) in API Explorer.

## listAccountPhoneNumbersV2

List Account Phone Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers().Get(listAccountPhoneNumbersV2Parameters);
await rc.Revoke();
```

- `listAccountPhoneNumbersV2Parameters` is of
  type [ListAccountPhoneNumbersV2Parameters](./Definitions/ListAccountPhoneNumbersV2Parameters.cs)
- `result` is of type [AccountPhoneNumberList](./Definitions/AccountPhoneNumberList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listAccountPhoneNumbersV2) in API Explorer.

## deleteNumbersFromInventoryV2

Delete Numbers from Inventory

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers().Delete(deletePhoneNumbersRequest);
await rc.Revoke();
```

- `deletePhoneNumbersRequest` is of type [DeletePhoneNumbersRequest](./Definitions/DeletePhoneNumbersRequest.cs)
- `result` is of type [DeletePhoneNumbersResponse](./Definitions/DeletePhoneNumbersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-deleteNumbersFromInventoryV2) in API
Explorer.

## assignPhoneNumberV2

Assign Phone Number

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers/{phoneNumberId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers(phoneNumberId).Patch(assignPhoneNumberRequest);
await rc.Revoke();
```

- `assignPhoneNumberRequest` is of type [AssignPhoneNumberRequest](./Definitions/AssignPhoneNumberRequest.cs)
- `result` is of type [AccountPhoneNumberInfo](./Definitions/AccountPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-assignPhoneNumberV2) in API Explorer.

## replacePhoneNumberV2

Replace Phone Number

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers/{phoneNumberId}/replace`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers(phoneNumberId).Replace().Post(replacePhoneNumberRequest);
await rc.Revoke();
```

- `replacePhoneNumberRequest` is of type [ReplacePhoneNumberRequest](./Definitions/ReplacePhoneNumberRequest.cs)
- `result` is of type [AccountPhoneNumberInfo](./Definitions/AccountPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-replacePhoneNumberV2) in API Explorer.

## sendWelcomeEmailV2

Send/Resend Welcome Email

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/send-welcome-email`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).SendWelcomeEmail().Post(sendWelcomeEmailV2Request);
await rc.Revoke();
```

- `sendWelcomeEmailV2Request` is of type [SendWelcomeEmailV2Request](./Definitions/SendWelcomeEmailV2Request.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Company-sendWelcomeEmailV2) in API Explorer.

## addressBookBulkUpload

Upload Multiple User Contacts

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AddressBookBulkUpload().Post(addressBookBulkUploadRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `addressBookBulkUploadRequest` is of
  type [AddressBookBulkUploadRequest](./Definitions/AddressBookBulkUploadRequest.cs)
- `result` is of type [AddressBookBulkUploadResponse](./Definitions/AddressBookBulkUploadResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-addressBookBulkUpload) in API Explorer.

## auditTrailSearch

Search Audit Trail Data

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/audit-trail/search`
Rate Limit Group|`Heavy`
App Permission|`ReadAuditTrail`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AuditTrail().Search().Post(accountHistorySearchPublicRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `accountHistorySearchPublicRequest` is of
  type [AccountHistorySearchPublicRequest](./Definitions/AccountHistorySearchPublicRequest.cs)
- `result` is of type [AccountHistorySearchPublicResponse](./Definitions/AccountHistorySearchPublicResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Audit-Trail-auditTrailSearch) in API Explorer.

## listCallMonitoringGroups

List Call Monitoring Groups

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Get(listCallMonitoringGroupsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallMonitoringGroupsParameters` is of
  type [ListCallMonitoringGroupsParameters](./Definitions/ListCallMonitoringGroupsParameters.cs)
- `result` is of type [CallMonitoringGroups](./Definitions/CallMonitoringGroups.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroups) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCallMonitoringGroupRequest` is of
  type [CreateCallMonitoringGroupRequest](./Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./Definitions/CallMonitoringGroup.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-createCallMonitoringGroup) in API
Explorer.

## updateCallMonitoringGroup

Update Call Monitoring Group

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Groups`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCallMonitoringGroupRequest` is of
  type [CreateCallMonitoringGroupRequest](./Definitions/CreateCallMonitoringGroupRequest.cs)
- `result` is of type [CallMonitoringGroup](./Definitions/CallMonitoringGroup.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroup) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-deleteCallMonitoringGroup) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./Definitions/CallQueueBulkAssignResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-assignMultipleCallQueueMembers) in API
Explorer.

## listCallQueueMembers

List Call Queue Members

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/members`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallQueueMembersParameters` is of
  type [ListCallQueueMembersParameters](./Definitions/ListCallQueueMembersParameters.cs)
- `result` is of type [CallQueueMembers](./Definitions/CallQueueMembers.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallQueuePresence](./Definitions/CallQueuePresence.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Presence().Put(callQueueUpdatePresence);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueUpdatePresence` is of type [CallQueueUpdatePresence](./Definitions/CallQueueUpdatePresence.cs)
- `result` is of type [CallQueuePresence](./Definitions/CallQueuePresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateCallQueuePresence) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Get(readDeviceParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readDeviceParameters` is of type [ReadDeviceParameters](./Definitions/ReadDeviceParameters.cs)
- `result` is of type [DeviceResource](./Definitions/DeviceResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Put(accountDeviceUpdate, updateDeviceParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `accountDeviceUpdate` is of type [AccountDeviceUpdate](./Definitions/AccountDeviceUpdate.cs)
- `updateDeviceParameters` is of type [UpdateDeviceParameters](./Definitions/UpdateDeviceParameters.cs)
- `result` is of type [DeviceResource](./Definitions/DeviceResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDevice) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listDirectoryEntriesParameters` is of
  type [ListDirectoryEntriesParameters](./Definitions/ListDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./Definitions/DirectoryResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries(entryId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [ContactResource](./Definitions/ContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryEntry) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest, searchDirectoryEntriesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `searchDirectoryEntriesRequest` is of
  type [SearchDirectoryEntriesRequest](./Definitions/SearchDirectoryEntriesRequest.cs)
- `searchDirectoryEntriesParameters` is of
  type [SearchDirectoryEntriesParameters](./Definitions/SearchDirectoryEntriesParameters.cs)
- `result` is of type [DirectoryResource](./Definitions/DirectoryResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-searchDirectoryEntries) in API Explorer.

## readDirectoryFederation

Get Account Federation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/directory/federation`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().Get(readDirectoryFederationParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readDirectoryFederationParameters` is of
  type [ReadDirectoryFederationParameters](./Definitions/ReadDirectoryFederationParameters.cs)
- `result` is of type [FederationResource](./Definitions/FederationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Internal-Contacts-readDirectoryFederation) in API Explorer.

## listEmergencyLocations

List Emergency Locations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-locations`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().List(listEmergencyLocationsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listEmergencyLocationsParameters` is of
  type [ListEmergencyLocationsParameters](./Definitions/ListEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationsResource](./Definitions/EmergencyLocationsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listEmergencyLocations) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations().Post(emergencyLocationInfoRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `emergencyLocationInfoRequest` is of
  type [EmergencyLocationInfoRequest](./Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createEmergencyLocation) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Get(readEmergencyLocationParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readEmergencyLocationParameters` is of
  type [ReadEmergencyLocationParameters](./Definitions/ReadEmergencyLocationParameters.cs)
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readEmergencyLocation) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Put(emergencyLocationInfoRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `emergencyLocationInfoRequest` is of
  type [EmergencyLocationInfoRequest](./Definitions/EmergencyLocationInfoRequest.cs)
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateEmergencyLocation) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyLocations(locationId).Delete(deleteEmergencyLocationParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `deleteEmergencyLocationParameters` is of
  type [DeleteEmergencyLocationParameters](./Definitions/DeleteEmergencyLocationParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteEmergencyLocation) in API
Explorer.

## listExtensions

List Extensions

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension().List(listExtensionsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listExtensionsParameters` is of type [ListExtensionsParameters](./Definitions/ListExtensionsParameters.cs)
- `result` is of type [GetExtensionListResponse](./Definitions/GetExtensionListResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Post(extensionCreationRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `extensionCreationRequest` is of type [ExtensionCreationRequest](./Definitions/ExtensionCreationRequest.cs)
- `result` is of type [ExtensionCreationResponse](./Definitions/ExtensionCreationResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetExtensionInfoResponse](./Definitions/GetExtensionInfoResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./Definitions/ExtensionUpdateRequest.cs)
- `result` is of type [GetExtensionInfoResponse](./Definitions/GetExtensionInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateExtension) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ExtensionBulkUpdate().Post(extensionBulkUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `extensionBulkUpdateRequest` is of type [ExtensionBulkUpdateRequest](./Definitions/ExtensionBulkUpdateRequest.cs)
- `result` is of type [ExtensionBulkUpdateTaskResource](./Definitions/ExtensionBulkUpdateTaskResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-extensionBulkUpdate) in API Explorer.

## listExtensionActiveCalls

List User Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionActiveCallsParameters` is of
  type [ListExtensionActiveCallsParameters](./Definitions/ListExtensionActiveCallsParameters.cs)
- `result` is of type [CallLogResponse](./Definitions/CallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listExtensionActiveCalls) in API Explorer.

## listAnsweringRules

List Call Handling Rules

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserAnsweringRules`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listAnsweringRulesParameters` is of
  type [ListAnsweringRulesParameters](./Definitions/ListAnsweringRulesParameters.cs)
- `result` is of type [UserAnsweringRuleList](./Definitions/UserAnsweringRuleList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./Definitions/CreateAnsweringRuleRequest.cs)
- `result` is of type [CustomAnsweringRuleInfo](./Definitions/CustomAnsweringRuleInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(readAnsweringRuleParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readAnsweringRuleParameters` is of type [ReadAnsweringRuleParameters](./Definitions/ReadAnsweringRuleParameters.cs)
- `result` is of type [AnsweringRuleInfo](./Definitions/AnsweringRuleInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./Definitions/UpdateAnsweringRuleRequest.cs)
- `result` is of type [AnsweringRuleInfo](./Definitions/AnsweringRuleInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteAnsweringRule) in API Explorer.

## listUserAssignedRoles

List User Assigned Roles

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AssignedRole().Get(listUserAssignedRolesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listUserAssignedRolesParameters` is of
  type [ListUserAssignedRolesParameters](./Definitions/ListUserAssignedRolesParameters.cs)
- `result` is of type [AssignedRolesResource](./Definitions/AssignedRolesResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-listUserAssignedRoles) in API Explorer.

## updateUserAssignedRoles

Update User Assigned Roles

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`EditAssignedRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AssignedRole().Put(assignedRolesResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `assignedRolesResource` is of type [AssignedRolesResource](./Definitions/AssignedRolesResource.cs)
- `result` is of type [AssignedRolesResource](./Definitions/AssignedRolesResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-updateUserAssignedRoles) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Get(readAuthorizationProfileParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readAuthorizationProfileParameters` is of
  type [ReadAuthorizationProfileParameters](./Definitions/ReadAuthorizationProfileParameters.cs)
- `result` is of type [AuthProfileResource](./Definitions/AuthProfileResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetUserBusinessHoursResponse](./Definitions/GetUserBusinessHoursResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `userBusinessHoursUpdateRequest` is of
  type [UserBusinessHoursUpdateRequest](./Definitions/UserBusinessHoursUpdateRequest.cs)
- `result` is of type [UserBusinessHoursUpdateResponse](./Definitions/UserBusinessHoursUpdateResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Business-Hours-updateUserBusinessHours) in API Explorer.

## readUserCallLog

List User Call Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserCallLogParameters` is of type [ReadUserCallLogParameters](./Definitions/ReadUserCallLogParameters.cs)
- `result` is of type [CallLogResponse](./Definitions/CallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallLog) in API Explorer.

## deleteUserCallLog

Delete User Call Records

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`EditCallLog`
User Permission|`EditCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./Definitions/DeleteUserCallLogParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-deleteUserCallLog) in API Explorer.

## readUserCallRecord

Get User Call Record(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(readUserCallRecordParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserCallRecordParameters` is of
  type [ReadUserCallRecordParameters](./Definitions/ReadUserCallRecordParameters.cs)
- `result` is of type [CallLogRecord](./Definitions/CallLogRecord.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readUserCallRecord) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./Definitions/SyncUserCallLogParameters.cs)
- `result` is of type [CallLogSyncResponse](./Definitions/CallLogSyncResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncUserCallLog) in API Explorer.

## updateUserCallQueues

Update User Call Queues

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCallQueuePresence`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueues().Put(userCallQueues);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `userCallQueues` is of type [UserCallQueues](./Definitions/UserCallQueues.cs)
- `result` is of type [UserCallQueues](./Definitions/UserCallQueues.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateUserCallQueues) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [ExtensionCallerIdInfo](./Definitions/ExtensionCallerIdInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfoRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionCallerIdInfoRequest` is of
  type [ExtensionCallerIdInfoRequest](./Definitions/ExtensionCallerIdInfoRequest.cs)
- `result` is of type [ExtensionCallerIdInfo](./Definitions/ExtensionCallerIdInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createInternalTextMessageRequest` is of
  type [CreateInternalTextMessageRequest](./Definitions/CreateInternalTextMessageRequest.cs)
- `result` is of type [GetInternalTextMessageInfoResponse](./Definitions/GetInternalTextMessageInfoResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Get(readConferencingSettingsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readConferencingSettingsParameters` is of
  type [ReadConferencingSettingsParameters](./Definitions/ReadConferencingSettingsParameters.cs)
- `result` is of type [GetConferencingInfoResponse](./Definitions/GetConferencingInfoResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateConferencingInfoRequest` is of
  type [UpdateConferencingInfoRequest](./Definitions/UpdateConferencingInfoRequest.cs)
- `result` is of type [GetConferencingInfoResponse](./Definitions/GetConferencingInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateConferencingSettings) in API Explorer.

## listFavoriteContacts

List Favorite Contacts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite`
Rate Limit Group|`Light`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [FavoriteContactList](./Definitions/FavoriteContactList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `favoriteCollection` is of type [FavoriteCollection](./Definitions/FavoriteCollection.cs)
- `result` is of type [FavoriteContactList](./Definitions/FavoriteContactList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateFavoriteContactList) in API
Explorer.

## readExtensionFeatures

Get User Features

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/features`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Features().Get(readExtensionFeaturesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readExtensionFeaturesParameters` is of
  type [ReadExtensionFeaturesParameters](./Definitions/ReadExtensionFeaturesParameters.cs)
- `result` is of type [FeatureList](./Definitions/FeatureList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Features-readExtensionFeatures) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Post(createCustomUserGreetingRequest, createCustomUserGreetingParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createCustomUserGreetingRequest` is of
  type [CreateCustomUserGreetingRequest](./Definitions/CreateCustomUserGreetingRequest.cs)
- `createCustomUserGreetingParameters` is of
  type [CreateCustomUserGreetingParameters](./Definitions/CreateCustomUserGreetingParameters.cs)
- `result` is of type [CustomUserGreetingInfo](./Definitions/CustomUserGreetingInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [CustomUserGreetingInfo](./Definitions/CustomUserGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readCustomGreeting) in API Explorer.

## listMessages

List Messages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listMessagesParameters` is of type [ListMessagesParameters](./Definitions/ListMessagesParameters.cs)
- `result` is of type [GetMessageList](./Definitions/GetMessageList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().DeleteAll(deleteMessageByFilterParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteMessageByFilterParameters` is of
  type [DeleteMessageByFilterParameters](./Definitions/DeleteMessageByFilterParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessageByFilter) in API Explorer.

## readMessage

Get Message(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Light`
App Permission|`ReadMessages`
User Permission|`ReadMessages`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetMessageInfoResponse](./Definitions/GetMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessage) in API Explorer.

## updateMessage

Update Message(s)

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateMessageRequest` is of type [UpdateMessageRequest](./Definitions/UpdateMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./Definitions/GetMessageInfoResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageBulkRequest, deleteMessageParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteMessageBulkRequest` is of type [DeleteMessageBulkRequest](./Definitions/DeleteMessageBulkRequest.cs)
- `deleteMessageParameters` is of type [DeleteMessageParameters](./Definitions/DeleteMessageParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-deleteMessage) in API Explorer.

## patchMessage

Patch Message(s)

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}`
Rate Limit Group|`Medium`
App Permission|`EditMessages`
User Permission|`EditMessages`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Patch(patchMessageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `patchMessageRequest` is of type [PatchMessageRequest](./Definitions/PatchMessageRequest.cs)
- `result` is of type [GetMessageInfoResponse](./Definitions/GetMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-patchMessage) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Get(readUserPresenceStatusParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readUserPresenceStatusParameters` is of
  type [ReadUserPresenceStatusParameters](./Definitions/ReadUserPresenceStatusParameters.cs)
- `result` is of type [GetPresenceInfo](./Definitions/GetPresenceInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Put(presenceInfoRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `presenceInfoRequest` is of type [PresenceInfoRequest](./Definitions/PresenceInfoRequest.cs)
- `result` is of type [PresenceInfoResponse](./Definitions/PresenceInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUserPresenceStatus) in API Explorer.

## readUserProfileImageLegacy

Get User Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readUserProfileImageLegacy) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Post(createUserProfileImageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createUserProfileImageRequest` is of
  type [CreateUserProfileImageRequest](./Definitions/CreateUserProfileImageRequest.cs)
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Put(updateUserProfileImageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateUserProfileImageRequest` is of
  type [UpdateUserProfileImageRequest](./Definitions/UpdateUserProfileImageRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-updateUserProfileImage) in API Explorer.

## deleteUserProfileImage

Delete User Profile Image

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserInfo`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-deleteUserProfileImage) in API Explorer.

## readScaledProfileImage

Get Scaled Profile Image

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get(readScaledProfileImageParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readScaledProfileImageParameters` is of
  type [ReadScaledProfileImageParameters](./Definitions/ReadScaledProfileImageParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-readScaledProfileImage) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `makeRingOutRequest` is of type [MakeRingOutRequest](./Definitions/MakeRingOutRequest.cs)
- `result` is of type [GetRingOutStatusResponse](./Definitions/GetRingOutStatusResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [GetRingOutStatusResponse](./Definitions/GetRingOutStatusResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#RingOut-deleteRingOutCall) in API Explorer.

## getForwardAllCompanyCalls

Get Forward All Company Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/forward-all-calls`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ForwardAllCalls().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [ForwardAllCompanyCallsInfo](./Definitions/ForwardAllCompanyCallsInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-getForwardAllCompanyCalls) in API
Explorer.

## updateForwardAllCompanyCalls

Update Forward All Company Calls

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/forward-all-calls`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyAnsweringRules`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ForwardAllCalls().Patch(forwardAllCompanyCallsRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `forwardAllCompanyCallsRequest` is of
  type [ForwardAllCompanyCallsRequest](./Definitions/ForwardAllCompanyCallsRequest.cs)
- `result` is of type [ForwardAllCompanyCallsInfo](./Definitions/ForwardAllCompanyCallsInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateForwardAllCompanyCalls) in API
Explorer.

## readIVRPromptContent

Get IVR Prompt Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts/{promptId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().Get(readIVRPromptContentParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readIVRPromptContentParameters` is of
  type [ReadIVRPromptContentParameters](./Definitions/ReadIVRPromptContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRPromptContent) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMessageStoreReportRequest` is of
  type [CreateMessageStoreReportRequest](./Definitions/CreateMessageStoreReportRequest.cs)
- `result` is of type [MessageStoreReport](./Definitions/MessageStoreReport.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreReport](./Definitions/MessageStoreReport.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportTask) in API
Explorer.

## readCallRecordingContent

Get Call Recording Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/recording/{recordingId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadCallRecording`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().Get(readCallRecordingContentParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCallRecordingContentParameters` is of
  type [ReadCallRecordingContentParameters](./Definitions/ReadCallRecordingContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecordingContent) in API Explorer.

## listSites

List Sites

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SitesList](./Definitions/SitesList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-listSites) in API Explorer.

## createSite

Create Site

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites().Post(createSiteRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createSiteRequest` is of type [CreateSiteRequest](./Definitions/CreateSiteRequest.cs)
- `result` is of type [SiteInfo](./Definitions/SiteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-createSite) in API Explorer.

## readSite

Get Site

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SiteInfo](./Definitions/SiteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-readSite) in API Explorer.

## updateSite

Update Site

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`Sites`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Put(siteUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `siteUpdateRequest` is of type [SiteUpdateRequest](./Definitions/SiteUpdateRequest.cs)
- `result` is of type [SiteInfo](./Definitions/SiteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-updateSite) in API Explorer.

## deleteSite

Delete Site

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`Sites`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-deleteSite) in API Explorer.

## assignMultipleSites

Edit Sites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}/bulk-assign`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`Sites`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).BulkAssign().Post(siteMembersBulkUpdate);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `siteMembersBulkUpdate` is of type [SiteMembersBulkUpdate](./Definitions/SiteMembersBulkUpdate.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-assignMultipleSites) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().CallOut().Post(makeCallOutRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `makeCallOutRequest` is of type [MakeCallOutRequest](./Definitions/MakeCallOutRequest.cs)
- `result` is of type [CallSession](./Definitions/CallSession.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Conference().Post();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallSession](./Definitions/CallSession.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Get(readCallSessionStatusParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCallSessionStatusParameters` is of
  type [ReadCallSessionStatusParameters](./Definitions/ReadCallSessionStatusParameters.cs)
- `result` is of type [CallSessionObject](./Definitions/CallSessionObject.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-deleteCallSession) in API Explorer.

## readDefaultRole

Get Default User Role

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/default`
Rate Limit Group|`Light`
App Permission|`RoleManagement`
User Permission|`Roles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole().Default().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-readDefaultRole) in API Explorer.

## updateDefaultUserRole

Set Default User Role

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/default`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`Roles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole().Default().Put(defaultUserRoleRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `defaultUserRoleRequest` is of type [DefaultUserRoleRequest](./Definitions/DefaultUserRoleRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-updateDefaultUserRole) in API Explorer.

## assignMultipleUserRoles

Assign Multiple User Roles

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/{roleId}/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`RoleManagement`
User Permission|`EditUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole(roleId).BulkAssign().Post(bulkRoleAssignResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bulkRoleAssignResource` is of type [BulkRoleAssignResource](./Definitions/BulkRoleAssignResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-assignMultipleUserRoles) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().Post(createSipRegistrationRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createSipRegistrationRequest` is of
  type [CreateSipRegistrationRequest](./Definitions/CreateSipRegistrationRequest.cs)
- `result` is of type [CreateSipRegistrationResponse](./Definitions/CreateSipRegistrationResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Device-SIP-Registration-createSIPRegistration) in API
Explorer.

## listFaxCoverPages

List Fax Cover Pages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/fax-cover-page`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./Definitions/ListFaxCoverPagesParameters.cs)
- `result` is of type [ListFaxCoverPagesResponse](./Definitions/ListFaxCoverPagesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Fax-listFaxCoverPages) in API Explorer.

## listSubscriptions

List Subscriptions

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/subscription`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [SubscriptionListResource](./Definitions/SubscriptionListResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription().Post(createSubscriptionRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./Definitions/CreateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Put(updateSubscriptionRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `updateSubscriptionRequest` is of type [UpdateSubscriptionRequest](./Definitions/UpdateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-deleteSubscription) in API Explorer.

## scimSearchViaPost2

Search/List Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/scim/{version}/Users/dotSearch`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).Users().DotSearch().Post(scimSearchRequest);
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `scimSearchRequest` is of type [ScimSearchRequest](./Definitions/ScimSearchRequest.cs)
- `result` is of type [ScimUserSearchResponse](./Definitions/ScimUserSearchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimSearchViaPost2) in API Explorer.

## authorize

OAuth 2.0 Authorization

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/oauth/authorize`
Rate Limit Group|`Auth`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().Oauth().Authorize().Get();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth/OIDC-authorize) in API Explorer.

## authorize2

OAuth 2.0 Authorization (POST)

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/oauth/authorize`
Rate Limit Group|`Auth`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().Oauth().Authorize().Post(authorizeRequest);
await rc.Revoke();
```

- `authorizeRequest` is of type [AuthorizeRequest](./Definitions/AuthorizeRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#OAuth/OIDC-authorize2) in API Explorer.

## readCompanyCallLog

List Company Call Records

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-log`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().List(readCompanyCallLogParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCompanyCallLogParameters` is of
  type [ReadCompanyCallLogParameters](./Definitions/ReadCompanyCallLogParameters.cs)
- `result` is of type [CallLogResponse](./Definitions/CallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallLog) in API Explorer.

## readCompanyCallRecord

Get Company Call Record(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-log/{callRecordId}`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`FullCompanyCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).Get(readCompanyCallRecordParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readCompanyCallRecordParameters` is of
  type [ReadCompanyCallRecordParameters](./Definitions/ReadCompanyCallRecordParameters.cs)
- `result` is of type [CallLogRecord](./Definitions/CallLogRecord.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-readCompanyCallRecord) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().Post(createCompanyGreetingRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createCompanyGreetingRequest` is of
  type [CreateCompanyGreetingRequest](./Definitions/CreateCompanyGreetingRequest.cs)
- `result` is of type [CustomCompanyGreetingInfo](./Definitions/CustomCompanyGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-createCompanyGreeting) in API Explorer.

## readIVRMenuList

Get IVR Menu list

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-menus`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [IVRMenuList](./Definitions/IVRMenuList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-readIVRMenuList) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Post(iVRMenuInfo);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `iVRMenuInfo` is of type [IVRMenuInfo](./Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./Definitions/IVRMenuInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [IVRMenuInfo](./Definitions/IVRMenuInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Put(iVRMenuInfo);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `iVRMenuInfo` is of type [IVRMenuInfo](./Definitions/IVRMenuInfo.cs)
- `result` is of type [IVRMenuInfo](./Definitions/IVRMenuInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Presence().Get(readAccountPresenceParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readAccountPresenceParameters` is of
  type [ReadAccountPresenceParameters](./Definitions/ReadAccountPresenceParameters.cs)
- `result` is of type [AccountPresenceInfo](./Definitions/AccountPresenceInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [GetCallRecordingResponse](./Definitions/GetCallRecordingResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recordings-readCallRecording) in API Explorer.

## readSiteIvrSettings

Get Site IVR Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Ivr().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SiteIVRSettings](./Definitions/SiteIVRSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-readSiteIvrSettings) in API Explorer.

## updateSiteIvrSettings

Update Site IVR Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`Sites`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Ivr().Put(siteIVRSettingsUpdate);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `siteIVRSettingsUpdate` is of type [SiteIVRSettingsUpdate](./Definitions/SiteIVRSettingsUpdate.cs)
- `result` is of type [SiteIVRSettings](./Definitions/SiteIVRSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-updateSiteIvrSettings) in API Explorer.

## listUserTemplates

List User Templates

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/templates`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyInfo`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Templates().List(listUserTemplatesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listUserTemplatesParameters` is of type [ListUserTemplatesParameters](./Definitions/ListUserTemplatesParameters.cs)
- `result` is of type [UserTemplates](./Definitions/UserTemplates.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [TemplateInfo](./Definitions/TemplateInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-readUserTemplate) in API Explorer.

## listUserRoles

List Company User Roles

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole().List(listUserRolesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listUserRolesParameters` is of type [ListUserRolesParameters](./Definitions/ListUserRolesParameters.cs)
- `result` is of type [RolesCollectionResource](./Definitions/RolesCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-listUserRoles) in API Explorer.

## createCustomRole

Create Custom Role

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`EditUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole().Post(roleResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `roleResource` is of type [RoleResource](./Definitions/RoleResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-createCustomRole) in API Explorer.

## readUserRole

Get User Role

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/{roleId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole(roleId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [RoleResource](./Definitions/RoleResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-readUserRole) in API Explorer.

## updateUserRole

Update User Role

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/{roleId}`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`EditUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole(roleId).Put(roleResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `roleResource` is of type [RoleResource](./Definitions/RoleResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-updateUserRole) in API Explorer.

## deleteCustomRole

Delete Custom Role

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/user-role/{roleId}`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`EditUserRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).UserRole(roleId).Delete(deleteCustomRoleParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `deleteCustomRoleParameters` is of type [DeleteCustomRoleParameters](./Definitions/DeleteCustomRoleParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-deleteCustomRole) in API Explorer.

## listStates

List States

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/state`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().State().List(listStatesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listStatesParameters` is of type [ListStatesParameters](./Definitions/ListStatesParameters.cs)
- `result` is of type [GetStateListResponse](./Definitions/GetStateListResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetStateInfoResponse](./Definitions/GetStateInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readState) in API Explorer.

## listGlipChatsNew

List Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats().List(listGlipChatsNewParameters);
await rc.Revoke();
```

- `listGlipChatsNewParameters` is of type [ListGlipChatsNewParameters](./Definitions/ListGlipChatsNewParameters.cs)
- `result` is of type [TMChatList](./Definitions/TMChatList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listGlipChatsNew) in API Explorer.

## readGlipChatNew

Get Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats/{chatId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Get();
await rc.Revoke();
```

- `result` is of type [TMChatInfo](./Definitions/TMChatInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-readGlipChatNew) in API Explorer.

## readGlipEventsNew

List User Events

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/events`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Events().List(readGlipEventsNewParameters);
await rc.Revoke();
```

- `readGlipEventsNewParameters` is of type [ReadGlipEventsNewParameters](./Definitions/ReadGlipEventsNewParameters.cs)
- `result` is of type [TMEventList](./Definitions/TMEventList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readGlipEventsNew) in API Explorer.

## createEventNew

Create Event

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/events`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Events().Post(tMCreateEventRequest);
await rc.Revoke();
```

- `tMCreateEventRequest` is of type [TMCreateEventRequest](./Definitions/TMCreateEventRequest.cs)
- `result` is of type [TMEventInfo](./Definitions/TMEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventNew) in API Explorer.

## readEventNew

Get Event

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Events(eventId).Get();
await rc.Revoke();
```

- `result` is of type [TMEventInfo](./Definitions/TMEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-readEventNew) in API Explorer.

## updateEventNew

Update Event

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/team-messaging/v1/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Events(eventId).Put(tMCreateEventRequest);
await rc.Revoke();
```

- `tMCreateEventRequest` is of type [TMCreateEventRequest](./Definitions/TMCreateEventRequest.cs)
- `result` is of type [TMEventInfo](./Definitions/TMEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-updateEventNew) in API Explorer.

## deleteEventNew

Delete Event

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/events/{eventId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Events(eventId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-deleteEventNew) in API Explorer.

## createGlipFileNew

Upload File

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/files`
Rate Limit Group|`Heavy`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Files().Post(createGlipFileNewRequest, createGlipFileNewParameters);
await rc.Revoke();
```

- `createGlipFileNewRequest` is of type [CreateGlipFileNewRequest](./Definitions/CreateGlipFileNewRequest.cs)
- `createGlipFileNewParameters` is of type [CreateGlipFileNewParameters](./Definitions/CreateGlipFileNewParameters.cs)
- `result` is of type [TMAddFileRequest](./Definitions/TMAddFileRequest.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipFileNew) in API Explorer.

## readUserNoteNew

Get Note

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Get();
await rc.Revoke();
```

- `result` is of type [TMNoteWithBodyInfo](./Definitions/TMNoteWithBodyInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-readUserNoteNew) in API Explorer.

## deleteNoteNew

Delete Note

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-deleteNoteNew) in API Explorer.

## patchNoteNew

Update Note

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/team-messaging/v1/notes/{noteId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Patch(tMCreateNoteRequest, patchNoteNewParameters);
await rc.Revoke();
```

- `tMCreateNoteRequest` is of type [TMCreateNoteRequest](./Definitions/TMCreateNoteRequest.cs)
- `patchNoteNewParameters` is of type [PatchNoteNewParameters](./Definitions/PatchNoteNewParameters.cs)
- `result` is of type [TMNoteInfo](./Definitions/TMNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-patchNoteNew) in API Explorer.

## readTaskNew

Get Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Tasks(taskId).Get();
await rc.Revoke();
```

- `result` is of type [TMTaskInfo](./Definitions/TMTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-readTaskNew) in API Explorer.

## deleteTaskNew

Delete Task

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Tasks(taskId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-deleteTaskNew) in API Explorer.

## patchTaskNew

Update Task

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/team-messaging/v1/tasks/{taskId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Tasks(taskId).Patch(tMUpdateTaskRequest);
await rc.Revoke();
```

- `tMUpdateTaskRequest` is of type [TMUpdateTaskRequest](./Definitions/TMUpdateTaskRequest.cs)
- `result` is of type [TMTaskList](./Definitions/TMTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-patchTaskNew) in API Explorer.

## listGlipTeamsNew

List Teams

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/teams`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams().List(listGlipTeamsNewParameters);
await rc.Revoke();
```

- `listGlipTeamsNewParameters` is of type [ListGlipTeamsNewParameters](./Definitions/ListGlipTeamsNewParameters.cs)
- `result` is of type [TMTeamList](./Definitions/TMTeamList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-listGlipTeamsNew) in API Explorer.

## createGlipTeamNew

Create Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams().Post(tMCreateTeamRequest);
await rc.Revoke();
```

- `tMCreateTeamRequest` is of type [TMCreateTeamRequest](./Definitions/TMCreateTeamRequest.cs)
- `result` is of type [TMTeamInfo](./Definitions/TMTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-createGlipTeamNew) in API Explorer.

## readGlipTeamNew

Get Team

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/teams/{chatId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Get();
await rc.Revoke();
```

- `result` is of type [TMTeamInfo](./Definitions/TMTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipTeamNew) in API Explorer.

## deleteGlipTeamNew

Delete Team

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-deleteGlipTeamNew) in API Explorer.

## patchGlipTeamNew

Update Team

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/team-messaging/v1/teams/{chatId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Patch(tMUpdateTeamRequest);
await rc.Revoke();
```

- `tMUpdateTeamRequest` is of type [TMUpdateTeamRequest](./Definitions/TMUpdateTeamRequest.cs)
- `result` is of type [TMTeamInfo](./Definitions/TMTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipTeamNew) in API Explorer.

## readGlipPersonNew

Get Person

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/persons/{personId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Persons(personId).Get();
await rc.Revoke();
```

- `result` is of type [TMPersonInfo](./Definitions/TMPersonInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Profile-readGlipPersonNew) in API Explorer.

## caiPunctuate

Smart Punctuation

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/text/v1/async/punctuate`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Text().V1().Async().Punctuate().Post(punctuateInput, caiPunctuateParameters);
await rc.Revoke();
```

- `punctuateInput` is of type [PunctuateInput](./Definitions/PunctuateInput.cs)
- `caiPunctuateParameters` is of type [CaiPunctuateParameters](./Definitions/CaiPunctuateParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Text-caiPunctuate) in API Explorer.

## caiSummarize

Conversational Summarization

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/ai/text/v1/async/summarize`
Rate Limit Group|`Heavy`
App Permission|`AI`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Ai().Text().V1().Async().Summarize().Post(summaryInput, caiSummarizeParameters);
await rc.Revoke();
```

- `summaryInput` is of type [SummaryInput](./Definitions/SummaryInput.cs)
- `caiSummarizeParameters` is of type [CaiSummarizeParameters](./Definitions/CaiSummarizeParameters.cs)
- `result` is of type [CaiAsyncApiResponse](./Definitions/CaiAsyncApiResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Text-caiSummarize) in API Explorer.

## listVideoMeetings

List Video Meetings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v1/history/meetings`
Rate Limit Group|`Light`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V1().History().Meetings().List(listVideoMeetingsParameters);
await rc.Revoke();
```

- `listVideoMeetingsParameters` is of type [ListVideoMeetingsParameters](./Definitions/ListVideoMeetingsParameters.cs)
- `result` is of type [MeetingPage](./Definitions/MeetingPage.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meetings-History-listVideoMeetings) in API Explorer.

## getVideoMeeting

Get Video Meeting

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v1/history/meetings/{meetingId}`
Rate Limit Group|`Light`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V1().History().Meetings(meetingId).Get();
await rc.Revoke();
```

- `result` is of type [Meeting](./Definitions/Meeting.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meetings-History-getVideoMeeting) in API Explorer.

## getBridgeByPstnPin

Search Bridge by PSTN PIN

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v2/bridges/pin/pstn/{pin}`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Bridges().Pin().Pstn(pin).Get(getBridgeByPstnPinParameters);
await rc.Revoke();
```

- `getBridgeByPstnPinParameters` is of
  type [GetBridgeByPstnPinParameters](./Definitions/GetBridgeByPstnPinParameters.cs)
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-getBridgeByPstnPin) in API Explorer.

## getBridgeByWebPin

Search Bridge by Web PIN

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v2/bridges/pin/web/{pin}`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Bridges().Pin().Web(pin).Get(getBridgeByWebPinParameters);
await rc.Revoke();
```

- `getBridgeByWebPinParameters` is of type [GetBridgeByWebPinParameters](./Definitions/GetBridgeByWebPinParameters.cs)
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-getBridgeByWebPin) in API Explorer.

## listLicensesV2

List Account Licenses

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v2/accounts/{accountId}/licenses`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`LicensesAndInventory`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Licenses().Get(listLicensesV2Parameters);
await rc.Revoke();
```

- `listLicensesV2Parameters` is of type [ListLicensesV2Parameters](./Definitions/ListLicensesV2Parameters.cs)
- `result` is of type [LicensesStatisticsResponse](./Definitions/LicensesStatisticsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Licenses-listLicensesV2) in API Explorer.

## listCompanyActiveCalls

List Company Active Calls

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/active-calls`
Rate Limit Group|`Heavy`
App Permission|`ReadCallLog`
User Permission|`ReadCallLog`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCompanyActiveCallsParameters` is of
  type [ListCompanyActiveCallsParameters](./Definitions/ListCompanyActiveCallsParameters.cs)
- `result` is of type [CallLogResponse](./Definitions/CallLogResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-listCompanyActiveCalls) in API Explorer.

## listCallQueues

List Call Queues

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-queues`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().List(listCallQueuesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallQueuesParameters` is of type [ListCallQueuesParameters](./Definitions/ListCallQueuesParameters.cs)
- `result` is of type [CallQueues](./Definitions/CallQueues.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallQueueDetails](./Definitions/CallQueueDetails.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Put(callQueueUpdateDetails);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueUpdateDetails` is of type [CallQueueUpdateDetails](./Definitions/CallQueueUpdateDetails.cs)
- `result` is of type [CallQueueDetails](./Definitions/CallQueueDetails.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateCallQueueInfo) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().Post(createFaxMessageRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createFaxMessageRequest` is of type [CreateFaxMessageRequest](./Definitions/CreateFaxMessageRequest.cs)
- `result` is of type [FaxResponse](./Definitions/FaxResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Fax-createFaxMessage) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Mms().Post(createMMSMessage);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createMMSMessage` is of type [CreateMMSMessage](./Definitions/CreateMMSMessage.cs)
- `result` is of type [GetSMSMessageInfoResponse](./Definitions/GetSMSMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createMMS) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().Post(createSMSMessage);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createSMSMessage` is of type [CreateSMSMessage](./Definitions/CreateSMSMessage.cs)
- `result` is of type [GetSMSMessageInfoResponse](./Definitions/GetSMSMessageInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SMS-createSMSMessage) in API Explorer.

## listIvrPrompts

List IVR Prompts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/ivr-prompts`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyGreetings`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [IvrPrompts](./Definitions/IvrPrompts.cs)

[Try it out](https://developer.ringcentral.com/api-reference#IVR-listIvrPrompts) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Post(createIVRPromptRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createIVRPromptRequest` is of type [CreateIVRPromptRequest](./Definitions/CreateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./Definitions/PromptInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [PromptInfo](./Definitions/PromptInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Put(updateIVRPromptRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateIVRPromptRequest` is of type [UpdateIVRPromptRequest](./Definitions/UpdateIVRPromptRequest.cs)
- `result` is of type [PromptInfo](./Definitions/PromptInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#IVR-deleteIVRPrompt) in API Explorer.

## listAccountPhoneNumbers

List Company Phone Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/phone-number`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAccountPhoneNumbersParameters` is of
  type [ListAccountPhoneNumbersParameters](./Definitions/ListAccountPhoneNumbersParameters.cs)
- `result` is of type [AccountPhoneNumbers](./Definitions/AccountPhoneNumbers.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyPhoneNumberInfo](./Definitions/CompanyPhoneNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-readAccountPhoneNumber) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AccountServiceInfo](./Definitions/AccountServiceInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-readAccountServiceInfo) in API Explorer.

## listCountries

List Countries

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/country`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Country().List(listCountriesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listCountriesParameters` is of type [ListCountriesParameters](./Definitions/ListCountriesParameters.cs)
- `result` is of type [CountryListDictionaryModel](./Definitions/CountryListDictionaryModel.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [CountryInfoDictionaryModel](./Definitions/CountryInfoDictionaryModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readCountry) in API Explorer.

## listStandardGreetings

List Standard Greetings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/greeting`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Greeting().List(listStandardGreetingsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listStandardGreetingsParameters` is of
  type [ListStandardGreetingsParameters](./Definitions/ListStandardGreetingsParameters.cs)
- `result` is of type [DictionaryGreetingList](./Definitions/DictionaryGreetingList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [DictionaryGreetingInfo](./Definitions/DictionaryGreetingInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readStandardGreeting) in API Explorer.

## listLanguages

List Languages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/language`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Language().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [LanguageList](./Definitions/LanguageList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [LanguageInfo](./Definitions/LanguageInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readLanguage) in API Explorer.

## listLocations

List Locations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/location`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Location().Get(listLocationsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listLocationsParameters` is of type [ListLocationsParameters](./Definitions/ListLocationsParameters.cs)
- `result` is of type [GetLocationListResponse](./Definitions/GetLocationListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-listLocations) in API Explorer.

## listTimezones

List Timezones

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/timezone`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Timezone().List(listTimezonesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listTimezonesParameters` is of type [ListTimezonesParameters](./Definitions/ListTimezonesParameters.cs)
- `result` is of type [GetTimezoneListResponse](./Definitions/GetTimezoneListResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [GetTimezoneInfoResponse](./Definitions/GetTimezoneInfoResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Regional-Settings-readTimezone) in API Explorer.

## listStandardUserRole

List Standard User Roles

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/user-role`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().UserRole().List(listStandardUserRoleParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listStandardUserRoleParameters` is of
  type [ListStandardUserRoleParameters](./Definitions/ListStandardUserRoleParameters.cs)
- `result` is of type [RolesCollectionResource](./Definitions/RolesCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-listStandardUserRole) in API Explorer.

## readStandardUserRole

Get Standard User Role

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/user-role/{roleId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().UserRole(roleId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [RoleResource](./Definitions/RoleResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-readStandardUserRole) in API Explorer.

## parsePhoneNumber

Parse Phone Number(s)

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/number-parser/parse`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./Definitions/ParsePhoneNumberRequest.cs)
- `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./Definitions/ParsePhoneNumberParameters.cs)
- `result` is of type [ParsePhoneNumberResponse](./Definitions/ParsePhoneNumberResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().Post();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Subscriptions-renewSubscription) in API Explorer.

## scimGetProviderConfig2

Get Provider Config

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/scim/{version}/ServiceProviderConfig`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Scim(version).ServiceProviderConfig().Get();
await rc.Revoke();
```

- Parameter `version` is optional with default value `v2`
- `result` is of type [ScimProviderConfig](./Definitions/ScimProviderConfig.cs)

[Try it out](https://developer.ringcentral.com/api-reference#SCIM-scimGetProviderConfig2) in API Explorer.

## readTMCompanyInfoNew

Get Company Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/companies/{companyId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Companies(companyId).Get();
await rc.Revoke();
```

- `result` is of type [TMCompanyInfo](./Definitions/TMCompanyInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Profile-readTMCompanyInfoNew) in API Explorer.

## readGlipEveryoneNew

Get Everyone Chat

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/everyone`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Everyone().Get();
await rc.Revoke();
```

- `result` is of type [EveryoneTeamInfo](./Definitions/EveryoneTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-readGlipEveryoneNew) in API Explorer.

## patchGlipEveryoneNew

Update Everyone Chat

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/team-messaging/v1/everyone`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Everyone().Patch(updateEveryoneTeamRequest);
await rc.Revoke();
```

- `updateEveryoneTeamRequest` is of type [UpdateEveryoneTeamRequest](./Definitions/UpdateEveryoneTeamRequest.cs)
- `result` is of type [EveryoneTeamInfo](./Definitions/EveryoneTeamInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Teams-patchGlipEveryoneNew) in API Explorer.

## listFavoriteChatsNew

List Favorite Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/favorites`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Favorites().Get(listFavoriteChatsNewParameters);
await rc.Revoke();
```

- `listFavoriteChatsNewParameters` is of
  type [ListFavoriteChatsNewParameters](./Definitions/ListFavoriteChatsNewParameters.cs)
- `result` is of type [TMChatListWithoutNavigation](./Definitions/TMChatListWithoutNavigation.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listFavoriteChatsNew) in API Explorer.

## lockNoteNew

Lock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/notes/{noteId}/lock`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Lock().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-lockNoteNew) in API Explorer.

## addGlipTeamMembersNew

Add Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/add`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Add().Post(tMAddTeamMembersRequest);
await rc.Revoke();
```

- `tMAddTeamMembersRequest` is of type [TMAddTeamMembersRequest](./Definitions/TMAddTeamMembersRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-addGlipTeamMembersNew) in API Explorer.

## joinGlipTeamNew

Join Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/join`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Join().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-joinGlipTeamNew) in API Explorer.

## listGlipWebhooksNew

List Webhooks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/webhooks`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Webhooks().List();
await rc.Revoke();
```

- `result` is of type [TMWebhookList](./Definitions/TMWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-listGlipWebhooksNew) in API Explorer.

## readGlipWebhookNew

Get Webhook

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Webhooks(webhookId).Get();
await rc.Revoke();
```

- `result` is of type [TMWebhookList](./Definitions/TMWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-readGlipWebhookNew) in API Explorer.

## deleteGlipWebhookNew

Delete Webhook

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/webhooks/{webhookId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Webhooks(webhookId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-deleteGlipWebhookNew) in API Explorer.

## rcwHistoryListAllSessions

List Historical Webinar Sessions across Multiple Webinars

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/sessions`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Sessions().Get(rcwHistoryListAllSessionsParameters);
await rc.Revoke();
```

- `rcwHistoryListAllSessionsParameters` is of
  type [RcwHistoryListAllSessionsParameters](./Definitions/RcwHistoryListAllSessionsParameters.cs)
- `result` is of type [SessionGlobalListResource](./Definitions/SessionGlobalListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryListAllSessions) in API
Explorer.

## rcwHistoryGetWebinar

Get Historical Webinar

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Get();
await rc.Revoke();
```

- `result` is of type [WebinarResource](./Definitions/WebinarResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryGetWebinar) in API Explorer.

## getAccountRecordings

List Account Recordings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v1/account/{accountId}/recordings`
Rate Limit Group|`Light`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V1().Account(accountId).Recordings().Get(getAccountRecordingsParameters);
await rc.Revoke();
```

- Parameter `accountId` is optional with default value `~`
- `getAccountRecordingsParameters` is of
  type [GetAccountRecordingsParameters](./Definitions/GetAccountRecordingsParameters.cs)
- `result` is of type [CloudRecordings](./Definitions/CloudRecordings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Meeting-Recordings-getAccountRecordings) in API Explorer.

## bulkDeleteUsersV2

Delete User Extensions

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/v2/accounts/{accountId}/extensions`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Extensions().Delete(bulkDeleteUsersRequest);
await rc.Revoke();
```

- `bulkDeleteUsersRequest` is of type [BulkDeleteUsersRequest](./Definitions/BulkDeleteUsersRequest.cs)
- `result` is of type [BulkDeleteUsersResponse](./Definitions/BulkDeleteUsersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-bulkDeleteUsersV2) in API Explorer.

## listA2PBatches

List A2P SMS Batches

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/batches`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Batches().List(listA2PBatchesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listA2PBatchesParameters` is of type [ListA2PBatchesParameters](./Definitions/ListA2PBatchesParameters.cs)
- `result` is of type [BatchListResponse](./Definitions/BatchListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-listA2PBatches) in API Explorer.

## createA2PSMS

Send A2P SMS

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/batches`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Batches().Post(messageBatchCreateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `messageBatchCreateRequest` is of type [MessageBatchCreateRequest](./Definitions/MessageBatchCreateRequest.cs)
- `result` is of type [MessageBatchResponse](./Definitions/MessageBatchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-createA2PSMS) in API Explorer.

## readA2PBatch

Get A2P SMS Batch

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/batches/{batchId}`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Batches(batchId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageBatchResponse](./Definitions/MessageBatchResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-readA2PBatch) in API Explorer.

## listA2PSMS

List A2P SMS Messages

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/messages`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Messages().List(listA2PSMSParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listA2PSMSParameters` is of type [ListA2PSMSParameters](./Definitions/ListA2PSMSParameters.cs)
- `result` is of type [MessageListResponse](./Definitions/MessageListResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Messages(messageId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageDetailsResponse](./Definitions/MessageDetailsResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().OptOuts().Get(readA2PSMSOptOutsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readA2PSMSOptOutsParameters` is of type [ReadA2PSMSOptOutsParameters](./Definitions/ReadA2PSMSOptOutsParameters.cs)
- `result` is of type [OptOutListResponse](./Definitions/OptOutListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-readA2PSMSOptOuts) in API Explorer.

## aggregateA2PSMSStatuses

List A2P SMS Statuses

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/statuses`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().Statuses().Get(aggregateA2PSMSStatusesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `aggregateA2PSMSStatusesParameters` is of
  type [AggregateA2PSMSStatusesParameters](./Definitions/AggregateA2PSMSStatusesParameters.cs)
- `result` is of type [MessageStatusesResponse](./Definitions/MessageStatusesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-aggregateA2PSMSStatuses) in API Explorer.

## listCompanyAnsweringRules

List Company Call Handling Rules

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/answering-rule`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().List(listCompanyAnsweringRulesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCompanyAnsweringRulesParameters` is of
  type [ListCompanyAnsweringRulesParameters](./Definitions/ListCompanyAnsweringRulesParameters.cs)
- `result` is of type [CompanyAnsweringRuleList](./Definitions/CompanyAnsweringRuleList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-listCompanyAnsweringRules) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./Definitions/CompanyAnsweringRuleRequest.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-createCompanyAnsweringRule) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyAnsweringRuleInfo](./Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-readCompanyAnsweringRule) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./Definitions/CompanyAnsweringRuleUpdate.cs)
- `result` is of type [CompanyAnsweringRuleInfo](./Definitions/CompanyAnsweringRuleInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-updateCompanyAnsweringRule) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Handling-Rules-deleteCompanyAnsweringRule) in API
Explorer.

## listAssignedRoles

List Company Assigned Roles

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/assigned-role`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadAssignedRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AssignedRole().Get(listAssignedRolesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAssignedRolesParameters` is of type [ListAssignedRolesParameters](./Definitions/ListAssignedRolesParameters.cs)
- `result` is of type [ExtensionWithRolesCollectionResource](./Definitions/ExtensionWithRolesCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-listAssignedRoles) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AccountBusinessAddressResource](./Definitions/AccountBusinessAddressResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `modifyAccountBusinessAddressRequest` is of
  type [ModifyAccountBusinessAddressRequest](./Definitions/ModifyAccountBusinessAddressRequest.cs)
- `result` is of type [AccountBusinessAddressResource](./Definitions/AccountBusinessAddressResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-updateAccountBusinessAddress) in API Explorer.

## readCompanyBusinessHours

Get Company Business Hours

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/business-hours`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyAnsweringRules`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CompanyBusinessHours](./Definitions/CompanyBusinessHours.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `companyBusinessHoursUpdateRequest` is of
  type [CompanyBusinessHoursUpdateRequest](./Definitions/CompanyBusinessHoursUpdateRequest.cs)
- `result` is of type [CompanyBusinessHours](./Definitions/CompanyBusinessHours.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallLogSync().Get(syncAccountCallLogParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `syncAccountCallLogParameters` is of
  type [SyncAccountCallLogParameters](./Definitions/SyncAccountCallLogParameters.cs)
- `result` is of type [CallLogSyncResponse](./Definitions/CallLogSyncResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Log-syncAccountCallLog) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallRecordingSettingsResource](./Definitions/CallRecordingSettingsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-readCallRecordingSettings) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Put(callRecordingSettingsResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callRecordingSettingsResource` is of
  type [CallRecordingSettingsResource](./Definitions/CallRecordingSettingsResource.cs)
- `result` is of type [CallRecordingSettingsResource](./Definitions/CallRecordingSettingsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingSettings) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CustomFieldList](./Definitions/CustomFieldList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-listCustomFields) in API Explorer.

## createCustomField

Create Custom Field

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields().Post(customFieldCreateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `customFieldCreateRequest` is of type [CustomFieldCreateRequest](./Definitions/CustomFieldCreateRequest.cs)
- `result` is of type [CustomFieldModel](./Definitions/CustomFieldModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-createCustomField) in API Explorer.

## updateCustomField

Update Custom Field

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Put(customFieldUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `customFieldUpdateRequest` is of type [CustomFieldUpdateRequest](./Definitions/CustomFieldUpdateRequest.cs)
- `result` is of type [CustomFieldModel](./Definitions/CustomFieldModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-updateCustomField) in API Explorer.

## deleteCustomField

Delete Custom Field

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CustomFields(fieldId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Custom-Fields-deleteCustomField) in API Explorer.

## updateDeviceEmergency

Update Device Emergency Info

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/device/{deviceId}/emergency`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditCompanyDevices`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Emergency().Put(accountDeviceUpdate);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `accountDeviceUpdate` is of type [AccountDeviceUpdate](./Definitions/AccountDeviceUpdate.cs)
- `result` is of type [DeviceResource](./Definitions/DeviceResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-updateDeviceEmergency) in API Explorer.

## readDeviceSipInfo

Get Device SIP Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/device/{deviceId}/sip-info`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadCompanyDevices`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).SipInfo().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SipInfoResource](./Definitions/SipInfoResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-readDeviceSipInfo) in API Explorer.

## listExtensionDevices

List Extension Devices

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/device`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserDevices`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionDevicesParameters` is of
  type [ListExtensionDevicesParameters](./Definitions/ListExtensionDevicesParameters.cs)
- `result` is of type [GetExtensionDevicesResponse](./Definitions/GetExtensionDevicesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Devices-listExtensionDevices) in API Explorer.

## listExtensionGrants

List Extension Grants

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/grant`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionGrantsParameters` is of
  type [ListExtensionGrantsParameters](./Definitions/ListExtensionGrantsParameters.cs)
- `result` is of type [GetExtensionGrantListResponse](./Definitions/GetExtensionGrantListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-listExtensionGrants) in API Explorer.

## readAccountGreetingContent

Get Account Greeting Media Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/greeting/{greetingId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Greeting(greetingId).Content().Get(readAccountGreetingContentParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `readAccountGreetingContentParameters` is of
  type [ReadAccountGreetingContentParameters](./Definitions/ReadAccountGreetingContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readAccountGreetingContent) in API Explorer.

## listSiteMembers

List Site Members

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/sites/{siteId}/members`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Sites(siteId).Members().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SiteMembersList](./Definitions/SiteMembersList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Multi-Site-listSiteMembers) in API Explorer.

## listPermissions

List Permissions

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/permission`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Permission().List(listPermissionsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listPermissionsParameters` is of type [ListPermissionsParameters](./Definitions/ListPermissionsParameters.cs)
- `result` is of type [PermissionCollectionResource](./Definitions/PermissionCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-listPermissions) in API Explorer.

## readPermission

Get Permission

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/permission/{permissionId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Permission(permissionId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [PermissionResource](./Definitions/PermissionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readPermission) in API Explorer.

## getGlipAdaptiveCardNew

Get Adaptive Card

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/adaptive-cards/{cardId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().AdaptiveCards(cardId).Get();
await rc.Revoke();
```

- `result` is of type [AdaptiveCardInfo](./Definitions/AdaptiveCardInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Adaptive-Cards-getGlipAdaptiveCardNew) in API Explorer.

## updateGlipAdaptiveCardNew

Update Adaptive Card

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/team-messaging/v1/adaptive-cards/{cardId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().AdaptiveCards(cardId).Put(adaptiveCardRequest);
await rc.Revoke();
```

- `adaptiveCardRequest` is of type [AdaptiveCardRequest](./Definitions/AdaptiveCardRequest.cs)
- `result` is of type [AdaptiveCardShortInfo](./Definitions/AdaptiveCardShortInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Adaptive-Cards-updateGlipAdaptiveCardNew) in API Explorer.

## deleteGlipAdaptiveCardNew

Delete Adaptive Card

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/adaptive-cards/{cardId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().AdaptiveCards(cardId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Adaptive-Cards-deleteGlipAdaptiveCardNew) in API Explorer.

## favoriteGlipChatNew

Add Chat to Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/favorite`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Favorite().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-favoriteGlipChatNew) in API Explorer.

## listChatNotesNew

List Notes

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats/{chatId}/notes`
Rate Limit Group|`Heavy`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Notes().Get(listChatNotesNewParameters);
await rc.Revoke();
```

- `listChatNotesNewParameters` is of type [ListChatNotesNewParameters](./Definitions/ListChatNotesNewParameters.cs)
- `result` is of type [TMNoteList](./Definitions/TMNoteList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-listChatNotesNew) in API Explorer.

## createChatNoteNew

Create Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/notes`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Notes().Post(tMCreateNoteRequest);
await rc.Revoke();
```

- `tMCreateNoteRequest` is of type [TMCreateNoteRequest](./Definitions/TMCreateNoteRequest.cs)
- `result` is of type [TMNoteInfo](./Definitions/TMNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-createChatNoteNew) in API Explorer.

## readGlipPostsNew

List Posts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Posts().List(readGlipPostsNewParameters);
await rc.Revoke();
```

- `readGlipPostsNewParameters` is of type [ReadGlipPostsNewParameters](./Definitions/ReadGlipPostsNewParameters.cs)
- `result` is of type [TMPostsList](./Definitions/TMPostsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPostsNew) in API Explorer.

## createGlipPostNew

Create Post

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/posts`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Posts().Post(tMCreatePostRequest);
await rc.Revoke();
```

- `tMCreatePostRequest` is of type [TMCreatePostRequest](./Definitions/TMCreatePostRequest.cs)
- `result` is of type [TMPostInfo](./Definitions/TMPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-createGlipPostNew) in API Explorer.

## readGlipPostNew

Get Post

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Posts(postId).Get();
await rc.Revoke();
```

- `result` is of type [TMPostInfo](./Definitions/TMPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-readGlipPostNew) in API Explorer.

## deleteGlipPostNew

Delete Post

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/team-messaging/v1/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Posts(postId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Posts-deleteGlipPostNew) in API Explorer.

## patchGlipPostNew

Update Post

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/team-messaging/v1/chats/{chatId}/posts/{postId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Posts(postId).Patch(tMUpdatePostRequest);
await rc.Revoke();
```

- `tMUpdatePostRequest` is of type [TMUpdatePostRequest](./Definitions/TMUpdatePostRequest.cs)
- `result` is of type [TMPostInfo](./Definitions/TMPostInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Posts-patchGlipPostNew) in API Explorer.

## listChatTasksNew

List Chat Tasks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/chats/{chatId}/tasks`
Rate Limit Group|`Heavy`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Tasks().Get(listChatTasksNewParameters);
await rc.Revoke();
```

- `listChatTasksNewParameters` is of type [ListChatTasksNewParameters](./Definitions/ListChatTasksNewParameters.cs)
- `result` is of type [TMTaskList](./Definitions/TMTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-listChatTasksNew) in API Explorer.

## createTaskNew

Create Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/tasks`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Tasks().Post(tMCreateTaskRequest);
await rc.Revoke();
```

- `tMCreateTaskRequest` is of type [TMCreateTaskRequest](./Definitions/TMCreateTaskRequest.cs)
- `result` is of type [TMTaskInfo](./Definitions/TMTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-createTaskNew) in API Explorer.

## unfavoriteGlipChatNew

Remove Chat from Favorites

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/unfavorite`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).Unfavorite().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Chats-unfavoriteGlipChatNew) in API Explorer.

## listGlipConversationsNew

List Conversations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/conversations`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Conversations().List(listGlipConversationsNewParameters);
await rc.Revoke();
```

- `listGlipConversationsNewParameters` is of
  type [ListGlipConversationsNewParameters](./Definitions/ListGlipConversationsNewParameters.cs)
- `result` is of type [TMConversationList](./Definitions/TMConversationList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-listGlipConversationsNew) in API Explorer.

## createGlipConversationNew

Create/Open Conversation

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/conversations`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Conversations().Post(createConversationRequest);
await rc.Revoke();
```

- `createConversationRequest` is of type [CreateConversationRequest](./Definitions/CreateConversationRequest.cs)
- `result` is of type [TMConversationInfo](./Definitions/TMConversationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-createGlipConversationNew) in API Explorer.

## readGlipConversationNew

Get Conversation

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/conversations/{chatId}`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Conversations(chatId).Get();
await rc.Revoke();
```

- `result` is of type [TMConversationInfo](./Definitions/TMConversationInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Conversations-readGlipConversationNew) in API Explorer.

## listDataExportTasksNew

List Data Export Tasks

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/data-export`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`Glip`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().DataExport().List(listDataExportTasksNewParameters);
await rc.Revoke();
```

- `listDataExportTasksNewParameters` is of
  type [ListDataExportTasksNewParameters](./Definitions/ListDataExportTasksNewParameters.cs)
- `result` is of type [DataExportTaskList](./Definitions/DataExportTaskList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Compliance-Exports-listDataExportTasksNew) in API Explorer.

## createDataExportTaskNew

Create Data Export Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/data-export`
Rate Limit Group|`Heavy`
App Permission|`TeamMessaging`
User Permission|`Glip`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().DataExport().Post(createDataExportTaskRequest);
await rc.Revoke();
```

- `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./Definitions/CreateDataExportTaskRequest.cs)
- `result` is of type [DataExportTask](./Definitions/DataExportTask.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Compliance-Exports-createDataExportTaskNew) in API
Explorer.

## readDataExportTaskNew

Get Data Export Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/data-export/{taskId}`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`Glip`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().DataExport(taskId).Get();
await rc.Revoke();
```

- `result` is of type [DataExportTask](./Definitions/DataExportTask.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Compliance-Exports-readDataExportTaskNew) in API Explorer.

## listGroupEventsNew

List Group Events

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Groups(groupId).Events().Get();
await rc.Revoke();
```

- `result` is of type [TMEventInfo](./Definitions/TMEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-listGroupEventsNew) in API Explorer.

## createEventByGroupIdNew

Create Event by Group ID

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/groups/{groupId}/events`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Groups(groupId).Events().Post(tMCreateEventRequest);
await rc.Revoke();
```

- `tMCreateEventRequest` is of type [TMCreateEventRequest](./Definitions/TMCreateEventRequest.cs)
- `result` is of type [TMEventInfo](./Definitions/TMEventInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Calendar-Events-createEventByGroupIdNew) in API Explorer.

## listGlipGroupWebhooksNew

List Webhooks in Group

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Groups(groupId).Webhooks().Get();
await rc.Revoke();
```

- `result` is of type [TMWebhookList](./Definitions/TMWebhookList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-listGlipGroupWebhooksNew) in API
Explorer.

## createGlipGroupWebhookNew

Create Webhook in Group

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/groups/{groupId}/webhooks`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Groups(groupId).Webhooks().Post();
await rc.Revoke();
```

- `result` is of type [TMWebhookInfo](./Definitions/TMWebhookInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-createGlipGroupWebhookNew) in API
Explorer.

## publishNoteNew

Publish Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/notes/{noteId}/publish`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Publish().Post();
await rc.Revoke();
```

- `result` is of type [TMNoteInfo](./Definitions/TMNoteInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Notes-publishNoteNew) in API Explorer.

## unlockNoteNew

Unlock Note

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/notes/{noteId}/unlock`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Notes(noteId).Unlock().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Notes-unlockNoteNew) in API Explorer.

## listRecentChatsNew

List Recent Chats

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/team-messaging/v1/recent/chats`
Rate Limit Group|`Light`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Recent().Chats().Get(listRecentChatsNewParameters);
await rc.Revoke();
```

- `listRecentChatsNewParameters` is of
  type [ListRecentChatsNewParameters](./Definitions/ListRecentChatsNewParameters.cs)
- `result` is of type [TMChatListWithoutNavigation](./Definitions/TMChatListWithoutNavigation.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Chats-listRecentChatsNew) in API Explorer.

## completeTaskNew

Complete Task

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/tasks/{taskId}/complete`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Tasks(taskId).Complete().Post(tMCompleteTaskRequest);
await rc.Revoke();
```

- `tMCompleteTaskRequest` is of type [TMCompleteTaskRequest](./Definitions/TMCompleteTaskRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Tasks-completeTaskNew) in API Explorer.

## archiveGlipTeamNew

Archive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/archive`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Archive().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-archiveGlipTeamNew) in API Explorer.

## leaveGlipTeamNew

Leave Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/leave`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Leave().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-leaveGlipTeamNew) in API Explorer.

## removeGlipTeamMembersNew

Remove Team Members

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/remove`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Remove().Post(tMRemoveTeamMembersRequest);
await rc.Revoke();
```

- `tMRemoveTeamMembersRequest` is of type [TMRemoveTeamMembersRequest](./Definitions/TMRemoveTeamMembersRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-removeGlipTeamMembersNew) in API Explorer.

## unarchiveGlipTeamNew

Unarchive Team

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/teams/{chatId}/unarchive`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Teams(chatId).Unarchive().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Teams-unarchiveGlipTeamNew) in API Explorer.

## activateGlipWebhookNew

Activate Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/webhooks/{webhookId}/activate`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Webhooks(webhookId).Activate().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-activateGlipWebhookNew) in API Explorer.

## suspendGlipWebhookNew

Suspend Webhook

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/webhooks/{webhookId}/suspend`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Webhooks(webhookId).Suspend().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Incoming-Webhooks-suspendGlipWebhookNew) in API Explorer.

## rcwConfigListAllSessions

List Sessions across Multiple Webinars

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/sessions`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Sessions().Get(rcwConfigListAllSessionsParameters);
await rc.Revoke();
```

- `rcwConfigListAllSessionsParameters` is of
  type [RcwConfigListAllSessionsParameters](./Definitions/RcwConfigListAllSessionsParameters.cs)
- `result` is of type [WcsSessionGlobalListResource](./Definitions/WcsSessionGlobalListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigListAllSessions) in API
Explorer.

## rcwConfigListWebinars

List User's Webinars

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/webinars`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars().List(rcwConfigListWebinarsParameters);
await rc.Revoke();
```

- `rcwConfigListWebinarsParameters` is of
  type [RcwConfigListWebinarsParameters](./Definitions/RcwConfigListWebinarsParameters.cs)
- `result` is of type [WebinarListResource](./Definitions/WebinarListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigListWebinars) in API
Explorer.

## rcwConfigCreateWebinar

Create Webinar

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/webinar/configuration/v1/webinars`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars().Post(webinarCreationRequest);
await rc.Revoke();
```

- `webinarCreationRequest` is of type [WebinarCreationRequest](./Definitions/WebinarCreationRequest.cs)
- `result` is of type [WcsWebinarResource](./Definitions/WcsWebinarResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigCreateWebinar) in API
Explorer.

## rcwConfigGetWebinar

Get Webinar

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Get();
await rc.Revoke();
```

- `result` is of type [WcsWebinarResource](./Definitions/WcsWebinarResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigGetWebinar) in API Explorer.

## rcwConfigDeleteWebinar

Delete Webinar

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigDeleteWebinar) in API
Explorer.

## rcwConfigUpdateWebinar

Update Webinar

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Patch(webinarBaseModel);
await rc.Revoke();
```

- `webinarBaseModel` is of type [WebinarBaseModel](./Definitions/WebinarBaseModel.cs)
- `result` is of type [WcsWebinarResource](./Definitions/WcsWebinarResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigUpdateWebinar) in API
Explorer.

## rcwHistoryListRecordings

List Webinar Recordings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/recordings`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Recordings().List(rcwHistoryListRecordingsParameters);
await rc.Revoke();
```

- `rcwHistoryListRecordingsParameters` is of
  type [RcwHistoryListRecordingsParameters](./Definitions/RcwHistoryListRecordingsParameters.cs)
- `result` is of type [RecordingListResource](./Definitions/RecordingListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Recordings-rcwHistoryListRecordings) in API
Explorer.

## rcwHistoryGetRecording

Get Webinar Recording

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/recordings/{recordingId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Recordings(recordingId).Get();
await rc.Revoke();
```

- `result` is of type [RecordingItemExtendedModel](./Definitions/RecordingItemExtendedModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Recordings-rcwHistoryGetRecording) in API
Explorer.

## rcwHistoryAdminListRecordings

List Webinar Recordings (Admin)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/company/recordings`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Company().Recordings().List(rcwHistoryAdminListRecordingsParameters);
await rc.Revoke();
```

- `rcwHistoryAdminListRecordingsParameters` is of
  type [RcwHistoryAdminListRecordingsParameters](./Definitions/RcwHistoryAdminListRecordingsParameters.cs)
- `result` is of type [RecordingAdminListResource](./Definitions/RecordingAdminListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Recordings-rcwHistoryAdminListRecordings) in API
Explorer.

## rcwHistoryAdminGetRecording

Get Webinar Recording (Admin)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/company/recordings/{recordingId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Company().Recordings(recordingId).Get();
await rc.Revoke();
```

- `result` is of type [RecordingAdminExtendedItemModel](./Definitions/RecordingAdminExtendedItemModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Recordings-rcwHistoryAdminGetRecording) in API
Explorer.

## rcwHistoryListAllCompanySessions

List Historical Webinar Sessions across Multiple Webinars / Hosts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/company/sessions`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Company().Sessions().Get(rcwHistoryListAllCompanySessionsParameters);
await rc.Revoke();
```

- `rcwHistoryListAllCompanySessionsParameters` is of
  type [RcwHistoryListAllCompanySessionsParameters](./Definitions/RcwHistoryListAllCompanySessionsParameters.cs)
- `result` is of type [SessionGlobalListResource](./Definitions/SessionGlobalListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryListAllCompanySessions) in
API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [CallerBlockingSettings](./Definitions/CallerBlockingSettings.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `callerBlockingSettingsUpdate` is of
  type [CallerBlockingSettingsUpdate](./Definitions/CallerBlockingSettingsUpdate.cs)
- `result` is of type [CallerBlockingSettings](./Definitions/CallerBlockingSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-updateCallerBlockingSettings) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncMessagesParameters` is of type [SyncMessagesParameters](./Definitions/SyncMessagesParameters.cs)
- `result` is of type [GetMessageSyncResponse](./Definitions/GetMessageSyncResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listExtensionPhoneNumbersParameters` is of
  type [ListExtensionPhoneNumbersParameters](./Definitions/ListExtensionPhoneNumbersParameters.cs)
- `result` is of type [GetExtensionPhoneNumbersResponse](./Definitions/GetExtensionPhoneNumbersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-listExtensionPhoneNumbers) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listPagingGroupUsersParameters` is of
  type [ListPagingGroupUsersParameters](./Definitions/ListPagingGroupUsersParameters.cs)
- `result` is of type [PagingOnlyGroupUsers](./Definitions/PagingOnlyGroupUsers.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupUsers) in API Explorer.

## listPermissionCategories

List Permission Categories

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/permission-category`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().PermissionCategory().List(listPermissionCategoriesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listPermissionCategoriesParameters` is of
  type [ListPermissionCategoriesParameters](./Definitions/ListPermissionCategoriesParameters.cs)
- `result` is of type [PermissionCategoryCollectionResource](./Definitions/PermissionCategoryCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-listPermissionCategories) in API Explorer.

## readPermissionCategory

Get Permission Category

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/permission-category/{permissionCategoryId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().PermissionCategory(permissionCategoryId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [PermissionCategoryResource](./Definitions/PermissionCategoryResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Permissions-readPermissionCategory) in API Explorer.

## createGlipAdaptiveCardNew

Create Adaptive Card

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/team-messaging/v1/chats/{chatId}/adaptive-cards`
Rate Limit Group|`Medium`
App Permission|`TeamMessaging`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.TeamMessaging().V1().Chats(chatId).AdaptiveCards().Post(adaptiveCardRequest);
await rc.Revoke();
```

- `adaptiveCardRequest` is of type [AdaptiveCardRequest](./Definitions/AdaptiveCardRequest.cs)
- `result` is of type [AdaptiveCardShortInfo](./Definitions/AdaptiveCardShortInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Adaptive-Cards-createGlipAdaptiveCardNew) in API Explorer.

## rcwHistoryGetRecordingDownload

Get Webinar Recording Download Resource

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/recordings/{recordingId}/download`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Recordings(recordingId).Download().Get(rcwHistoryGetRecordingDownloadParameters);
await rc.Revoke();
```

- `rcwHistoryGetRecordingDownloadParameters` is of
  type [RcwHistoryGetRecordingDownloadParameters](./Definitions/RcwHistoryGetRecordingDownloadParameters.cs)
- `result` is of type [RecordingDownloadModel](./Definitions/RecordingDownloadModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Recordings-rcwHistoryGetRecordingDownload) in
API Explorer.

## rcwHistoryGetSession

Get Historical Webinar Session

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Sessions(sessionId).Get();
await rc.Revoke();
```

- `result` is of type [SessionResource](./Definitions/SessionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryGetSession) in API Explorer.

## rcwN11sListSubscriptions

List Webinar Subscriptions

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/notifications/v1/subscriptions`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions().List();
await rc.Revoke();
```

- `result` is of type [SubscriptionListResource](./Definitions/SubscriptionListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sListSubscriptions) in API
Explorer.

## rcwN11sCreateSubscription

Create Webinar Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/webinar/notifications/v1/subscriptions`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions().Post(createWebhookSubscriptionRequest);
await rc.Revoke();
```

- `createWebhookSubscriptionRequest` is of
  type [CreateWebhookSubscriptionRequest](./Definitions/CreateWebhookSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sCreateSubscription) in API
Explorer.

## rcwN11sGetSubscription

Get Webinar Subscription

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/notifications/v1/subscriptions/{subscriptionId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions(subscriptionId).Get();
await rc.Revoke();
```

- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sGetSubscription) in API
Explorer.

## rcwN11sUpdateSubscription

Update Webinar Subscription

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/webinar/notifications/v1/subscriptions/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions(subscriptionId).Put(updateSubscriptionRequest);
await rc.Revoke();
```

- `updateSubscriptionRequest` is of type [UpdateSubscriptionRequest](./Definitions/UpdateSubscriptionRequest.cs)
- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sUpdateSubscription) in API
Explorer.

## rcwN11sDeleteSubscription

Cancel Webinar Subscription

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/webinar/notifications/v1/subscriptions/{subscriptionId}`
Rate Limit Group|`Medium`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions(subscriptionId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sDeleteSubscription) in API
Explorer.

## analyticsCallsAggregationFetch

Calls Aggregation Data

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/analytics/calls/v1/accounts/{accountId}/aggregation/fetch`
Rate Limit Group|`Light`
App Permission|`Analytics`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Analytics().Calls().V1().Accounts(accountId).Aggregation().Fetch().Post(aggregationRequest, analyticsCallsAggregationFetchParameters);
await rc.Revoke();
```

- `aggregationRequest` is of type [AggregationRequest](./Definitions/AggregationRequest.cs)
- `analyticsCallsAggregationFetchParameters` is of
  type [AnalyticsCallsAggregationFetchParameters](./Definitions/AnalyticsCallsAggregationFetchParameters.cs)
- `result` is of type [AggregationResponse](./Definitions/AggregationResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Line-Of-Business-Analytics-analyticsCallsAggregationFetch)
in API Explorer.

## analyticsCallsTimelineFetch

Calls Timeline Data

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/analytics/calls/v1/accounts/{accountId}/timeline/fetch`
Rate Limit Group|`Light`
App Permission|`Analytics`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Analytics().Calls().V1().Accounts(accountId).Timeline().Fetch().Post(timelineRequest, analyticsCallsTimelineFetchParameters);
await rc.Revoke();
```

- `timelineRequest` is of type [TimelineRequest](./Definitions/TimelineRequest.cs)
- `analyticsCallsTimelineFetchParameters` is of
  type [AnalyticsCallsTimelineFetchParameters](./Definitions/AnalyticsCallsTimelineFetchParameters.cs)
- `result` is of type [TimelineResponse](./Definitions/TimelineResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Line-Of-Business-Analytics-analyticsCallsTimelineFetch) in
API Explorer.

## getDefaultBridge

Get User's Default Bridge

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/rcvideo/v2/account/{accountId}/extension/{extensionId}/bridges/default`
Rate Limit Group|`Medium`
App Permission|`Video`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Rcvideo().V2().Account(accountId).Extension(extensionId).Bridges().Default().Get();
await rc.Revoke();
```

- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [BridgeResponse](./Definitions/BridgeResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Bridge-Management-getDefaultBridge) in API Explorer.

## postBatchProvisionUsers

Create Multiple User Extensions

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/batch-provisioning/users`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).BatchProvisioning().Users().Post(batchProvisionUsersRequest);
await rc.Revoke();
```

- `batchProvisionUsersRequest` is of type [BatchProvisionUsersRequest](./Definitions/BatchProvisionUsersRequest.cs)
- `result` is of type [BatchProvisionUsersResponse](./Definitions/BatchProvisionUsersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#User-Settings-postBatchProvisionUsers) in API Explorer.

## replaceDevicesJWSPublic

Swap Devices

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/extensions/{extensionId}/devices/{deviceId}/replace`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditUserDevices`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).Extensions(extensionId).Devices(deviceId).Replace().Post(swapDeviceRequest);
await rc.Revoke();
```

- `swapDeviceRequest` is of type [SwapDeviceRequest](./Definitions/SwapDeviceRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Devices-replaceDevicesJWSPublic) in API Explorer.

## addNumbersToInventoryV2

Add Numbers to Inventory

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers/bulk-add`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers().BulkAdd().Post(addPhoneNumbersRequest);
await rc.Revoke();
```

- `addPhoneNumbersRequest` is of type [AddPhoneNumbersRequest](./Definitions/AddPhoneNumbersRequest.cs)
- `result` is of type [AddPhoneNumbersResponse](./Definitions/AddPhoneNumbersResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-addNumbersToInventoryV2) in API Explorer.

## getBulkAddTaskResultsV2

Get Add Numbers Task Results

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/v2/accounts/{accountId}/phone-numbers/bulk-add/{taskId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EditCompanyPhoneNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).PhoneNumbers().BulkAdd(taskId).Get();
await rc.Revoke();
```

- `result` is of type [GetBulkAddTaskResultsV2Response](./Definitions/GetBulkAddTaskResultsV2Response.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Phone-Numbers-getBulkAddTaskResultsV2) in API Explorer.

## sendActivationEmailV2

Send/Resend Activation Email

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/v2/accounts/{accountId}/send-activation-email`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`AccountAdministration`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi().V2().Accounts(accountId).SendActivationEmail().Post();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Company-sendActivationEmailV2) in API Explorer.

## addA2PSMSOptOuts

Add Opt-In/Out Numbers

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/a2p-sms/opt-outs/bulk-assign`
Rate Limit Group|`Light`
App Permission|`A2PSMS`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).A2pSms().OptOuts().BulkAssign().Post(optOutBulkAssignRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `optOutBulkAssignRequest` is of type [OptOutBulkAssignRequest](./Definitions/OptOutBulkAssignRequest.cs)
- `result` is of type [OptOutBulkAssignResponse](./Definitions/OptOutBulkAssignResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#High-Volume-SMS-addA2PSMSOptOuts) in API Explorer.

## getAddressBookBulkUploadTask

Get Contacts Upload Task

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/address-book-bulk-upload/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).AddressBookBulkUpload().Tasks(taskId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AddressBookBulkUploadResponse](./Definitions/AddressBookBulkUploadResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-getAddressBookBulkUploadTask) in API
Explorer.

## listCallMonitoringGroupMembers

List Call Monitoring Group Members

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/members`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallMonitoringGroupMembersParameters` is of
  type [ListCallMonitoringGroupMembersParameters](./Definitions/ListCallMonitoringGroupMembersParameters.cs)
- `result` is of type [CallMonitoringGroupMemberList](./Definitions/CallMonitoringGroupMemberList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-listCallMonitoringGroupMembers) in
API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bulkAccountCallRecordingsResource` is of
  type [BulkAccountCallRecordingsResource](./Definitions/BulkAccountCallRecordingsResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-updateCallRecordingExtensionList)
in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallRecordingExtensions](./Definitions/CallRecordingExtensions.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingExtensions) in API
Explorer.

## getExtensionBulkUpdateTask

Get Extension Update Task Status

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension-bulk-update/tasks/{taskId}`
Rate Limit Group|`Light`
App Permission|`EditExtensions`
User Permission|`EditExtensionInfo`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).ExtensionBulkUpdate().Tasks(taskId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [ExtensionBulkUpdateTaskResource](./Definitions/ExtensionBulkUpdateTaskResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Extensions-getExtensionBulkUpdateTask) in API Explorer.

## getCallQueueOverflowSettings

Get Call Queue Overflow Settings

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`CallQueueToCallQueue`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(callQueueId).OverflowSettings().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallQueueOverflowSettings](./Definitions/CallQueueOverflowSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-getCallQueueOverflowSettings) in API Explorer.

## updateCallQueueOverflowSettings

Update Call Queue Overflow Settings

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{callQueueId}/overflow-settings`
Rate Limit Group|`Heavy`
App Permission|`EditExtensions`
User Permission|`CallQueueToCallQueue`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(callQueueId).OverflowSettings().Put(callQueueOverflowSettingsRequestResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callQueueOverflowSettingsRequestResource` is of
  type [CallQueueOverflowSettingsRequestResource](./Definitions/CallQueueOverflowSettingsRequestResource.cs)
- `result` is of type [CallQueueOverflowSettings](./Definitions/CallQueueOverflowSettings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Queues-updateCallQueueOverflowSettings) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `syncAddressBookParameters` is of type [SyncAddressBookParameters](./Definitions/SyncAddressBookParameters.cs)
- `result` is of type [AddressBookSync](./Definitions/AddressBookSync.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-syncAddressBook) in API Explorer.

## listContacts

List Contacts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listContactsParameters` is of type [ListContactsParameters](./Definitions/ListContactsParameters.cs)
- `result` is of type [ContactList](./Definitions/ContactList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-listContacts) in API Explorer.

## createContact

Create User Contact

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `personalContactRequest` is of type [PersonalContactRequest](./Definitions/PersonalContactRequest.cs)
- `createContactParameters` is of type [CreateContactParameters](./Definitions/CreateContactParameters.cs)
- `result` is of type [PersonalContactResource](./Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-createContact) in API Explorer.

## readContact

Get User Contact(s)

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`ReadContacts`
User Permission|`ReadPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [PersonalContactResource](./Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-readContact) in API Explorer.

## updateContact

Update User Contact(s)

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactRequest, updateContactParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `personalContactRequest` is of type [PersonalContactRequest](./Definitions/PersonalContactRequest.cs)
- `updateContactParameters` is of type [UpdateContactParameters](./Definitions/UpdateContactParameters.cs)
- `result` is of type [PersonalContactResource](./Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-updateContact) in API Explorer.

## deleteContact

Delete User Contact(s)

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-deleteContact) in API Explorer.

## patchContact

Update Contact Attributes

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`
Rate Limit Group|`Heavy`
App Permission|`Contacts`
User Permission|`EditPersonalContacts`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Patch(personalContactRequest, patchContactParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `personalContactRequest` is of type [PersonalContactRequest](./Definitions/PersonalContactRequest.cs)
- `patchContactParameters` is of type [PatchContactParameters](./Definitions/PatchContactParameters.cs)
- `result` is of type [PersonalContactResource](./Definitions/PersonalContactResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#External-Contacts-patchContact) in API Explorer.

## listAdministeredSites

List User Administered Sites

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites`
Rate Limit Group|`Medium`
App Permission|`ReadAccounts`
User Permission|`ReadExtensions`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AdministeredSites().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [BusinessSiteCollectionResource](./Definitions/BusinessSiteCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Site-Administration-listAdministeredSites) in API Explorer.

## updateUserAdministeredSites

Update User Administered Sites

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`EditAssignedRoles`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AdministeredSites().Put(businessSiteCollectionRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `businessSiteCollectionRequest` is of
  type [BusinessSiteCollectionRequest](./Definitions/BusinessSiteCollectionRequest.cs)
- `result` is of type [BusinessSiteCollectionResource](./Definitions/BusinessSiteCollectionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Site-Administration-updateUserAdministeredSites) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `checkUserPermissionParameters` is of
  type [CheckUserPermissionParameters](./Definitions/CheckUserPermissionParameters.cs)
- `result` is of type [AuthProfileCheckResource](./Definitions/AuthProfileCheckResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Get(readExtensionCallQueuePresenceParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readExtensionCallQueuePresenceParameters` is of
  type [ReadExtensionCallQueuePresenceParameters](./Definitions/ReadExtensionCallQueuePresenceParameters.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./Definitions/ExtensionCallQueuePresenceList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallQueuePresence().Put(extensionCallQueueUpdatePresenceList);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `extensionCallQueueUpdatePresenceList` is of
  type [ExtensionCallQueueUpdatePresenceList](./Definitions/ExtensionCallQueueUpdatePresenceList.cs)
- `result` is of type [ExtensionCallQueuePresenceList](./Definitions/ExtensionCallQueuePresenceList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateExtensionCallQueuePresence) in API Explorer.

## getExtensionEmergencyLocations

List User Emergency Locations

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations().List(getExtensionEmergencyLocationsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `getExtensionEmergencyLocationsParameters` is of
  type [GetExtensionEmergencyLocationsParameters](./Definitions/GetExtensionEmergencyLocationsParameters.cs)
- `result` is of type [EmergencyLocationsResource](./Definitions/EmergencyLocationsResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-getExtensionEmergencyLocations)
in API Explorer.

## createExtensionEmergencyLocation

Create User Emergency Location

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EmergencyFramework`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations().Post(createUserEmergencyLocationRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createUserEmergencyLocationRequest` is of
  type [CreateUserEmergencyLocationRequest](./Definitions/CreateUserEmergencyLocationRequest.cs)
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createExtensionEmergencyLocation)
in API Explorer.

## getExtensionEmergencyLocation

Get User Emergency Location

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations(locationId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-getExtensionEmergencyLocation)
in API Explorer.

## updateExtensionEmergencyLocation

Update User Emergency Location

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}`
Rate Limit Group|`Light`
App Permission|`EditAccounts`
User Permission|`EmergencyFramework`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations(locationId).Put(emergencyLocationResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `emergencyLocationResource` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)
- `result` is of type [EmergencyLocationResource](./Definitions/EmergencyLocationResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateExtensionEmergencyLocation)
in API Explorer.

## deleteExtensionEmergencyLocation

Delete User Emergency Location

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`EmergencyFramework`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).EmergencyLocations(locationId).Delete(deleteExtensionEmergencyLocationParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteExtensionEmergencyLocationParameters` is of
  type [DeleteExtensionEmergencyLocationParameters](./Definitions/DeleteExtensionEmergencyLocationParameters.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteExtensionEmergencyLocation)
in API Explorer.

## listForwardingNumbers

List Forwarding Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadUserForwardingFlipNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().List(listForwardingNumbersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listForwardingNumbersParameters` is of
  type [ListForwardingNumbersParameters](./Definitions/ListForwardingNumbersParameters.cs)
- `result` is of
  type [GetExtensionForwardingNumberListResponse](./Definitions/GetExtensionForwardingNumberListResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `createForwardingNumberRequest` is of
  type [CreateForwardingNumberRequest](./Definitions/CreateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./Definitions/ForwardingNumberInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-createForwardingNumber) in API Explorer.

## deleteForwardingNumbers

Delete Forwarding Numbers

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/forwarding-number`
Rate Limit Group|`Medium`
App Permission|`EditExtensions`
User Permission|`EditUserForwardingFlipNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().DeleteAll(deleteForwardingNumbersRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `deleteForwardingNumbersRequest` is of
  type [DeleteForwardingNumbersRequest](./Definitions/DeleteForwardingNumbersRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumbers) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [ForwardingNumberResource](./Definitions/ForwardingNumberResource.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateForwardingNumberRequest` is of
  type [UpdateForwardingNumberRequest](./Definitions/UpdateForwardingNumberRequest.cs)
- `result` is of type [ForwardingNumberInfo](./Definitions/ForwardingNumberInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Forwarding-deleteForwardingNumber) in API Explorer.

## readGreetingContent

Get Extension Greeting Media Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/greeting/{greetingId}/content`
Rate Limit Group|`Heavy`
App Permission|`ReadAccounts`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Content().Get(readGreetingContentParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readGreetingContentParameters` is of
  type [ReadGreetingContentParameters](./Definitions/ReadGreetingContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Greetings-readGreetingContent) in API Explorer.

## readMessageContent

Get Message Attachment Content

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`
Rate Limit Group|`Medium`
App Permission|`ReadMessages`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(readMessageContentParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `readMessageContentParameters` is of
  type [ReadMessageContentParameters](./Definitions/ReadMessageContentParameters.cs)
- `result` is of type `byte[]`

### ❗❗❗ Code sample above may not work

Please refer to [Binary content downloading](/README.md#Binary-content-downloading).

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageContent) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [UnifiedPresence](./Definitions/UnifiedPresence.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).UnifiedPresence().Patch(updateUnifiedPresence);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `updateUnifiedPresence` is of type [UpdateUnifiedPresence](./Definitions/UpdateUnifiedPresence.cs)
- `result` is of type [UnifiedPresence](./Definitions/UnifiedPresence.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Presence-updateUnifiedPresence) in API Explorer.

## readUserVideoConfiguration

Get User Video Configuration

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`Meetings`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).VideoConfiguration().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [UserVideoConfiguration](./Definitions/UserVideoConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Video-Configuration-readUserVideoConfiguration) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreConfiguration](./Definitions/MessageStoreConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-readMessageStoreConfiguration) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `messageStoreConfiguration` is of type [MessageStoreConfiguration](./Definitions/MessageStoreConfiguration.cs)
- `result` is of type [MessageStoreConfiguration](./Definitions/MessageStoreConfiguration.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Store-updateMessageStoreConfiguration) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [MessageStoreReportArchive](./Definitions/MessageStoreReportArchive.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Message-Exports-readMessageStoreReportArchive) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `editPagingGroupRequest` is of type [EditPagingGroupRequest](./Definitions/EditPagingGroupRequest.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-assignMultiplePagingGroupUsersDevices)
in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listPagingGroupDevicesParameters` is of
  type [ListPagingGroupDevicesParameters](./Definitions/ListPagingGroupDevicesParameters.cs)
- `result` is of type [PagingOnlyGroupDevices](./Definitions/PagingOnlyGroupDevices.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Paging-Only-Groups-listPagingGroupDevices) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-readCallPartyStatus) in API Explorer.

## deleteCallParty

Delete Call Party

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`
Rate Limit Group|`Light`
App Permission|`CallControl`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Delete();
await rc.Revoke();
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Patch(partyUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `partyUpdateRequest` is of type [PartyUpdateRequest](./Definitions/PartyUpdateRequest.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-updateCallParty) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Park().Post();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-callParkParty) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `superviseCallSessionRequest` is of type [SuperviseCallSessionRequest](./Definitions/SuperviseCallSessionRequest.cs)
- `result` is of type [SuperviseCallSessionResponse](./Definitions/SuperviseCallSessionResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-superviseCallSession) in API Explorer.

## listContractedCountries

List Contracted Countries

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Brand(brandId).ContractedCountry().List();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `result` is of type [ContractedCountryListResponse](./Definitions/ContractedCountryListResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-listContractedCountries) in API Explorer.

## listDomesticCountries

List Domestic Countries

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country/{contractedCountryId}`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Dictionary().Brand(brandId).ContractedCountry(contractedCountryId).Get(listDomesticCountriesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- `listDomesticCountriesParameters` is of
  type [ListDomesticCountriesParameters](./Definitions/ListDomesticCountriesParameters.cs)
- `result` is of type [CountryListDictionaryModel](./Definitions/CountryListDictionaryModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Company-listDomesticCountries) in API Explorer.

## rcwConfigListAllCompanySessions

List Sessions across Multiple Webinars/Hosts

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/company/sessions`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Company().Sessions().Get(rcwConfigListAllCompanySessionsParameters);
await rc.Revoke();
```

- `rcwConfigListAllCompanySessionsParameters` is of
  type [RcwConfigListAllCompanySessionsParameters](./Definitions/RcwConfigListAllCompanySessionsParameters.cs)
- `result` is of type [WcsSessionGlobalListResource](./Definitions/WcsSessionGlobalListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigListAllCompanySessions) in
API Explorer.

## rcwConfigCreateSession

Create Webinar Session

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions().Post(wcsSessionWithLocaleCodeModel);
await rc.Revoke();
```

- `wcsSessionWithLocaleCodeModel` is of
  type [WcsSessionWithLocaleCodeModel](./Definitions/WcsSessionWithLocaleCodeModel.cs)
- `result` is of type [WcsSessionResource](./Definitions/WcsSessionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigCreateSession) in API
Explorer.

## rcwConfigGetSession

Get Webinar Session

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Get();
await rc.Revoke();
```

- `result` is of type [WcsSessionResource](./Definitions/WcsSessionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigGetSession) in API Explorer.

## rcwConfigDeleteSession

Delete Webinar Session

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigDeleteSession) in API
Explorer.

## rcwConfigUpdateSession

Update Webinar Session

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Patch(wcsSessionWithLocaleCodeModel);
await rc.Revoke();
```

- `wcsSessionWithLocaleCodeModel` is of
  type [WcsSessionWithLocaleCodeModel](./Definitions/WcsSessionWithLocaleCodeModel.cs)
- `result` is of type [WcsSessionResource](./Definitions/WcsSessionResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinars-and-Sessions-rcwConfigUpdateSession) in API
Explorer.

## rcwHistoryListInvitees

List Session Invitees

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Sessions(sessionId).Invitees().List(rcwHistoryListInviteesParameters);
await rc.Revoke();
```

- `rcwHistoryListInviteesParameters` is of
  type [RcwHistoryListInviteesParameters](./Definitions/RcwHistoryListInviteesParameters.cs)
- `result` is of type [InviteeListResource](./Definitions/InviteeListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryListInvitees) in API
Explorer.

## rcwHistoryGetInvitee

Get Session Invitee

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Sessions(sessionId).Invitees(inviteeId).Get();
await rc.Revoke();
```

- `result` is of type [InviteeModel](./Definitions/InviteeModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryGetInvitee) in API Explorer.

## rcwN11sRenewSubscription

Renew Webinar Subscription

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/webinar/notifications/v1/subscriptions/{subscriptionId}/renew`
Rate Limit Group|`Light`
App Permission|`N/A`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Notifications().V1().Subscriptions(subscriptionId).Renew().Post();
await rc.Revoke();
```

- `result` is of type [SubscriptionInfo](./Definitions/SubscriptionInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Webinar-Subscriptions-rcwN11sRenewSubscription) in API
Explorer.

## rcwRegListRegistrants

List Session Registrants

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}/registrants`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Registrants().List(rcwRegListRegistrantsParameters);
await rc.Revoke();
```

- `rcwRegListRegistrantsParameters` is of
  type [RcwRegListRegistrantsParameters](./Definitions/RcwRegListRegistrantsParameters.cs)
- `result` is of type [RegistrantListResource](./Definitions/RegistrantListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Registrants-rcwRegListRegistrants) in API Explorer.

## rcwRegCreateRegistrant

Create Registrant

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}/registrants`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Registrants().Post(registrantBaseModel);
await rc.Revoke();
```

- `registrantBaseModel` is of type [RegistrantBaseModel](./Definitions/RegistrantBaseModel.cs)
- `result` is of type [RegistrantModelResponsePost](./Definitions/RegistrantModelResponsePost.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Registrants-rcwRegCreateRegistrant) in API Explorer.

## rcwRegGetRegistrant

Get Registrant

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}/registrants/{registrantId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Registrants(registrantId).Get(rcwRegGetRegistrantParameters);
await rc.Revoke();
```

- `rcwRegGetRegistrantParameters` is of
  type [RcwRegGetRegistrantParameters](./Definitions/RcwRegGetRegistrantParameters.cs)
- `result` is of type [RegistrantModel](./Definitions/RegistrantModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Registrants-rcwRegGetRegistrant) in API Explorer.

## rcwRegDeleteRegistrant

Delete Registrant

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}/registrants/{registrantId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Registrants(registrantId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Registrants-rcwRegDeleteRegistrant) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./Definitions/CallMonitoringBulkAssign.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Monitoring-Groups-updateCallMonitoringGroupList) in
API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Get(listCallRecordingCustomGreetingsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listCallRecordingCustomGreetingsParameters` is of
  type [ListCallRecordingCustomGreetingsParameters](./Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- `result` is of type [CallRecordingCustomGreetings](./Definitions/CallRecordingCustomGreetings.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-listCallRecordingCustomGreetings)
in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().DeleteAll();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-deleteCallRecordingCustomGreetingList)
in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Recording-Settings-deleteCallRecordingCustomGreeting)
in API Explorer.

## listDevicesAutomaticLocationUpdates

List Devices

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().Get(listDevicesAutomaticLocationUpdatesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listDevicesAutomaticLocationUpdatesParameters` is of
  type [ListDevicesAutomaticLocationUpdatesParameters](./Definitions/ListDevicesAutomaticLocationUpdatesParameters.cs)
- `result` is of type [ListDevicesAutomaticLocationUpdates](./Definitions/ListDevicesAutomaticLocationUpdates.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listDevicesAutomaticLocationUpdates)
in API Explorer.

## assignMultipleDevicesAutomaticLocationUpdates

Enable Automatic Location Updates Feature

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().Post(assignMultipleDevicesAutomaticLocationUpdates);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `assignMultipleDevicesAutomaticLocationUpdates` is of
  type [AssignMultipleDevicesAutomaticLocationUpdates](./Definitions/AssignMultipleDevicesAutomaticLocationUpdates.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleDevicesAutomaticLocationUpdates)
in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().List(listNetworksParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listNetworksParameters` is of type [ListNetworksParameters](./Definitions/ListNetworksParameters.cs)
- `result` is of type [NetworksList](./Definitions/NetworksList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks().Post(createNetworkRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createNetworkRequest` is of type [CreateNetworkRequest](./Definitions/CreateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./Definitions/NetworkInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [NetworkInfo](./Definitions/NetworkInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Put(updateNetworkRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateNetworkRequest` is of type [UpdateNetworkRequest](./Definitions/UpdateNetworkRequest.cs)
- `result` is of type [NetworkInfo](./Definitions/NetworkInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteNetwork) in API Explorer.

## listAccountSwitches

List Account Switches

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAccountSwitchesParameters` is of
  type [ListAccountSwitchesParameters](./Definitions/ListAccountSwitchesParameters.cs)
- `result` is of type [SwitchesList](./Definitions/SwitchesList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAccountSwitches) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches().Post(createSwitchInfo);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createSwitchInfo` is of type [CreateSwitchInfo](./Definitions/CreateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./Definitions/SwitchInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [SwitchInfo](./Definitions/SwitchInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Put(updateSwitchInfo);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateSwitchInfo` is of type [UpdateSwitchInfo](./Definitions/UpdateSwitchInfo.cs)
- `result` is of type [SwitchInfo](./Definitions/SwitchInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Delete();
await rc.Revoke();
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().Post(createMultipleSwitchesRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMultipleSwitchesRequest` is of
  type [CreateMultipleSwitchesRequest](./Definitions/CreateMultipleSwitchesRequest.cs)
- `result` is of type [CreateMultipleSwitchesResponse](./Definitions/CreateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleSwitches) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().Post(updateMultipleSwitchesRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateMultipleSwitchesRequest` is of
  type [UpdateMultipleSwitchesRequest](./Definitions/UpdateMultipleSwitchesRequest.cs)
- `result` is of type [UpdateMultipleSwitchesResponse](./Definitions/UpdateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleSwitches) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().Post(validateMultipleSwitchesRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `validateMultipleSwitchesRequest` is of
  type [ValidateMultipleSwitchesRequest](./Definitions/ValidateMultipleSwitchesRequest.cs)
- `result` is of type [ValidateMultipleSwitchesResponse](./Definitions/ValidateMultipleSwitchesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleSwitches) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [AutomaticLocationUpdatesTaskInfo](./Definitions/AutomaticLocationUpdatesTaskInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readAutomaticLocationUpdatesTask)
in API Explorer.

## listAutomaticLocationUpdatesUsers

List Users

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().Get(listAutomaticLocationUpdatesUsersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listAutomaticLocationUpdatesUsersParameters` is of
  type [ListAutomaticLocationUpdatesUsersParameters](./Definitions/ListAutomaticLocationUpdatesUsersParameters.cs)
- `result` is of type [AutomaticLocationUpdatesUserList](./Definitions/AutomaticLocationUpdatesUserList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listAutomaticLocationUpdatesUsers)
in API Explorer.

## assignMultipleAutomaticLocationUpdatesUsers

Enable Automatic Location Updates for Users

Name|Value
-|-
HTTP Method|`POST`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users/bulk-assign`
Rate Limit Group|`Heavy`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().Post(emergencyAddressAutoUpdateUsersBulkAssignResource);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `emergencyAddressAutoUpdateUsersBulkAssignResource` is of
  type [EmergencyAddressAutoUpdateUsersBulkAssignResource](./Definitions/EmergencyAddressAutoUpdateUsersBulkAssignResource.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-assignMultipleAutomaticLocationUpdatesUsers)
in API Explorer.

## listWirelessPoints

List Wireless Points

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points`
Rate Limit Group|`Medium`
App Permission|`EditAccounts`
User Permission|`ConfigureEmergencyMaps`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().List(listWirelessPointsParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `listWirelessPointsParameters` is of
  type [ListWirelessPointsParameters](./Definitions/ListWirelessPointsParameters.cs)
- `result` is of type [WirelessPointsList](./Definitions/WirelessPointsList.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-listWirelessPoints) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().Post(createWirelessPoint);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createWirelessPoint` is of type [CreateWirelessPoint](./Definitions/CreateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createWirelessPoint) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [WirelessPointInfo](./Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-readWirelessPoint) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Put(updateWirelessPoint);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateWirelessPoint` is of type [UpdateWirelessPoint](./Definitions/UpdateWirelessPoint.cs)
- `result` is of type [WirelessPointInfo](./Definitions/WirelessPointInfo.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateWirelessPoint) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-deleteWirelessPoint) in API
Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().Post(createMultipleWirelessPointsRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `createMultipleWirelessPointsRequest` is of
  type [CreateMultipleWirelessPointsRequest](./Definitions/CreateMultipleWirelessPointsRequest.cs)
- `result` is of type [CreateMultipleWirelessPointsResponse](./Definitions/CreateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-createMultipleWirelessPoints) in
API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().Post(updateMultipleWirelessPointsRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `updateMultipleWirelessPointsRequest` is of
  type [UpdateMultipleWirelessPointsRequest](./Definitions/UpdateMultipleWirelessPointsRequest.cs)
- `result` is of type [UpdateMultipleWirelessPointsResponse](./Definitions/UpdateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-updateMultipleWirelessPoints) in
API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().Post(validateMultipleWirelessPointsRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `validateMultipleWirelessPointsRequest` is of
  type [ValidateMultipleWirelessPointsRequest](./Definitions/ValidateMultipleWirelessPointsRequest.cs)
- `result` is of type [ValidateMultipleWirelessPointsResponse](./Definitions/ValidateMultipleWirelessPointsResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Automatic-Location-Updates-validateMultipleWirelessPoints)
in API Explorer.

## assignDefaultRole

Assign Default Role

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role/default`
Rate Limit Group|`Medium`
App Permission|`RoleManagement`
User Permission|`Users`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AssignedRole().Default().Put();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [AssignedRolesResource](./Definitions/AssignedRolesResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Role-Management-assignDefaultRole) in API Explorer.

## listBlockedAllowedNumbers

List Blocked/Allowed Phone Numbers

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`
Rate Limit Group|`Light`
App Permission|`ReadAccounts`
User Permission|`ReadBlockedNumbers`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedNumbersParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `listBlockedAllowedNumbersParameters` is of
  type [ListBlockedAllowedNumbersParameters](./Definitions/ListBlockedAllowedNumbersParameters.cs)
- `result` is of type [BlockedAllowedPhoneNumbersList](./Definitions/BlockedAllowedPhoneNumbersList.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `addBlockedAllowedPhoneNumber` is of
  type [AddBlockedAllowedPhoneNumber](./Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./Definitions/BlockedAllowedPhoneNumberInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [BlockedAllowedPhoneNumberInfo](./Definitions/BlockedAllowedPhoneNumberInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `addBlockedAllowedPhoneNumber` is of
  type [AddBlockedAllowedPhoneNumber](./Definitions/AddBlockedAllowedPhoneNumber.cs)
- `result` is of type [BlockedAllowedPhoneNumberInfo](./Definitions/BlockedAllowedPhoneNumberInfo.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Blocking-deleteBlockedAllowedNumber) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Get();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `result` is of type [NotificationSettings](./Definitions/NotificationSettings.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`
- `notificationSettingsUpdateRequest` is of
  type [NotificationSettingsUpdateRequest](./Definitions/NotificationSettingsUpdateRequest.cs)
- `result` is of type [NotificationSettings](./Definitions/NotificationSettings.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties().BringIn().Post(addPartyRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `addPartyRequest` is of type [AddPartyRequest](./Definitions/AddPartyRequest.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Answer().Post(answerTarget);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `answerTarget` is of type [AnswerTarget](./Definitions/AnswerTarget.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Bridge().Post(bridgeTargetRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `bridgeTargetRequest` is of type [BridgeTargetRequest](./Definitions/BridgeTargetRequest.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().Post(callPartyFlip);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callPartyFlip` is of type [CallPartyFlip](./Definitions/CallPartyFlip.cs)
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `forwardTarget` is of type [ForwardTarget](./Definitions/ForwardTarget.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().Post(holdCallPartyRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `holdCallPartyRequest` is of type [HoldCallPartyRequest](./Definitions/HoldCallPartyRequest.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Ignore().Post(ignoreRequestBody);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `ignoreRequestBody` is of type [IgnoreRequestBody](./Definitions/IgnoreRequestBody.cs)
- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-ignoreCallInQueue) in API Explorer.

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Pickup().Post(pickupTarget);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `pickupTarget` is of type [PickupTarget](./Definitions/PickupTarget.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().Post();
await rc.Revoke();
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callRecordingUpdate` is of type [CallRecordingUpdate](./Definitions/CallRecordingUpdate.cs)
- `pauseResumeCallRecordingParameters` is of
  type [PauseResumeCallRecordingParameters](./Definitions/PauseResumeCallRecordingParameters.cs)
- `result` is of type [CallRecording](./Definitions/CallRecording.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().Post();
await rc.Revoke();
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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reply().Post(callPartyReply);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `callPartyReply` is of type [CallPartyReply](./Definitions/CallPartyReply.cs)
- `result` is of type [ReplyParty](./Definitions/ReplyParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Supervise().Post(partySuperviseRequest);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `partySuperviseRequest` is of type [PartySuperviseRequest](./Definitions/PartySuperviseRequest.cs)
- `result` is of type [PartySuperviseResponse](./Definitions/PartySuperviseResponse.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().Post(transferTarget);
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `transferTarget` is of type [TransferTarget](./Definitions/TransferTarget.cs)
- `result` is of type [CallParty](./Definitions/CallParty.cs)

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
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().Post();
await rc.Revoke();
```

- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- `result` is of type [CallParty](./Definitions/CallParty.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Call-Control-unholdCallParty) in API Explorer.

## rcwConfigListInvitees

List Session Invitees

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Invitees().List(rcwConfigListInviteesParameters);
await rc.Revoke();
```

- `rcwConfigListInviteesParameters` is of
  type [RcwConfigListInviteesParameters](./Definitions/RcwConfigListInviteesParameters.cs)
- `result` is of type [WcsInviteeListResource](./Definitions/WcsInviteeListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Invitees-rcwConfigListInvitees) in API Explorer.

## rcwConfigUpdateInvitees

Bulk Add/Delete Session Invitees

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Invitees().Patch(bulkUpdateInviteesRequest);
await rc.Revoke();
```

- `bulkUpdateInviteesRequest` is of type [BulkUpdateInviteesRequest](./Definitions/BulkUpdateInviteesRequest.cs)
- `result` is of type [BulkUpdateInviteesResponse](./Definitions/BulkUpdateInviteesResponse.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Invitees-rcwConfigUpdateInvitees) in API Explorer.

## rcwConfigGetInvitee

Get Session Invitee

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Invitees(inviteeId).Get();
await rc.Revoke();
```

- `result` is of type [InviteeResource](./Definitions/InviteeResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Invitees-rcwConfigGetInvitee) in API Explorer.

## rcwConfigUpdateInvitee

Update Session Invitee

Name|Value
-|-
HTTP Method|`PUT`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Invitees(inviteeId).Put(updateInviteeRequest);
await rc.Revoke();
```

- `updateInviteeRequest` is of type [UpdateInviteeRequest](./Definitions/UpdateInviteeRequest.cs)
- `result` is of type [InviteeResource](./Definitions/InviteeResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Invitees-rcwConfigUpdateInvitee) in API Explorer.

## rcwConfigDeleteInvitee

Delete Session Invitee

Name|Value
-|-
HTTP Method|`DELETE`
Endpoint|`/webinar/configuration/v1/webinars/{webinarId}/sessions/{sessionId}/invitees/{inviteeId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Configuration().V1().Webinars(webinarId).Sessions(sessionId).Invitees(inviteeId).Delete();
await rc.Revoke();
```

- `result` is an empty string

[Try it out](https://developer.ringcentral.com/api-reference#Invitees-rcwConfigDeleteInvitee) in API Explorer.

## rcwHistoryListParticipants

List Session Participants

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Sessions(sessionId).Participants().Get(rcwHistoryListParticipantsParameters);
await rc.Revoke();
```

- `rcwHistoryListParticipantsParameters` is of
  type [RcwHistoryListParticipantsParameters](./Definitions/RcwHistoryListParticipantsParameters.cs)
- `result` is of type [ParticipantListResource](./Definitions/ParticipantListResource.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryListParticipants) in API
Explorer.

## rcwHistoryGetParticipantInfo

Get Participant Information

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants/self`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().History().V1().Webinars(webinarId).Sessions(sessionId).Participants().Self().Get();
await rc.Revoke();
```

- `result` is of type [ParticipantReducedModel](./Definitions/ParticipantReducedModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Historical-Webinars-rcwHistoryGetParticipantInfo) in API
Explorer.

## rcwRegGetSession

Get Registration Session Info

Name|Value
-|-
HTTP Method|`GET`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`ReadWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Get();
await rc.Revoke();
```

- `result` is of type [RegSessionModel](./Definitions/RegSessionModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Registration-Management-rcwRegGetSession) in API Explorer.

## rcwRegUpdateSession

Update Registration Session

Name|Value
-|-
HTTP Method|`PATCH`
Endpoint|`/webinar/registration/v1/sessions/{sessionId}`
Rate Limit Group|`Heavy`
App Permission|`EditWebinars`
User Permission|`N/A`

```cs
var rc = new RestClient("clientID", "clientSecret", "serverURL"));
await rc.Authorize("jwtToken");
var result = await rc.Webinar().Registration().V1().Sessions(sessionId).Patch(regSessionModel);
await rc.Revoke();
```

- `regSessionModel` is of type [RegSessionModel](./Definitions/RegSessionModel.cs)
- `result` is of type [RegSessionModel](./Definitions/RegSessionModel.cs)

[Try it out](https://developer.ringcentral.com/api-reference#Registration-Management-rcwRegUpdateSession) in API
Explorer.