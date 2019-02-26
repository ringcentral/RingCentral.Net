# RingCentral.Net SDK Code samples


## getAllVersions

Http List /restapi

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/{apiVersion}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/status

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/call-log

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-log/{callRecordId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/active-calls

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/recording/{recordingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/recording/{recordingId}/content

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/sms

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/fax

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/fax-cover-page

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/message-store-configuration

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/message-store-configuration

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/directory/entries/search

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/directory/entries

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/directory/federation

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/presence

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/chats

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/chats/{chatId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/conversations

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/conversations

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/conversations/{chatId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/teams

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/teams/{chatId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /restapi/v1.0/glip/teams/{chatId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/glip/teams/{chatId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/join

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/leave

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/add

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/remove

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/archive

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/teams/{chatId}/unarchive

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/everyone

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /restapi/v1.0/glip/everyone

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/groups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/groups/{groupId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups/{groupId}/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/groups/{groupId}/posts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups/{groupId}/posts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/recent/chats

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/favorites

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/chats/{chatId}/favorite

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/chats/{chatId}/unfavorite

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/chats/{chatId}/read

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/chats/{chatId}/unread

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/posts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/posts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/files

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/cards

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/cards/{cardId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/glip/cards/{cardId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/glip/cards/{cardId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/events

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/events

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/events/{eventId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/glip/events/{eventId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/glip/events/{eventId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups/{groupId}/events

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/groups/{groupId}/events

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/groups/{groupId}/notes

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups/{groupId}/notes

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/notes

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/notes

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/notes/{noteId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/glip/notes/{noteId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /restapi/v1.0/glip/notes/{noteId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/glip/notes/{noteId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/notes/{noteId}/lock

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/notes/{noteId}/publish

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/notes/{noteId}/unlock

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/persons/{personId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/companies/{companyId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/groups/{groupId}/webhooks

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/groups/{groupId}/webhooks

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/glip/webhooks

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/webhooks/{webhookId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/glip/webhooks/{webhookId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/webhooks/{webhookId}/activate

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/webhooks/{webhookId}/suspend

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/preferences

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/subscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/subscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/subscription/{subscriptionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/subscription/{subscriptionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/subscription/{subscriptionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/subscription/{subscriptionId}/renew

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/business-hours

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/business-hours

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/bulk-update

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/answering-rule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/answering-rule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/dictionary/greeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/greeting/{greetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/greeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/ivr-prompts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/ivr-prompts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/ivr-menus

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-recording

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/call-recording

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-recording/extensions

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/call-recording/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-recording/custom-greetings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/client-info/sip-provision

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/grant

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/business-address

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/business-address

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/service-info

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/dictionary/language

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/language/{languageId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/dictionary/country

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/country/{countryId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/location

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/dictionary/state

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/state/{stateId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/dictionary/timezone

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/dictionary/timezone/{timezoneId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/phone-number

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/extension

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/extension

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/templates

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/templates/{templateId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-queues

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-queues/{groupId}/members

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/department/{departmentId}/members

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/department/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/call-monitoring-groups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-monitoring-groups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/number-parser/parse

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/device/{deviceId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /restapi/v1.0/account/{accountId}/device/{deviceId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/device

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /scim/health

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /scim/v2/ServiceProviderConfig

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /scim/v2/Users

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /scim/v2/Users

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /scim/v2/Users/.search

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /scim/v2/Users/{id}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Put /scim/v2/Users/{id}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /scim/v2/Users/{id}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /scim/v2/Users/{id}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Delete /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/hold

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/unhold

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/reject

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/transfer

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/forward

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/flip

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Patch /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings/{recordingId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/data-export/{taskId}/archive/{archiveId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/glip/data-export

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/glip/data-export/{taskId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/v1.0/account/{accountId}/message-store-report

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/message-store-report/{taskId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http List /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/meeting-recordings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/oauth/token

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

Http Post /restapi/oauth/revoke

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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