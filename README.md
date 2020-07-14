# RingCentral.Net

[![Build Status](https://travis-ci.org/ringcentral/RingCentral.Net.svg?branch=master)](https://travis-ci.org/ringcentral/RingCentral.Net)

This project is a complete rewrite of [ringcentral/ringcentral-csharp-client](https://github.com/ringcentral/ringcentral-csharp-client).

- [Announcing the New RingCentral SDK for .NET](https://medium.com/ringcentral-developers/new-ringcentral-sdk-for-net-a43417b2538c)
- [RingCentral SDK for .NET Upgrade Guide](https://medium.com/ringcentral-developers/ringcentral-sdk-for-net-upgrade-guide-8ead6bcdaf99)


## Installation

Package is available on NuGet: https://www.nuget.org/packages/RingCentral.Net

You can install it just like you install any other NuGet packages.

If you need PubNub feature, you also need to install one of the following packages:

- If you want to target traditional .NET Framework: https://www.nuget.org/packages/RingCentral.Net.Pubnub
- If you want to target .NET Core, Mono, Xamarin...etc: https://www.nuget.org/packages/RingCentral.Net.PubnubPCL


## Code samples

You can find [sample code for all the endpoints](./samples.md).

There is also lots of useful code for your reference in our [test cases](./RingCentral.Tests).


## Token auto refresh

By default this SDK doesn't do token refresh. You are responsible to design and implement your own token management strategy.

However, if you need a quick and dirty solution, you can try `rc.AutoRefresh(interval: 1000 * 60 * 30);`. To disable it, use `rc.StopAutoRefresh();`.


## API calls auto retry

By default there is no API calls auto retry. If an API call fails, an exception will be thrown and you are supposed to catch and handle it.

However, if you need a quick and dirty solution, you can try `rc.AutoRetry(baseDelay: 10000, maxRetryTimes: 10, retryableHttpStatusCodes: new[]{429});`.

Above it's a sample to deal with [API rate limit](https://medium.com/ringcentral-developers/ringcentral-api-rate-limit-explained-2280fe53cb16). To disable it, use `rc.StopAutoRetry();`.


## Binary content downloading

Some [sample code](./samples.md) for binary content downloading may not work.

Because RingCentral is gradually migrating binary content to CDN such as `media.ringcentral.com`.

For example, to download the attachment of a fax:

```cs
// `message` is the fax message object
var content = await rc.Get<byte[]>(message.attachments[0].uri);
```

The following does **NOT** work:

```cs
// `message` is the fax message object
var content = await rc.Restapi().Account().Extension().MessageStore(message.id).Content(message.attachments[0].id).Get();
```

### Rule of thumb

But not all binary content has been migrated to CDN.
If the resource to download provides you with a CDN uri, use that CDN uri.
If there is no CDN uri provided, construct the uri as the [sample code](./samples.md) shows.


## How to access headers

By default, the SDK doesn't return headers:

```cs
var extInfo = await rc.Restapi().Account("~").Extension("~").Get();
```

If you need headers:

```cs
var httpResponseMessage = await rc.Get(rc.Restapi().Account("~").Extension("~").Path(true));
var headers = httpResponseMessage.Headers;
var responseBodyStr = await httpResponseMessage.Content.ReadAsStringAsync();
var extInfo = JsonConvert.DeserializeObject<GetExtensionInfoResponse>(responseBodyStr);
```


## For maintainers

### Release

Update version number in `RingCentral.Net/RingCentral.Net.csproj` & `RingCentral.Net/RestClient.cs`

```
cd RingCentral.Net
dotnet pack
```

Update version number in `RingCentral.Net.PubnubPCL/RingCentral.Net.PubnubPCL.csproj`

```
cd RingCentral.Net.PubnubPCL
dotnet pack
```

Update version number in `RingCentral.Net.Pubnub\Properties\AssemblyInfo.cs`

Rebuild solution

```
cd RingCentral.Net.Pubnub
nuget pack
```

Reference: [Quickstart: Create and publish a package using Visual Studio (.NET Framework, Windows)](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework)


## Todo

- Add batch get to auto generated sample code
- Exception error message for binary data? Will it print a LOT?
- Support extensions, just like the ringcentral-extensible project
