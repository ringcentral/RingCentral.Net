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


## PubNub notification delay issue

If you create multiple subscriptions in a single app and run the app in .NET Framework environment, you may experience notifications delay. Delay time is around 4 minutes and 30 seconds.

A solution/workaround is to add the following to your `app.config` file:

```xml
<system.net>
<connectionManagement>
<add address = "*" maxconnection = "999" />
</connectionManagement>
</system.net>
```

Notes: 
- If you run your app in .NET Core environment, you will not have this issue. 
- If you only create one subscription in your code, you will not have this issue either.
- This is because [by default only 2 connections to a server is allowed](https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/network/add-element-for-connectionmanagement-network-settings).
- More information FYI: https://stackoverflow.com/a/49868185/862862


## More documentation

This extension is inspired by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/pubnub), check its documentation for more information.
