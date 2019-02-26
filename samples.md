# RingCentral.Net SDK Code samples


## getAllVersions

HTTP LIST `/restapi`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## loadUserCallLog

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## loadCompanyCallLog

HTTP LIST `/restapi/v1.0/account/{accountId}/call-log`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listMessages

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listContacts

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listGlipChats

HTTP LIST `/restapi/v1.0/glip/chats`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listGlipConversations

HTTP LIST `/restapi/v1.0/glip/conversations`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listGlipTeams

HTTP LIST `/restapi/v1.0/glip/teams`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listGlipGroups

HTTP LIST `/restapi/v1.0/glip/groups`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## loadGlipEvents

HTTP LIST `/restapi/v1.0/glip/events`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## loadUserNotes

HTTP LIST `/restapi/v1.0/glip/notes`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listGlipWebhooks

HTTP LIST `/restapi/v1.0/glip/webhooks`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listMeetings

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listSubscriptions

HTTP LIST `/restapi/v1.0/subscription`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listBlockedAllowedPhoneNumber

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listExtensionForwardingNumbers

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listAnsweringRules

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listCompanyAnsweringRule

HTTP LIST `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listStandardGreetings

HTTP LIST `/restapi/v1.0/dictionary/greeting`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listIvrPrompts

HTTP LIST `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## downloadProfileImage

HTTP LIST `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listLanguages

HTTP LIST `/restapi/v1.0/dictionary/language`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listCountries

HTTP LIST `/restapi/v1.0/dictionary/country`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listStates

HTTP LIST `/restapi/v1.0/dictionary/state`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listTimezones

HTTP LIST `/restapi/v1.0/dictionary/timezone`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listAccountPhoneNumbers

HTTP LIST `/restapi/v1.0/account/{accountId}/phone-number`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listExtensions

HTTP LIST `/restapi/v1.0/account/{accountId}/extension`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listTemplates

HTTP LIST `/restapi/v1.0/account/{accountId}/templates`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## searchViaGet2

HTTP LIST `/scim/v2/Users`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## loadMessageStoreReportArchive

HTTP LIST `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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