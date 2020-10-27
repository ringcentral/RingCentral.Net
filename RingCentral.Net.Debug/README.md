# Debug Extension

This extension will print all HTTP traffic to console. As its name suggests, it is just for debugging purpose.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
var debugExtension = new DebugExtension();
rc.InstallExtension(debugExtension);
```


## More documentation

This extension is inspired by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/debug), check its documentation for more information.
