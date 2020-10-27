# PubNub Extension

Install this extension if you want to use PubNub and your app targets .NET Core, Mono, Xamarin...etc.

Check [RingCentral.Net.Pubnub](../RingCentral.Net.Pubnub) if your app targets traditional .NET framework.


```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
var pubNubExtension = new PubNubExtension();
rc.InstallExtension(pubNubExtension);

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
