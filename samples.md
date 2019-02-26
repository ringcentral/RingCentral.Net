# RingCentral.Net SDK Code samples


## Get all versions

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




## Get api version

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


## Load api status

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


## Load user call log

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


## Delete user call log

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


## Sync user call log

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


## Get call records

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


## List extension active calls

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
- Parameter `extensionId` is optional with default value `~`


## Load company call log

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


## Load company call log record

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


## List company active calls

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


## List call recordings

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


## List call recording data

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


## Send sms

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


## Create internal text message

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


## Send fax message

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
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## List fax cover pages

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


## List messages

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


## Load message

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


## Update message

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


## Delete message

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


## Get message attachment by id

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


## Sync messages

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
- Parameter `extensionId` is optional with default value `~`


## Load message store configuration

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


## Update message store configuration

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


## Make ring out call

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


## Get ring out call status

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


## Cancel ring out call

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


## List contacts

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


## Create contact

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


## Load contact

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


## Update contact

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


## Delete contact

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


## Sync address book

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


## List favorite contacts

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


## Update favorite contact list

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
- Parameter `extensionId` is optional with default value `~`


## Search directory entries

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


## List directory entries

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


## Load account federation

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


## Get presence status

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


## Update presence status

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
- Parameter `extensionId` is optional with default value `~`


## Account presence

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
- Parameter `accountId` is optional with default value `~`


## List glip chats

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


## Load glip chat

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


## List glip conversations

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


## Create glip conversation

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


## Load glip conversation

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


## List glip teams

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


## Create glip team

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


## Load glip team

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


## Update glip team

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


## Delete glip team

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


## Join glip team

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


## Leave glip team

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


## Add glip team members

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


## Remove glip team members

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


## Archive glip team

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


## Unarchive glip team

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


## Load glip everyone

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


## Update glip everyone

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


## List glip groups

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


## Create glip group

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


## Load glip group

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


## Assign glip group members

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


## List glip group posts

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


## Create glip group post

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


## Update glip post text

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


## List recent chats

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


## List favorite chats

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


## Favorite glip chat

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


## Unfavorite glip chat

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


## Mark chat read

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


## Mark chat unread

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


## List glip posts

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


## Create post

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


## Create glip file

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


## Create glip card

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


## Load glip card

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


## Update glip card

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


## Delete glip card

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


## Load glip events

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


## Create event

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


## Load event

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


## Update event

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


## Delete event

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


## Create eventby group id

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


## List group events

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


## Load group notes

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


## Create group note

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


## Load user notes

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


## Create user note

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


## Load user note

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


## Delete note

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


## Patch note

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


## Update note

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


## Lock note

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


## Publish note

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


## Unlock note

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


## Load glip person

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


## Load glip company

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


## Create glip group webhook

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


## List glip group webhooks

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


## List glip webhooks

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


## Load glip webhook

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


## Delete glip webhook

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


## Activate glip webhook

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


## Suspend glip webhook

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


## Load glip preferences

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


## List meetings

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


## Create meeting

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


## Load meeting

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


## Update meeting

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


## Delete meeting

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


## End meeting

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


## Load meeting service info

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
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## List subscriptions

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


## Create subscription

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


## Load subscription

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


## Update subscription

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


## Delete subscription

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


## Renew subscription

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


## Get authorization profile

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


## Check user permission

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


## Load user business hours

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


## Update user business hours

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
- Parameter `extensionId` is optional with default value `~`


## Load company business hours

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


## Update company business hours

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


## Load call blocking settings

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


## Update call blocking settings

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


## List blocked allowed phone number

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


## Create blocked allowed phone number list

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


## Create blocked allowed phone number lists

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


## Load blocked allowed phone number

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


## Delete blocked allowed phone number

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


## Update blocked allowed phone number

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


## List extension forwarding numbers

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


## Create extension forwarding number

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


## Load extension forwarding number

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


## Update extension forwarding number

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


## Delete extension forwarding number

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


## List answering rules

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


## Create answering rule

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


## Load answering rule

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


## Update answering rule

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


## Delete answering rule

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
- Parameter `extensionId` is optional with default value `~`


## Create company answering rule

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


## List company answering rule

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


## Load company answering rule

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


## Update company answering rule

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


## Delete company answering rule

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
- Parameter `accountId` is optional with default value `~`


## List standard greetings

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


## Load standard greeting

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


## Create company greeting

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


## Create user custom greeting

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


## Load custom greeting

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
- Parameter `extensionId` is optional with default value `~`


## Create ivr prompt

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


## List ivr prompts

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


## Load ivr prompt

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


## Delete ivr prompt

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


## Update ivr prompt

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


## Load ivr prompt content

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


## Create ivr menu

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


## Load ivr menu

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


## Update ivr menu

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


## Load call recording settings

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


## Update call recording settings

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


## List call recording extension settings

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


## Update call recording extension settings

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


## List call recording custom greetings

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


## Delete call recording custom greeting

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
- Parameter `accountId` is optional with default value `~`


## Create sip registration

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


## List extension phone numbers

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


## Load extension info

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


## Update extension

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


## Delete extension

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


## Load extension caller id

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


## Update extension caller id

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


## List extension grants

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


## Load notification settings

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


## Update notification settings

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


## Download profile image

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


## Upload profile image

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


## Update profile image

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


## Download scaled pofile image

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


## Load conferencing info

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


## Update conferencing info

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
- Parameter `extensionId` is optional with default value `~`


## Load account

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


## Load account business address

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


## Update account business address

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


## Load service info

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
- Parameter `accountId` is optional with default value `~`


## List languages

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


## Load language

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


## List countries

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


## Load country

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


## List locations

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


## List states

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


## Load state

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


## List timezones

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


## Load timezone

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


## List account phone numbers

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


## Load account phone number

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


## List extensions

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


## Create extension

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


## List templates

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


## Load template

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


## List call queues

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


## List call queue members

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


## Assign call queue members

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


## List department members

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


## Bulk assign departments

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


## List paging group users

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


## List paging group devices

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


## Bulk assign paging group

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


## Create call monitoring group

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


## List call monitoring groups

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


## Update call monitoring group

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


## Remove call monitoring group

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


## List call monitoring group members

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


## Update call monitoring groups

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
- Parameter `accountId` is optional with default value `~`


## Parse phone number

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


## Load account device

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


## Update device

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


## List extension devices

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
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## Check health

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




## Get service provider config2

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


## Search via get2

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


## Create user2

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


## Search via post2

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


## Get user2

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


## Replace user2

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


## Delete user2

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


## Patch user2

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
- Parameter `version` is optional with default value `v2`


## Get call session status

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


## Delete call session

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


## Hold call party

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


## Unhold call party

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


## Reject party

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


## Transfer call party

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


## Forward call party

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


## Call flip party

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


## Get call party status

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


## Update call party

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


## Start call recording

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


## Pause resume call recording

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
- Parameter `accountId` is optional with default value `~`


## Get compliance archive stream

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


## Create data export task

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


## Load data export task

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


## Create message store report

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


## Load message store report task

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


## Load message store report archive

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


## Load message store report archive content

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


## List account meeting recordings

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


## List user meeting recordings

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
- Parameter `apiVersion` is optional with default value `v1.0`
- Parameter `accountId` is optional with default value `~`
- Parameter `extensionId` is optional with default value `~`


## Get token

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


## Revoke token

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