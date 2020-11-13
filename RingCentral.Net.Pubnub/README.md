# PubNub Extension

Install this extension if you want to use PubNub and your app targets traditional .NET framework.

Check [RingCentral.Net.PubnubPCL](../RingCentral.Net.PubnubPCL) if your app targets .NET Core, Mono, Xamarin...etc.


```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
var pubNubExtension = new PubNubExtension();
await rc.InstallExtension(pubNubExtension);

var eventFilters = new[]
{
    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
    "/restapi/v1.0/account/~/extension/~/message-store"
};
var subscription = await pubNubExtension.Subscribe(eventFilters, message =>
{
    // do something with message
});
```

## More documentation

This extension is inspired by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/pubnub), check its documentation for more information.
