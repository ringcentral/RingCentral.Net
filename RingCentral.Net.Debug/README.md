# Debug Extension

This extension will print all HTTP traffic to console. As its name suggests, it is just for debugging purpose.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
var debugExtension = new DebugExtension(...);
await rc.InstallExtension(debugExtension);
```

## Logging action

Optionally, you can provide a `loggingAction` to constructor of `DebugExtension`.

The `loggingAction` determines how the HTTP traffic message is logged. By default it is `Console.WriteLine`

## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/debug)
, check its documentation for more information.
