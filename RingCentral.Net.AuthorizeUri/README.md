# Authorize URI extension

This extension provides utility methods to build URI for OAuth authorization purpose.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);

var authorizeUriExtension = new AuthorizeUriExtension();
rc.InstallExtension(authorizeUriExtension);

var redirectUri = "http://localhost:3000/callback";

var uri = authorizeUriExtension.BuildUri(new AuthorizeRequest
{
    redirect_uri = redirectUri,
    state = "myState"
});
```
