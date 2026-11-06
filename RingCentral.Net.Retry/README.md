# Retry Extension

This extension allows you to retry a REST request if there is `RestException`.

Each new SDK request starts with its own retry count, including authorization requests. Reusing a
`RestRequestConfig` or making concurrent requests does not share retry allowances. Retries and request clones
for the same request share the count, including when both `RetryExtension` and `RateLimitExtension` are installed.

The public `RestRequestConfig.retriesAttempted` field has been removed. Callers that referenced it must remove
those references and rebuild; already compiled code that accesses the field is also incompatible. Retry callbacks
still receive the zero-based number of retries attempted for the current request.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
await rc.Authorize(
    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
);
var retryExtension = new RetryExtension();
await rc.InstallExtension(retryExtension);
```

## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/retry)
, check its documentation for more information.
