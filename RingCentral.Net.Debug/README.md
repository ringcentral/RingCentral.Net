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
