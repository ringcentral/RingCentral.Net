# RingCentral.Net

[![Build Status](https://github.com/ringcentral/RingCentral.Net/workflows/.NET/badge.svg?branch=master)](https://github.com/ringcentral/RingCentral.Net/actions)
[![Code Document](https://img.shields.io/badge/csharpdoc-reference-blue?branch=master&service=github)](https://ringcentral.github.io/RingCentral.Net/html/annotated.html)

## Getting help and support

If you are having difficulty using this SDK, or working with the RingCentral API, please visit our [developer community forums](https://community.ringcentral.com/spaces/144/) for help and to get quick answers to your questions. If you wish to contact the RingCentral Developer Support team directly, please [submit a help ticket](https://developers.ringcentral.com/support/create-case) from our developer website.

## Additional resources

* [RingCentral API Reference](https://developer.ringcentral.com/api-docs/latest/index.html) - an interactive reference for the RingCentral API that allows developers to make API calls with no code.
* [Document](https://ringcentral.github.io/RingCentral.Net/html/annotated.html) - an interactive reference for the SDK code documentation.

## Installation

Packages are [available on NuGet](https://www.nuget.org/packages?q=ringcentral.net).
You can install them just like you install any other NuGet packages.

This package is compatible with [.NET Standard 2.0](https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0), which means, it is compatible with all modern .NET platforms including .NET Core, .NET Framework, and Mono.


## Extensions

Since version 5.0.0, this project has been changed to an extension-based architecture. 

- [RingCentral.Net](./RingCentral.Net) provides core features. 

You need to install extensions if you need extra features:

- [RingCentral.Net.WebSocket](./RingCentral.Net.WebSocket) provides you with WebSocket support. You can subscribe to events.
- [RingCentral.Net.AuthorizeUri](./RingCentral.Net.AuthorizeUri) provides utility methods to build URI for OAuth authorization purposes. 
- [RingCentral.Net.AutoRefresh](./RingCentral.Net.AutoRefresh) auto-refreshes your token.
- [RingCentral.Net.Debug](./RingCentral.Net.Debug) prints all HTTP traffic to the console.
- [RingCentral.Net.Events](./RingCentral.Net.Events) provides you with events about HTTP requests.
- [RingCentral.Net.RateLimit](./RingCentral.Net.RateLimit) automatically handles the rate limit for you.
- [RingCentral.Net.Retry](./RingCentral.Net.Retry) allows you to retry a REST request if there is `RestException`.


## Code samples

You can find [sample code for all the endpoints](./RingCentral.Net/samples.md).

There is also lots of useful code for your reference in our [test cases](./RingCentral.Tests).


## Logging

The SDK takes advantage of [System](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.trace?view=net-6.0).Diagnostics.Trace](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.trace?view=net-6.0) to provide logs.

To enable logging, you need to either add `#define TRACE` to your source or specify the option `/d:TRACE` when compiling.

To specify an output channel, you need to specify a listener: 

```cs
Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
```

Code about will print logs to the console. For more detail please refer to [Trace.Listeners Property](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.trace.listeners?view=net-6.0).

[Demo project](https://github.com/tylerlong/rc-logging-demo-csharp).


## C# `using` statement

Please note that if you use the `using` statement to initialize a `RestClient`:

```cs
using (var rc = new RestClient("clientID", "clientSecret", "serverURL"))
{
    await rc.Authorize("username", "extension", "password");
    ...
}
````

`rc.Dispose()` will be automatically invoked after the code block above and the **token will be revoked**.

If you want to retain the token, do NOT use `using` and do not `rc.Revoke()`. 


## Binary content downloading

Some [sample code](./RingCentral.Net/samples.md) for binary content downloading may not work.

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
If the resource to download provides you with a CDN URI, use that CDN URI.
If there is no CDN URI provided, construct the URI as the [sample code](./samples.md) shows.


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

## Release Notes

### 6.0.0

We have renamed all "glip" to "team-messaging". For example:

```cs
rc.Restapi().Glip().Chats().List();
```

Becomes:

```cs
rc.TeamMessaging().Chats().List();
```


## For maintainers

### Release
Update the version number in `RingCentral.Net/RestClient.cs`.

Update version number in `<ProjectName>/<ProjectName>.csproj`

```
cd <ProjectName>
dotnet pack
```

## Todo

- Add batch get to auto-generated sample code
- Add icons to NuGet packages


## Development Notes

I tried to migrate from Newtonsoft.Json to System.Text.Json, but it's not easy.
Especially System.Text.Json doesn't automatically convert string to number. It doesn't even automatically convert double to int64.
Considering the complexity and benefits of the migration, I decided to keep using Newtonsoft.Json for now.
Ref: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft


## Code coverage

Install the following globally if you haven't done so:
```
dotnet tool install -g dotnet-reportgenerator-globaltool
```

### Collect code coverage data

```
dotnet test -settings RingCentral.Tests/coverlet.runsettings.xml
```
The result is located in RingCentral.Tests/TestResults/


### Generate report

```
~/.dotnet/tools/reportgenerator -reports:"RingCentral.Tests/TestResults/239bdb87–151b-42ac-acec-1f604f8c02c5/coverage.cobertura.xml" -targetdir:RingCentral.Tests/CoverageReport -reporttypes:Html
```
Open RingCentral.Tests/CoverageReport/index.html in a browser.
