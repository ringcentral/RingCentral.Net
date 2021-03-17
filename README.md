# RingCentral.Net

[![Build Status](https://github.com/ringcentral/RingCentral.Net/workflows/.NET/badge.svg?branch=master)](https://github.com/ringcentral/RingCentral.Net/actions)

## Installation

Packages are [available on NuGet](https://www.nuget.org/packages?q=ringcentral.net).
You can install them just like you install any other NuGet packages.


## Extensions

Since version 5.0.0, this project has been changed to an extension based architecture. 

- [RingCentral.Net](./RingCentral.Net) provides core features. 

You need to install extensions if you need extra features:

- [RingCentral.Net.AuthorizeUri](./RingCentral.Net.AuthorizeUri) provides utility methods to build URI for OAuth authorization purpose. 
- [RingCentral.Net.AutoRefresh](./RingCentral.Net.AutoRefresh) auto refreshes your token.
- [RingCentral.Net.Debug](./RingCentral.Net.Debug) prints all HTTP traffic to console.
- [RingCentral.Net.Events](./RingCentral.Net.Events) provides your with events about HTTP requests.
- [RingCentral.Net.Pubnub](./RingCentral.Net.Pubnub) if you need PubNub support and your app targets traditional .NET Framework.
- [RingCentral.Net.PubnubPCL](./RingCentral.Net.PubnubPCL) if you need PubNub support and your app targets .NET Core, Mono, Xamarin...etc.
- [RingCentral.Net.RateLimit](./RingCentral.Net.RateLimit) automatically handles rate limit for you.
- [RingCentral.Net.Retry](./RingCentral.Net.Retry) allows you to retry a REST request if there is `RestException`.


## Code samples

You can find [sample code for all the endpoints](./samples.md).

There is also lots of useful code for your reference in our [test cases](./RingCentral.Tests).


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

Update version number in `RingCentral.Net/RestClient.cs`.

Update version number in `<ProjectName>/<ProjectName>.csproj`

```
cd <ProjectName>
dotnet pack
```

#### RingCentral.Net.Pubnub

Update version number in `RingCentral.Net.Pubnub\Properties\AssemblyInfo.cs`
Update version number in `RingCentral.Net.Pubnub\RingCentral.Net.Pubnub.nuspec`

Rebuild solution

```
cd RingCentral.Net.Pubnub
nuget pack
```

Reference: [Quickstart: Create and publish a package using Visual Studio (.NET Framework, Windows)](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework)


## Todo

- Add batch get to auto generated sample code
- Exception error message for binary data? Will it print a LOT?
- Add icons to NuGet packages
