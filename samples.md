# RingCentral.Net SDK Code samples


## getAllVersions

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi().Get();
}
```




## getAllVersions

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).List();
}
```




## getApiVersion

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## getCallRecords

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog().Get(getCallRecordsParameters);
}
```

- Parameter `getCallRecordsParameters` is of type [GetCallRecordsParameters](./RingCentral.Net/Definitions/GetCallRecordsParameters.cs)


## syncUserCallLog

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## loadUserCallLog

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).List(loadUserCallLogParameters);
}
```

- Parameter `loadUserCallLogParameters` is of type [LoadUserCallLogParameters](./RingCentral.Net/Definitions/LoadUserCallLogParameters.cs)


## deleteUserCallLog

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallLog(callRecordId).Delete(deleteUserCallLogParameters);
}
```

- Parameter `deleteUserCallLogParameters` is of type [DeleteUserCallLogParameters](./RingCentral.Net/Definitions/DeleteUserCallLogParameters.cs)


## getCallRecords

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog().Get();
}
```




## loadCompanyCallLog

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallLog(callRecordId).List(loadCompanyCallLogParameters);
}
```

- Parameter `loadCompanyCallLogParameters` is of type [LoadCompanyCallLogParameters](./RingCentral.Net/Definitions/LoadCompanyCallLogParameters.cs)


## loadCompanyCallLogRecord

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().Get();
}
```




## updateMessage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().Put(updateMessageRequest);
}
```

- Parameter `updateMessageRequest` is of type [UpdateMessageRequest](./RingCentral.Net/Definitions/UpdateMessageRequest.cs)


## deleteMessage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore().Delete(deleteMessageParameters);
}
```

- Parameter `deleteMessageParameters` is of type [DeleteMessageParameters](./RingCentral.Net/Definitions/DeleteMessageParameters.cs)


## listMessages

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).MessageStore(messageId).List(listMessagesParameters);
}
```

- Parameter `listMessagesParameters` is of type [ListMessagesParameters](./RingCentral.Net/Definitions/ListMessagesParameters.cs)


## loadMessage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Get();
}
```




## cancelRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut().Delete();
}
```




## makeRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).RingOut(ringoutId).Post(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)


## getRingOutCallStatus

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## makeRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().Post(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)


## getRingOutCallStatus

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().Get();
}
```




## cancelRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout().Delete();
}
```




## makeRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).Post(makeRingOutRequest);
}
```

- Parameter `makeRingOutRequest` is of type [MakeRingOutRequest](./RingCentral.Net/Definitions/MakeRingOutRequest.cs)


## getRingOutCallStatus

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).Get();
}
```




## cancelRingOutCall

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Ringout(ringoutId).Delete();
}
```




## listContacts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Get();
}
```




## updateContact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Put(personalContactResource, updateContactParameters);
}
```

- Parameter `personalContactResource` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `updateContactParameters` is of type [UpdateContactParameters](./RingCentral.Net/Definitions/UpdateContactParameters.cs)


## deleteContact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact().Delete();
}
```




## listContacts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).List(listContactsParameters);
}
```

- Parameter `listContactsParameters` is of type [ListContactsParameters](./RingCentral.Net/Definitions/ListContactsParameters.cs)


## createContact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Post(personalContactResource, createContactParameters);
}
```

- Parameter `personalContactResource` is of type [PersonalContactResource](./RingCentral.Net/Definitions/PersonalContactResource.cs)
- Parameter `createContactParameters` is of type [CreateContactParameters](./RingCentral.Net/Definitions/CreateContactParameters.cs)


## loadContact

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats().Get();
}
```




## listGlipChats

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Chats(chatId).List(listGlipChatsParameters);
}
```

- Parameter `listGlipChatsParameters` is of type [ListGlipChatsParameters](./RingCentral.Net/Definitions/ListGlipChatsParameters.cs)


## loadGlipChat

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations().Get();
}
```




## listGlipConversations

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).List(listGlipConversationsParameters);
}
```

- Parameter `listGlipConversationsParameters` is of type [ListGlipConversationsParameters](./RingCentral.Net/Definitions/ListGlipConversationsParameters.cs)


## createGlipConversation

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Conversations(chatId).Post(glipPostMembersListBody);
}
```

- Parameter `glipPostMembersListBody` is of type [GlipPostMembersListBody](./RingCentral.Net/Definitions/GlipPostMembersListBody.cs)


## loadGlipConversation

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams().Get();
}
```




## updateGlipTeam

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams().Patch(glipPatchTeamBody);
}
```

- Parameter `glipPatchTeamBody` is of type [GlipPatchTeamBody](./RingCentral.Net/Definitions/GlipPatchTeamBody.cs)


## deleteGlipTeam

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams().Delete();
}
```




## listGlipTeams

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).List(listGlipTeamsParameters);
}
```

- Parameter `listGlipTeamsParameters` is of type [ListGlipTeamsParameters](./RingCentral.Net/Definitions/ListGlipTeamsParameters.cs)


## createGlipTeam

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Teams(chatId).Post(glipPostTeamBody);
}
```

- Parameter `glipPostTeamBody` is of type [GlipPostTeamBody](./RingCentral.Net/Definitions/GlipPostTeamBody.cs)


## loadGlipTeam

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups().Get();
}
```




## listGlipGroups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).List(listGlipGroupsParameters);
}
```

- Parameter `listGlipGroupsParameters` is of type [ListGlipGroupsParameters](./RingCentral.Net/Definitions/ListGlipGroupsParameters.cs)


## createGlipGroup

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Groups(groupId).Post(glipCreateGroup);
}
```

- Parameter `glipCreateGroup` is of type [GlipCreateGroup](./RingCentral.Net/Definitions/GlipCreateGroup.cs)


## loadGlipGroup

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards().Get();
}
```




## updateGlipCard

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards().Put(glipMessageAttachmentInfoRequest);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)


## deleteGlipCard

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards().Delete();
}
```




## createGlipCard

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Cards(cardId).Post(glipMessageAttachmentInfoRequest, createGlipCardParameters);
}
```

- Parameter `glipMessageAttachmentInfoRequest` is of type [GlipMessageAttachmentInfoRequest](./RingCentral.Net/Definitions/GlipMessageAttachmentInfoRequest.cs)
- Parameter `createGlipCardParameters` is of type [CreateGlipCardParameters](./RingCentral.Net/Definitions/CreateGlipCardParameters.cs)


## loadGlipCard

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events().Get();
}
```




## updateEvent

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events().Put(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)


## deleteEvent

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events().Delete();
}
```




## loadGlipEvents

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).List(loadGlipEventsParameters);
}
```

- Parameter `loadGlipEventsParameters` is of type [LoadGlipEventsParameters](./RingCentral.Net/Definitions/LoadGlipEventsParameters.cs)


## createEvent

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Events(eventId).Post(glipEventCreate);
}
```

- Parameter `glipEventCreate` is of type [GlipEventCreate](./RingCentral.Net/Definitions/GlipEventCreate.cs)


## loadEvent

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().Get();
}
```




## deleteNote

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().Delete();
}
```




## patchNote

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().Patch(glipNoteCreate, patchNoteParameters);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)
- Parameter `patchNoteParameters` is of type [PatchNoteParameters](./RingCentral.Net/Definitions/PatchNoteParameters.cs)


## updateNote

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes().Put(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)


## loadUserNotes

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).List(loadUserNotesParameters);
}
```

- Parameter `loadUserNotesParameters` is of type [LoadUserNotesParameters](./RingCentral.Net/Definitions/LoadUserNotesParameters.cs)


## createUserNote

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Notes(noteId).Post(glipNoteCreate);
}
```

- Parameter `glipNoteCreate` is of type [GlipNoteCreate](./RingCentral.Net/Definitions/GlipNoteCreate.cs)


## loadUserNote

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().Get();
}
```




## deleteGlipWebhook

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks().Delete();
}
```




## listGlipWebhooks

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().Webhooks(webhookId).List();
}
```




## loadGlipWebhook

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Get();
}
```




## updateMeeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Put(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)


## deleteMeeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting().Delete();
}
```




## listMeetings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).List();
}
```




## createMeeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Meeting(meetingId).Post(meetingRequestResource);
}
```

- Parameter `meetingRequestResource` is of type [MeetingRequestResource](./RingCentral.Net/Definitions/MeetingRequestResource.cs)


## loadMeeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription().Get();
}
```




## updateSubscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription().Put(modifySubscriptionRequest, updateSubscriptionParameters);
}
```

- Parameter `modifySubscriptionRequest` is of type [ModifySubscriptionRequest](./RingCentral.Net/Definitions/ModifySubscriptionRequest.cs)
- Parameter `updateSubscriptionParameters` is of type [UpdateSubscriptionParameters](./RingCentral.Net/Definitions/UpdateSubscriptionParameters.cs)


## deleteSubscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription().Delete();
}
```




## listSubscriptions

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).List();
}
```




## createSubscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Subscription(subscriptionId).Post(createSubscriptionRequest);
}
```

- Parameter `createSubscriptionRequest` is of type [CreateSubscriptionRequest](./RingCentral.Net/Definitions/CreateSubscriptionRequest.cs)


## loadSubscription

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## loadBlockedAllowedPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Get();
}
```




## deleteBlockedAllowedPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Delete();
}
```




## updateBlockedAllowedPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Put(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)


## createBlockedAllowedPhoneNumberLists

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## listBlockedAllowedPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).List(listBlockedAllowedPhoneNumberParameters);
}
```

- Parameter `listBlockedAllowedPhoneNumberParameters` is of type [ListBlockedAllowedPhoneNumberParameters](./RingCentral.Net/Definitions/ListBlockedAllowedPhoneNumberParameters.cs)


## createBlockedAllowedPhoneNumberList

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Post(addBlockedAllowedPhoneNumber);
}
```

- Parameter `addBlockedAllowedPhoneNumber` is of type [AddBlockedAllowedPhoneNumber](./RingCentral.Net/Definitions/AddBlockedAllowedPhoneNumber.cs)


## loadBlockedAllowedPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Get();
}
```




## updateExtensionForwardingNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Put(updateForwardingNumberRequest);
}
```

- Parameter `updateForwardingNumberRequest` is of type [UpdateForwardingNumberRequest](./RingCentral.Net/Definitions/UpdateForwardingNumberRequest.cs)


## deleteExtensionForwardingNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber().Delete();
}
```




## listExtensionForwardingNumbers

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).List(listExtensionForwardingNumbersParameters);
}
```

- Parameter `listExtensionForwardingNumbersParameters` is of type [ListExtensionForwardingNumbersParameters](./RingCentral.Net/Definitions/ListExtensionForwardingNumbersParameters.cs)


## createExtensionForwardingNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Post(createForwardingNumberRequest);
}
```

- Parameter `createForwardingNumberRequest` is of type [CreateForwardingNumberRequest](./RingCentral.Net/Definitions/CreateForwardingNumberRequest.cs)


## loadExtensionForwardingNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Get(loadAnsweringRuleParameters);
}
```

- Parameter `loadAnsweringRuleParameters` is of type [LoadAnsweringRuleParameters](./RingCentral.Net/Definitions/LoadAnsweringRuleParameters.cs)


## updateAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Put(updateAnsweringRuleRequest);
}
```

- Parameter `updateAnsweringRuleRequest` is of type [UpdateAnsweringRuleRequest](./RingCentral.Net/Definitions/UpdateAnsweringRuleRequest.cs)


## deleteAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule().Delete();
}
```




## listAnsweringRules

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).List(listAnsweringRulesParameters);
}
```

- Parameter `listAnsweringRulesParameters` is of type [ListAnsweringRulesParameters](./RingCentral.Net/Definitions/ListAnsweringRulesParameters.cs)


## createAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Post(createAnsweringRuleRequest);
}
```

- Parameter `createAnsweringRuleRequest` is of type [CreateAnsweringRuleRequest](./RingCentral.Net/Definitions/CreateAnsweringRuleRequest.cs)


## loadAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Get();
}
```




## updateCompanyAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Put(companyAnsweringRuleUpdate);
}
```

- Parameter `companyAnsweringRuleUpdate` is of type [CompanyAnsweringRuleUpdate](./RingCentral.Net/Definitions/CompanyAnsweringRuleUpdate.cs)


## deleteCompanyAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule().Delete();
}
```




## createCompanyAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).Post(companyAnsweringRuleRequest);
}
```

- Parameter `companyAnsweringRuleRequest` is of type [CompanyAnsweringRuleRequest](./RingCentral.Net/Definitions/CompanyAnsweringRuleRequest.cs)


## listCompanyAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).AnsweringRule(ruleId).List();
}
```




## loadCompanyAnsweringRule

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting().Get();
}
```




## listStandardGreetings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Greeting(greetingId).List(listStandardGreetingsParameters);
}
```

- Parameter `listStandardGreetingsParameters` is of type [ListStandardGreetingsParameters](./RingCentral.Net/Definitions/ListStandardGreetingsParameters.cs)


## loadStandardGreeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting().Get();
}
```




## createUserCustomGreeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Greeting(greetingId).Post(customGreetingRequest);
}
```

- Parameter `customGreetingRequest` is of type [CustomGreetingRequest](./RingCentral.Net/Definitions/CustomGreetingRequest.cs)


## loadCustomGreeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Get();
}
```




## deleteIvrPrompt

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Delete();
}
```




## updateIvrPrompt

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts().Put();
}
```




## createIvrPrompt

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).Post(createIvrPromptRequest);
}
```

- Parameter `createIvrPromptRequest` is of type [CreateIvrPromptRequest](./RingCentral.Net/Definitions/CreateIvrPromptRequest.cs)


## listIvrPrompts

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrPrompts(promptId).List();
}
```




## loadIvrPrompt

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Get();
}
```




## updateIvrMenu

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus().Put(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)


## createIvrMenu

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).IvrMenus(ivrMenuId).Post(ivrMenuInfo);
}
```

- Parameter `ivrMenuInfo` is of type [IVRMenuInfo](./RingCentral.Net/Definitions/IVRMenuInfo.cs)


## loadIvrMenu

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings().Delete();
}
```




## listCallRecordingCustomGreetings

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallRecording().CustomGreetings(greetingId).Get(listCallRecordingCustomGreetingsParameters);
}
```

- Parameter `listCallRecordingCustomGreetingsParameters` is of type [ListCallRecordingCustomGreetingsParameters](./RingCentral.Net/Definitions/ListCallRecordingCustomGreetingsParameters.cs)


## deleteCallRecordingCustomGreeting

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## listExtensions

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).List(listExtensionsParameters);
}
```

- Parameter `listExtensionsParameters` is of type [ListExtensionsParameters](./RingCentral.Net/Definitions/ListExtensionsParameters.cs)


## createExtension

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).Post(extensionCreationRequest);
}
```

- Parameter `extensionCreationRequest` is of type [ExtensionCreationRequest](./RingCentral.Net/Definitions/ExtensionCreationRequest.cs)


## loadExtensionInfo

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage().Get();
}
```




## downloadProfileImage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).List();
}
```




## uploadProfileImage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Post(uploadProfileImageRequest);
}
```

- Parameter `uploadProfileImageRequest` is of type [UploadProfileImageRequest](./RingCentral.Net/Definitions/UploadProfileImageRequest.cs)


## updateProfileImage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Put(updateProfileImageRequest);
}
```

- Parameter `updateProfileImageRequest` is of type [UpdateProfileImageRequest](./RingCentral.Net/Definitions/UpdateProfileImageRequest.cs)


## downloadScaledPofileImage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Language().Get();
}
```




## listLanguages

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Language(languageId).List();
}
```




## loadLanguage

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Country().Get();
}
```




## listCountries

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Country(countryId).List(listCountriesParameters);
}
```

- Parameter `listCountriesParameters` is of type [ListCountriesParameters](./RingCentral.Net/Definitions/ListCountriesParameters.cs)


## loadCountry

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().State().Get();
}
```




## listStates

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().State(stateId).List(listStatesParameters);
}
```

- Parameter `listStatesParameters` is of type [ListStatesParameters](./RingCentral.Net/Definitions/ListStatesParameters.cs)


## loadState

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone().Get(loadTimezoneParameters);
}
```

- Parameter `loadTimezoneParameters` is of type [LoadTimezoneParameters](./RingCentral.Net/Definitions/LoadTimezoneParameters.cs)


## listTimezones

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Dictionary().Timezone(timezoneId).List(listTimezonesParameters);
}
```

- Parameter `listTimezonesParameters` is of type [ListTimezonesParameters](./RingCentral.Net/Definitions/ListTimezonesParameters.cs)


## loadTimezone

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber().Get();
}
```




## listAccountPhoneNumbers

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).PhoneNumber(phoneNumberId).List(listAccountPhoneNumbersParameters);
}
```

- Parameter `listAccountPhoneNumbersParameters` is of type [ListAccountPhoneNumbersParameters](./RingCentral.Net/Definitions/ListAccountPhoneNumbersParameters.cs)


## loadAccountPhoneNumber

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## loadExtensionInfo

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Get();
}
```




## updateExtension

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Put(extensionUpdateRequest);
}
```

- Parameter `extensionUpdateRequest` is of type [ExtensionUpdateRequest](./RingCentral.Net/Definitions/ExtensionUpdateRequest.cs)


## deleteExtension

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Extension().Delete();
}
```




## listTemplates

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates().Get();
}
```




## listTemplates

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Templates(templateId).List(listTemplatesParameters);
}
```

- Parameter `listTemplatesParameters` is of type [ListTemplatesParameters](./RingCentral.Net/Definitions/ListTemplatesParameters.cs)


## loadTemplate

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Put(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)


## removeCallMonitoringGroup

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups().Delete();
}
```




## createCallMonitoringGroup

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Post(createCallMonitoringGroupRequest);
}
```

- Parameter `createCallMonitoringGroupRequest` is of type [CreateCallMonitoringGroupRequest](./RingCentral.Net/Definitions/CreateCallMonitoringGroupRequest.cs)


## listCallMonitoringGroups

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).CallMonitoringGroups(groupId).Get(listCallMonitoringGroupsParameters);
}
```

- Parameter `listCallMonitoringGroupsParameters` is of type [ListCallMonitoringGroupsParameters](./RingCentral.Net/Definitions/ListCallMonitoringGroupsParameters.cs)


## updateCallMonitoringGroup

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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




## checkHealth

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Health().Get();
}
```




## getServiceProviderConfig2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## getUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().Get();
}
```




## replaceUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().Put(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)


## deleteUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().Delete();
}
```




## patchUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users().Patch(userPatch);
}
```

- Parameter `userPatch` is of type [UserPatch](./RingCentral.Net/Definitions/UserPatch.cs)


## searchViaPost2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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


## searchViaGet2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).List(searchViaGet2Parameters);
}
```

- Parameter `searchViaGet2Parameters` is of type [SearchViaGet2Parameters](./RingCentral.Net/Definitions/SearchViaGet2Parameters.cs)


## createUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Scim(version).Users(id).Post(user);
}
```

- Parameter `user` is of type [User](./RingCentral.Net/Definitions/User.cs)


## getUser2

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Recordings().Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
}
```

- Parameter `callRecordingUpdate` is of type [CallRecordingUpdate](./RingCentral.Net/Definitions/CallRecordingUpdate.cs)
- Parameter `pauseResumeCallRecordingParameters` is of type [PauseResumeCallRecordingParameters](./RingCentral.Net/Definitions/PauseResumeCallRecordingParameters.cs)


## startCallRecording

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).Telephony().Sessions(sessionId).Parties(partyId).Recordings(recordingId).Post();
}
```




## pauseResumeCallRecording

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().DataExport().Get();
}
```




## createDataExportTask

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Glip().DataExport(taskId).Post(createDataExportTaskRequest);
}
```

- Parameter `createDataExportTaskRequest` is of type [CreateDataExportTaskRequest](./RingCentral.Net/Definitions/CreateDataExportTaskRequest.cs)


## loadDataExportTask

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport().Get();
}
```




## createMessageStoreReport

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Post(createMessageStoreReportRequest);
}
```

- Parameter `createMessageStoreReportRequest` is of type [CreateMessageStoreReportRequest](./RingCentral.Net/Definitions/CreateMessageStoreReportRequest.cs)


## loadMessageStoreReportTask

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive().Get();
}
```




## loadMessageStoreReportArchive

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
))
{
    await rc.Authorize(
        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
    );
    var result = await rc.Restapi(apiVersion).Account(accountId).MessageStoreReport(taskId).Archive(archiveId).List();
}
```




## loadMessageStoreReportArchiveContent

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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

```cs
using (var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
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