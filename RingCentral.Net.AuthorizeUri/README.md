# Authorize URI extension

This extension provides utility methods to build URI for OAuth authorization purpose.

```cs
var rc = new RestClient(...);

var authorizeUriExtension = new AuthorizeUriExtension(...);
await rc.InstallExtension(authorizeUriExtension);
var uri = authorizeUriExtension.BuildUri(new AuthorizeRequest
{
    redirect_uri = "http://localhost:3000/callback",
    state = "myState"
});
```

## PKCE

Please refer to the [TypeScript SDK documentation](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/authorize-uri#pkce) for more information. These two SDKs are very similar.

In short, when you invoke the `BuildUri` method, if you can pass in a `code_challenge_method` property with value `"S256"`, the method will auto generate `codeVerifer` and `code_challenge` for you. codeVerifier is accessible via `authorizeUriExtension.codeVerifier` after the method is called. `code_challenge` is included in the URI.


## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/authorize-uri)
, check its documentation for more information.
