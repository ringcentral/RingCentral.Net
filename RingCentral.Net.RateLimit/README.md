# Rate Limit Extension

This extension automatically handles rate limit for you. If you request API too frequently and hit rate limit, this extension smartly wait and retry your API calls.


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
var rateLimitExtension = new RateLimitExtension();
rc.InstallExtension(rateLimitExtension);
```
