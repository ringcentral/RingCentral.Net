# Retry Extension

This extension allows you to retry a REST request if there is `RestException`.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
await rc.Authorize(
    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
);
var retryExtension = new RetryExtension();
await rc.InstallExtension(retryExtension);
```

## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/retry)
, check its documentation for more information.
