# RingCentral.Net SDK Code samples


## getAllVersions

HTTP GET `/restapi`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## getApiVersion

HTTP GET `/restapi/{apiVersion}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadAPIStatus

HTTP GET `/restapi/v1.0/status`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Status().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadUserCallLog

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().List(loadUserCallLogParameters);
}
```

- Parameter `loadUserCallLogParameters` is of type [LoadUserCallLogParameters](./RingCentral.Net/Definitions/LoadUserCallLogParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteUserCallLog

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## syncUserCallLog

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
}
```

- Parameter `syncUserCallLogParameters` is of type [SyncUserCallLogParameters](./RingCentral.Net/Definitions/SyncUserCallLogParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## getCallRecords

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(getCallRecordsParameters);
}
```

- Parameter `getCallRecordsParameters` is of type [GetCallRecordsParameters](./RingCentral.Net/Definitions/GetCallRecordsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listExtensionActiveCalls

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
}
```

- Parameter `listExtensionActiveCallsParameters` is of type [ListExtensionActiveCallsParameters](./RingCentral.Net/Definitions/ListExtensionActiveCallsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadCompanyCallLog

HTTP GET `/restapi/v1.0/account/{accountId}/call-log`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().List(loadCompanyCallLogParameters);
}
```

- Parameter `loadCompanyCallLogParameters` is of type [LoadCompanyCallLogParameters](./RingCentral.Net/Definitions/LoadCompanyCallLogParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadCompanyCallLogRecord

HTTP GET `/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCompanyActiveCalls

HTTP GET `/restapi/v1.0/account/{accountId}/active-calls`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
}
```

- Parameter `listCompanyActiveCallsParameters` is of type [ListCompanyActiveCallsParameters](./RingCentral.Net/Definitions/ListCompanyActiveCallsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallRecordings

HTTP GET `/restapi/v1.0/account/{accountId}/recording/{recordingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallRecordingData

HTTP GET `/restapi/v1.0/account/{accountId}/recording/{recordingId}/content`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Recording(recordingId).Content().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## sendSMS

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Sms().Post(createSmsMessage);
}
```

- Parameter `createSmsMessage` is of type [CreateSMSMessage](./RingCentral.Net/Definitions/CreateSMSMessage.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createInternalTextMessage

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest);
}
```

- Parameter `createInternalTextMessageRequest` is of type [CreateInternalTextMessageRequest](./RingCentral.Net/Definitions/CreateInternalTextMessageRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## sendFaxMessage

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Fax().Post(sendFaxMessageRequest);
}
```

- Parameter `sendFaxMessageRequest` is of type [SendFaxMessageRequest](./RingCentral.Net/Definitions/SendFaxMessageRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listFaxCoverPages

HTTP GET `/restapi/v1.0/dictionary/fax-cover-page`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters);
}
```

- Parameter `listFaxCoverPagesParameters` is of type [ListFaxCoverPagesParameters](./RingCentral.Net/Definitions/ListFaxCoverPagesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listMessages

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadMessage

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateMessage

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteMessage

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageParameters);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## getMessageAttachmentById

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(getMessageAttachmentByIdParameters);
}
```

- Parameter `getMessageAttachmentByIdParameters` is of type [GetMessageAttachmentByIdParameters](./RingCentral.Net/Definitions/GetMessageAttachmentByIdParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## syncMessages

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters);
}
```

- Parameter `syncMessagesParameters` is of type [SyncMessagesParameters](./RingCentral.Net/Definitions/SyncMessagesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadMessageStoreConfiguration

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateMessageStoreConfiguration

HTTP PUT `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration);
}
```

- Parameter `messageStoreConfiguration` is of type [MessageStoreConfiguration](./RingCentral.Net/Definitions/MessageStoreConfiguration.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## makeRingOutCall

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## getRingOutCallStatus

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## cancelRingOutCall

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listContacts

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createContact

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactResource, createContactParameters);
}
```

- Parameter `personalContactResource` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadContact

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateContact

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactResource, updateContactParameters);
}
```

- Parameter `personalContactResource` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteContact

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## syncAddressBook

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
}
```

- Parameter `syncAddressBookParameters` is of type [SyncAddressBookParameters](./RingCentral.Net/Definitions/SyncAddressBookParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listFavoriteContacts

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateFavoriteContactList

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection);
}
```

- Parameter `favoriteCollection` is of type [FavoriteCollection](./RingCentral.Net/Definitions/FavoriteCollection.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## searchDirectoryEntries

HTTP POST `/restapi/v1.0/account/{accountId}/directory/entries/search`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest);
}
```

- Parameter `searchDirectoryEntriesRequest` is of type [SearchDirectoryEntriesRequest](./RingCentral.Net/Definitions/SearchDirectoryEntriesRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listDirectoryEntries

HTTP GET `/restapi/v1.0/account/{accountId}/directory/entries`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Entries().Get(listDirectoryEntriesParameters);
}
```

- Parameter `listDirectoryEntriesParameters` is of type [ListDirectoryEntriesParameters](./RingCentral.Net/Definitions/ListDirectoryEntriesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadAccountFederation

HTTP GET `/restapi/v1.0/account/{accountId}/directory/federation`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Directory().Federation().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## getPresenceStatus

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Get(getPresenceStatusParameters);
}
```

- Parameter `getPresenceStatusParameters` is of type [GetPresenceStatusParameters](./RingCentral.Net/Definitions/GetPresenceStatusParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updatePresenceStatus

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Presence().Put(presenceInfoResource);
}
```

- Parameter `presenceInfoResource` is of type [PresenceInfoResource](./RingCentral.Net/Definitions/PresenceInfoResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## accountPresence

HTTP GET `/restapi/v1.0/account/{accountId}/presence`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Presence().Get(accountPresenceParameters);
}
```

- Parameter `accountPresenceParameters` is of type [AccountPresenceParameters](./RingCentral.Net/Definitions/AccountPresenceParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipChats

HTTP GET `/restapi/v1.0/glip/chats`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats().List(listGlipChatsParameters);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipChat

HTTP GET `/restapi/v1.0/glip/chats/{chatId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipConversations

HTTP GET `/restapi/v1.0/glip/conversations`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations().List(listGlipConversationsParameters);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipConversation

HTTP POST `/restapi/v1.0/glip/conversations`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations().Post(glipPostMembersListBody);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipConversation

HTTP GET `/restapi/v1.0/glip/conversations/{chatId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipTeams

HTTP GET `/restapi/v1.0/glip/teams`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams().List(listGlipTeamsParameters);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipTeam

HTTP POST `/restapi/v1.0/glip/teams`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams().Post(glipPostTeamBody);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipTeam

HTTP GET `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## updateGlipTeam

HTTP PATCH `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Patch(glipPatchTeamBody);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## deleteGlipTeam

HTTP DELETE `/restapi/v1.0/glip/teams/{chatId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## joinGlipTeam

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/join`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Join().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## leaveGlipTeam

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/leave`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Leave().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## addGlipTeamMembers

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/add`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Add().Post(glipPostMembersListBody);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## removeGlipTeamMembers

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/remove`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Remove().Post(glipPostMembersIdsListBody);
}
```

- Parameter `glipPostMembersIdsListBody` is of type [GlipPostMembersIdsListBody](./RingCentral.Net/Definitions/GlipPostMembersIdsListBody.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## archiveGlipTeam

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/archive`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Archive().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## unarchiveGlipTeam

HTTP POST `/restapi/v1.0/glip/teams/{chatId}/unarchive`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Unarchive().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipEveryone

HTTP GET `/restapi/v1.0/glip/everyone`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## updateGlipEveryone

HTTP PATCH `/restapi/v1.0/glip/everyone`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Everyone().Patch(updateGlipEveryoneRequest);
}
```

- Parameter `updateGlipEveryoneRequest` is of type [UpdateGlipEveryoneRequest](./RingCentral.Net/Definitions/UpdateGlipEveryoneRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipGroups

HTTP GET `/restapi/v1.0/glip/groups`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups().List(listGlipGroupsParameters);
}
```

- Parameter `listGlipGroupsParameters` is of type [ListGlipGroupsParameters](./RingCentral.Net/Definitions/ListGlipGroupsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipGroup

HTTP POST `/restapi/v1.0/glip/groups`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups().Post(glipCreateGroup);
}
```

- Parameter `glipCreateGroup` is of type [GlipCreateGroup](./RingCentral.Net/Definitions/GlipCreateGroup.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipGroup

HTTP GET `/restapi/v1.0/glip/groups/{groupId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## assignGlipGroupMembers

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).BulkAssign().Post(editGroupRequest);
}
```

- Parameter `editGroupRequest` is of type [EditGroupRequest](./RingCentral.Net/Definitions/EditGroupRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipGroupPosts

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/posts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().Get(listGlipGroupPostsParameters);
}
```

- Parameter `listGlipGroupPostsParameters` is of type [ListGlipGroupPostsParameters](./RingCentral.Net/Definitions/ListGlipGroupPostsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipGroupPost

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/posts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts().Post(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## updateGlipPostText

HTTP PUT `/restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Posts(postId).Text().Put(string);
}
```

- Parameter `string` is of type [string](./RingCentral.Net/Definitions/string.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listRecentChats

HTTP GET `/restapi/v1.0/glip/recent/chats`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Recent().Chats().Get(listRecentChatsParameters);
}
```

- Parameter `listRecentChatsParameters` is of type [ListRecentChatsParameters](./RingCentral.Net/Definitions/ListRecentChatsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listFavoriteChats

HTTP GET `/restapi/v1.0/glip/favorites`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Favorites().Get(listFavoriteChatsParameters);
}
```

- Parameter `listFavoriteChatsParameters` is of type [ListFavoriteChatsParameters](./RingCentral.Net/Definitions/ListFavoriteChatsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## favoriteGlipChat

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/favorite`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Favorite().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## unfavoriteGlipChat

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/unfavorite`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unfavorite().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## markChatRead

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/read`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Read().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## markChatUnread

HTTP POST `/restapi/v1.0/glip/chats/{chatId}/unread`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).Unread().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipPosts

HTTP GET `/restapi/v1.0/glip/posts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Posts().Get(listGlipPostsParameters);
}
```

- Parameter `listGlipPostsParameters` is of type [ListGlipPostsParameters](./RingCentral.Net/Definitions/ListGlipPostsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createPost

HTTP POST `/restapi/v1.0/glip/posts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Posts().Post(glipCreatePost);
}
```

- Parameter `glipCreatePost` is of type [GlipCreatePost](./RingCentral.Net/Definitions/GlipCreatePost.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipFile

HTTP POST `/restapi/v1.0/glip/files`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Files().Post(createGlipFileRequest, createGlipFileParameters);
}
```

- Parameter `createGlipFileRequest` is of type [CreateGlipFileRequest](./RingCentral.Net/Definitions/CreateGlipFileRequest.cs)
- Parameter `createGlipFileParameters` is of type [CreateGlipFileParameters](./RingCentral.Net/Definitions/CreateGlipFileParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipCard

HTTP POST `/restapi/v1.0/glip/cards`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards().Post(glipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipCard

HTTP GET `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## updateGlipCard

HTTP PUT `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Put(glipMessageAttachmentInfoRequest);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## deleteGlipCard

HTTP DELETE `/restapi/v1.0/glip/cards/{cardId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipEvents

HTTP GET `/restapi/v1.0/glip/events`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events().List(loadGlipEventsParameters);
}
```

- Parameter `loadGlipEventsParameters` is of type [LoadGlipEventsParameters](./RingCentral.Net/Definitions/LoadGlipEventsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createEvent

HTTP POST `/restapi/v1.0/glip/events`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events().Post(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadEvent

HTTP GET `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## updateEvent

HTTP PUT `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Put(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## deleteEvent

HTTP DELETE `/restapi/v1.0/glip/events/{eventId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## createEventbyGroupId

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Post(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listGroupEvents

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Events().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGroupNotes

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/notes`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Notes().Get(loadGroupNotesParameters);
}
```

- Parameter `loadGroupNotesParameters` is of type [LoadGroupNotesParameters](./RingCentral.Net/Definitions/LoadGroupNotesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createGroupNote

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/notes`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Notes().Post(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadUserNotes

HTTP GET `/restapi/v1.0/glip/notes`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().List(loadUserNotesParameters);
}
```

- Parameter `loadUserNotesParameters` is of type [LoadUserNotesParameters](./RingCentral.Net/Definitions/LoadUserNotesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## createUserNote

HTTP POST `/restapi/v1.0/glip/notes`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().Post(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadUserNote

HTTP GET `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## deleteNote

HTTP DELETE `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## patchNote

HTTP PATCH `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Patch(glipNoteCreate, patchNoteParameters);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `patchNoteParameters` is of type [PatchNoteParameters](./RingCentral.Net/Definitions/PatchNoteParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## updateNote

HTTP PUT `/restapi/v1.0/glip/notes/{noteId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Put(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## lockNote

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/lock`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Lock().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## publishNote

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/publish`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Publish().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## unlockNote

HTTP POST `/restapi/v1.0/glip/notes/{noteId}/unlock`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Unlock().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipPerson

HTTP GET `/restapi/v1.0/glip/persons/{personId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Persons(personId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipCompany

HTTP GET `/restapi/v1.0/glip/companies/{companyId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Companies(companyId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## createGlipGroupWebhook

HTTP POST `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipGroupWebhooks

HTTP GET `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Webhooks().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listGlipWebhooks

HTTP GET `/restapi/v1.0/glip/webhooks`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipWebhook

HTTP GET `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## deleteGlipWebhook

HTTP DELETE `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## activateGlipWebhook

HTTP POST `/restapi/v1.0/glip/webhooks/{webhookId}/activate`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Activate().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## suspendGlipWebhook

HTTP POST `/restapi/v1.0/glip/webhooks/{webhookId}/suspend`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).Suspend().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadGlipPreferences

HTTP GET `/restapi/v1.0/glip/preferences`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Preferences().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listMeetings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createMeeting

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Post(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadMeeting

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateMeeting

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Put(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteMeeting

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## endMeeting

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).End().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadMeetingServiceInfo

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listSubscriptions

HTTP GET `/restapi/v1.0/subscription`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## createSubscription

HTTP POST `/restapi/v1.0/subscription`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription().Post(createSubscriptionRequest);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadSubscription

HTTP GET `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## updateSubscription

HTTP PUT `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Put(modifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## deleteSubscription

HTTP DELETE `/restapi/v1.0/subscription/{subscriptionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## renewSubscription

HTTP POST `/restapi/v1.0/subscription/{subscriptionId}/renew`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Renew().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## getAuthorizationProfile

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## checkUserPermission

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
}
```

- Parameter `checkUserPermissionParameters` is of type [CheckUserPermissionParameters](./RingCentral.Net/Definitions/CheckUserPermissionParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadUserBusinessHours

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateUserBusinessHours

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest);
}
```

- Parameter `userBusinessHoursUpdateRequest` is of type [UserBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/UserBusinessHoursUpdateRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadCompanyBusinessHours

HTTP GET `/restapi/v1.0/account/{accountId}/business-hours`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCompanyBusinessHours

HTTP PUT `/restapi/v1.0/account/{accountId}/business-hours`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest);
}
```

- Parameter `companyBusinessHoursUpdateRequest` is of type [CompanyBusinessHoursUpdateRequest](./RingCentral.Net/Definitions/CompanyBusinessHoursUpdateRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadCallBlockingSettings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateCallBlockingSettings

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
}
```

- Parameter `callerBlockingSettingsUpdate` is of type [CallerBlockingSettingsUpdate](./RingCentral.Net/Definitions/CallerBlockingSettingsUpdate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listBlockedAllowedPhoneNumber

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedPhoneNumberParameters);
}
```

- Parameter `listBlockedAllowedPhoneNumberParameters` is of type [ListBlockedAllowedPhoneNumberParameters](./RingCentral.Net/Definitions/ListBlockedAllowedPhoneNumberParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createBlockedAllowedPhoneNumberList

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createBlockedAllowedPhoneNumberLists

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/bulk-update`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().BulkUpdate().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadBlockedAllowedPhoneNumber

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteBlockedAllowedPhoneNumber

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateBlockedAllowedPhoneNumber

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listExtensionForwardingNumbers

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().List(listExtensionForwardingNumbersParameters);
}
```

- Parameter `listExtensionForwardingNumbersParameters` is of type [ListExtensionForwardingNumbersParameters](./RingCentral.Net/Definitions/ListExtensionForwardingNumbersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createExtensionForwardingNumber

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadExtensionForwardingNumber

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateExtensionForwardingNumber

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteExtensionForwardingNumber

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listAnsweringRules

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createAnsweringRule

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadAnsweringRule

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(loadAnsweringRuleParameters);
}
```

- Parameter `loadAnsweringRuleParameters` is of type [LoadAnsweringRuleParameters](./RingCentral.Net/Definitions/LoadAnsweringRuleParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateAnsweringRule

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteAnsweringRule

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createCompanyAnsweringRule

HTTP POST `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCompanyAnsweringRule

HTTP GET `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadCompanyAnsweringRule

HTTP GET `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCompanyAnsweringRule

HTTP PUT `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## deleteCompanyAnsweringRule

HTTP DELETE `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listStandardGreetings

HTTP GET `/restapi/v1.0/dictionary/greeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().List(listStandardGreetingsParameters);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadStandardGreeting

HTTP GET `/restapi/v1.0/dictionary/greeting/{greetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createCompanyGreeting

HTTP POST `/restapi/v1.0/account/{accountId}/greeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Greeting().Post(customCompanyGreetingRequest);
}
```

- Parameter `customCompanyGreetingRequest` is of type [CustomCompanyGreetingRequest](./RingCentral.Net/Definitions/CustomCompanyGreetingRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## createUserCustomGreeting

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Post(customGreetingRequest);
}
```

- Parameter `customGreetingRequest` is of type [CustomGreetingRequest](./RingCentral.Net/Definitions/CustomGreetingRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadCustomGreeting

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createIvrPrompt

HTTP POST `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Post(createIvrPromptRequest);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listIvrPrompts

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadIvrPrompt

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## deleteIvrPrompt

HTTP DELETE `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateIvrPrompt

HTTP PUT `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Put();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadIvrPromptContent

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Content().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createIvrMenu

HTTP POST `/restapi/v1.0/account/{accountId}/ivr-menus`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Post(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadIvrMenu

HTTP GET `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateIvrMenu

HTTP PUT `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Put(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadCallRecordingSettings

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCallRecordingSettings

HTTP PUT `/restapi/v1.0/account/{accountId}/call-recording`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Put(callRecordingSettingsResource);
}
```

- Parameter `callRecordingSettingsResource` is of type [CallRecordingSettingsResource](./RingCentral.Net/Definitions/CallRecordingSettingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallRecordingExtensionSettings

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording/extensions`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().Extensions().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCallRecordingExtensionSettings

HTTP POST `/restapi/v1.0/account/{accountId}/call-recording/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
}
```

- Parameter `bulkAccountCallRecordingsResource` is of type [BulkAccountCallRecordingsResource](./RingCentral.Net/Definitions/BulkAccountCallRecordingsResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallRecordingCustomGreetings

HTTP GET `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Get(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## deleteCallRecordingCustomGreeting

HTTP DELETE `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## createSipRegistration

HTTP POST `/restapi/v1.0/client-info/sip-provision`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).ClientInfo().SipProvision().Post(createSipRegistrationRequest);
}
```

- Parameter `createSipRegistrationRequest` is of type [CreateSipRegistrationRequest](./RingCentral.Net/Definitions/CreateSipRegistrationRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listExtensionPhoneNumbers

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
}
```

- Parameter `listExtensionPhoneNumbersParameters` is of type [ListExtensionPhoneNumbersParameters](./RingCentral.Net/Definitions/ListExtensionPhoneNumbersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadExtensionInfo

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateExtension

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## deleteExtension

HTTP DELETE `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadExtensionCallerId

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateExtensionCallerId

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo);
}
```

- Parameter `extensionCallerIdInfo` is of type [ExtensionCallerIdInfo](./RingCentral.Net/Definitions/ExtensionCallerIdInfo.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listExtensionGrants

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters);
}
```

- Parameter `listExtensionGrantsParameters` is of type [ListExtensionGrantsParameters](./RingCentral.Net/Definitions/ListExtensionGrantsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadNotificationSettings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateNotificationSettings

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
}
```

- Parameter `notificationSettingsUpdateRequest` is of type [NotificationSettingsUpdateRequest](./RingCentral.Net/Definitions/NotificationSettingsUpdateRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## downloadProfileImage

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## uploadProfileImage

HTTP POST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Post(uploadProfileImageRequest);
}
```

- Parameter `uploadProfileImageRequest` is of type [UploadProfileImageRequest](./RingCentral.Net/Definitions/UploadProfileImageRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateProfileImage

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Put(updateProfileImageRequest);
}
```

- Parameter `updateProfileImageRequest` is of type [UpdateProfileImageRequest](./RingCentral.Net/Definitions/UpdateProfileImageRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## downloadScaledPofileImage

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## loadConferencingInfo

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Get(loadConferencingInfoParameters);
}
```

- Parameter `loadConferencingInfoParameters` is of type [LoadConferencingInfoParameters](./RingCentral.Net/Definitions/LoadConferencingInfoParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## updateConferencingInfo

HTTP PUT `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
}
```

- Parameter `updateConferencingInfoRequest` is of type [UpdateConferencingInfoRequest](./RingCentral.Net/Definitions/UpdateConferencingInfoRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadAccount

HTTP GET `/restapi/v1.0/account/{accountId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadAccountBusinessAddress

HTTP GET `/restapi/v1.0/account/{accountId}/business-address`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateAccountBusinessAddress

HTTP PUT `/restapi/v1.0/account/{accountId}/business-address`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest);
}
```

- Parameter `modifyAccountBusinessAddressRequest` is of type [ModifyAccountBusinessAddressRequest](./RingCentral.Net/Definitions/ModifyAccountBusinessAddressRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadServiceInfo

HTTP GET `/restapi/v1.0/account/{accountId}/service-info`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).ServiceInfo().Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listLanguages

HTTP GET `/restapi/v1.0/dictionary/language`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Language().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## loadLanguage

HTTP GET `/restapi/v1.0/dictionary/language/{languageId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listCountries

HTTP GET `/restapi/v1.0/dictionary/country`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Country().List(listCountriesParameters);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadCountry

HTTP GET `/restapi/v1.0/dictionary/country/{countryId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listLocations

HTTP GET `/restapi/v1.0/dictionary/location`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Location().Get(listLocationsParameters);
}
```

- Parameter `listLocationsParameters` is of type [ListLocationsParameters](./RingCentral.Net/Definitions/ListLocationsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## listStates

HTTP GET `/restapi/v1.0/dictionary/state`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().State().List(listStatesParameters);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadState

HTTP GET `/restapi/v1.0/dictionary/state/{stateId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## listTimezones

HTTP GET `/restapi/v1.0/dictionary/timezone`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().List(listTimezonesParameters);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadTimezone

HTTP GET `/restapi/v1.0/dictionary/timezone/{timezoneId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).Get(loadTimezoneParameters);
}
```

- Parameter `loadTimezoneParameters` is of type [LoadTimezoneParameters](./RingCentral.Net/Definitions/LoadTimezoneParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listAccountPhoneNumbers

HTTP GET `/restapi/v1.0/account/{accountId}/phone-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadAccountPhoneNumber

HTTP GET `/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listExtensions

HTTP GET `/restapi/v1.0/account/{accountId}/extension`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().List(listExtensionsParameters);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createExtension

HTTP POST `/restapi/v1.0/account/{accountId}/extension`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Post(extensionCreationRequest);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listTemplates

HTTP GET `/restapi/v1.0/account/{accountId}/templates`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().List(listTemplatesParameters);
}
```

- Parameter `listTemplatesParameters` is of type [ListTemplatesParameters](./RingCentral.Net/Definitions/ListTemplatesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadTemplate

HTTP GET `/restapi/v1.0/account/{accountId}/templates/{templateId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallQueues

HTTP GET `/restapi/v1.0/account/{accountId}/call-queues`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues().Get(listCallQueuesParameters);
}
```

- Parameter `listCallQueuesParameters` is of type [ListCallQueuesParameters](./RingCentral.Net/Definitions/ListCallQueuesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallQueueMembers

HTTP GET `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters);
}
```

- Parameter `listCallQueueMembersParameters` is of type [ListCallQueueMembersParameters](./RingCentral.Net/Definitions/ListCallQueueMembersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## assignCallQueueMembers

HTTP POST `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource);
}
```

- Parameter `callQueueBulkAssignResource` is of type [CallQueueBulkAssignResource](./RingCentral.Net/Definitions/CallQueueBulkAssignResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listDepartmentMembers

HTTP GET `/restapi/v1.0/account/{accountId}/department/{departmentId}/members`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Department(departmentId).Members().Get(listDepartmentMembersParameters);
}
```

- Parameter `listDepartmentMembersParameters` is of type [ListDepartmentMembersParameters](./RingCentral.Net/Definitions/ListDepartmentMembersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## bulkAssignDepartments

HTTP POST `/restapi/v1.0/account/{accountId}/department/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Department().BulkAssign().Post(departmentBulkAssignResource);
}
```

- Parameter `departmentBulkAssignResource` is of type [DepartmentBulkAssignResource](./RingCentral.Net/Definitions/DepartmentBulkAssignResource.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listPagingGroupUsers

HTTP GET `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters);
}
```

- Parameter `listPagingGroupUsersParameters` is of type [ListPagingGroupUsersParameters](./RingCentral.Net/Definitions/ListPagingGroupUsersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listPagingGroupDevices

HTTP GET `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters);
}
```

- Parameter `listPagingGroupDevicesParameters` is of type [ListPagingGroupDevicesParameters](./RingCentral.Net/Definitions/ListPagingGroupDevicesParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## bulkAssignPagingGroup

HTTP POST `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
}
```

- Parameter `editPagingGroupRequest` is of type [EditPagingGroupRequest](./RingCentral.Net/Definitions/EditPagingGroupRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createCallMonitoringGroup

HTTP POST `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallMonitoringGroups

HTTP GET `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Get(listCallMonitoringGroupsParameters);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCallMonitoringGroup

HTTP PUT `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## removeCallMonitoringGroup

HTTP DELETE `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listCallMonitoringGroupMembers

HTTP GET `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters);
}
```

- Parameter `listCallMonitoringGroupMembersParameters` is of type [ListCallMonitoringGroupMembersParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupMembersParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCallMonitoringGroups

HTTP POST `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
}
```

- Parameter `callMonitoringBulkAssign` is of type [CallMonitoringBulkAssign](./RingCentral.Net/Definitions/CallMonitoringBulkAssign.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## parsePhoneNumber

HTTP POST `/restapi/v1.0/number-parser/parse`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
}
```

- Parameter `parsePhoneNumberRequest` is of type [ParsePhoneNumberRequest](./RingCentral.Net/Definitions/ParsePhoneNumberRequest.cs)
- Parameter `parsePhoneNumberParameters` is of type [ParsePhoneNumberParameters](./RingCentral.Net/Definitions/ParsePhoneNumberParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadAccountDevice

HTTP GET `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateDevice

HTTP PUT `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Device(deviceId).Put(accountDeviceUpdate);
}
```

- Parameter `accountDeviceUpdate` is of type [AccountDeviceUpdate](./RingCentral.Net/Definitions/AccountDeviceUpdate.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listExtensionDevices

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/device`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters);
}
```

- Parameter `listExtensionDevicesParameters` is of type [ListExtensionDevicesParameters](./RingCentral.Net/Definitions/ListExtensionDevicesParameters.cs)


## checkHealth

HTTP GET `/scim/health`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim().Health().Get();
}
```


- Parameter `version` is optional with default value `v2`


## getServiceProviderConfig2

HTTP GET `/scim/v2/ServiceProviderConfig`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).ServiceProviderConfig().Get();
}
```


- Parameter `version` is optional with default value `v2`


## searchViaGet2

HTTP GET `/scim/v2/Users`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().List(searchViaGet2Parameters);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)
- Parameter `version` is optional with default value `v2`


## createUser2

HTTP POST `/scim/v2/Users`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().Post(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- Parameter `version` is optional with default value `v2`


## searchViaPost2

HTTP POST `/scim/v2/Users/.search`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().DotSearch().Post(searchRequest);
}
```

- Parameter `searchRequest` is of type [SearchRequest](./RingCentral.Net/Definitions/SearchRequest.cs)
- Parameter `version` is optional with default value `v2`


## getUser2

HTTP GET `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).Get();
}
```


- Parameter `version` is optional with default value `v2`


## replaceUser2

HTTP PUT `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).Put(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)
- Parameter `version` is optional with default value `v2`


## deleteUser2

HTTP DELETE `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).Delete();
}
```


- Parameter `version` is optional with default value `v2`


## patchUser2

HTTP PATCH `/scim/v2/Users/{id}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).Patch(userPatch);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## getCallSessionStatus

HTTP GET `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Get(getCallSessionStatusParameters);
}
```

- Parameter `getCallSessionStatusParameters` is of type [GetCallSessionStatusParameters](./RingCentral.Net/Definitions/GetCallSessionStatusParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## deleteCallSession

HTTP DELETE `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Delete();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## holdCallParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/hold`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Hold().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## unholdCallParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/unhold`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Unhold().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## rejectParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/reject`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Reject().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## transferCallParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/transfer`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Transfer().Post(transferTarget);
}
```

- Parameter `transferTarget` is of type [TransferTarget](./RingCentral.Net/Definitions/TransferTarget.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## forwardCallParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/forward`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Forward().Post(forwardTarget);
}
```

- Parameter `forwardTarget` is of type [ForwardTarget](./RingCentral.Net/Definitions/ForwardTarget.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## callFlipParty

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/flip`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Flip().Post(callPartyFlip);
}
```

- Parameter `callPartyFlip` is of type [CallPartyFlip](./RingCentral.Net/Definitions/CallPartyFlip.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## getCallPartyStatus

HTTP GET `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## updateCallParty

HTTP PATCH `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Patch(partyUpdateRequest);
}
```

- Parameter `partyUpdateRequest` is of type [PartyUpdateRequest](./RingCentral.Net/Definitions/PartyUpdateRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## startCallRecording

HTTP POST `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Recordings().Post();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## pauseResumeCallRecording

HTTP PATCH `/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings/{recordingId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## getComplianceArchiveStream

HTTP GET `/restapi/v1.0/glip/data-export/{taskId}/archive/{archiveId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Archive(archiveId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`


## createDataExportTask

HTTP POST `/restapi/v1.0/glip/data-export`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().DataExport().Post(createDataExportTaskRequest);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`


## loadDataExportTask

HTTP GET `/restapi/v1.0/glip/data-export/{taskId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## createMessageStoreReport

HTTP POST `/restapi/v1.0/account/{accountId}/message-store-report`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadMessageStoreReportTask

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadMessageStoreReportArchive

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().List();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## loadMessageStoreReportArchiveContent

HTTP GET `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).Get();
}
```


- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`


## listAccountMeetingRecordings

HTTP GET `/restapi/v1.0/account/{accountId}/meeting-recordings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MeetingRecordings().Get(listAccountMeetingRecordingsParameters);
}
```

- Parameter `listAccountMeetingRecordingsParameters` is of type [ListAccountMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListAccountMeetingRecordingsParameters.cs)
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## listUserMeetingRecordings

HTTP GET `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MeetingRecordings().Get(listUserMeetingRecordingsParameters);
}
```

- Parameter `listUserMeetingRecordingsParameters` is of type [ListUserMeetingRecordingsParameters](./RingCentral.Net/Definitions/ListUserMeetingRecordingsParameters.cs)


## getToken

HTTP POST `/restapi/oauth/token`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi().Oauth().Token().Post(getTokenRequest);
}
```

- Parameter `getTokenRequest` is of type [GetTokenRequest](./RingCentral.Net/Definitions/GetTokenRequest.cs)


## revokeToken

HTTP POST `/restapi/oauth/revoke`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi().Oauth().Revoke().Post(revokeTokenRequest);
}
```

- Parameter `revokeTokenRequest` is of type [RevokeTokenRequest](./RingCentral.Net/Definitions/RevokeTokenRequest.cs)