# Authorize URI extension

This extension provides utility methods to build URI for OAuth authorization purpose.

```cs
var rc = new RestClient(...);

var authorizeUriExtension = new AuthorizeUriExtension(...);
rc.InstallExtension(authorizeUriExtension);
var uri = authorizeUriExtension.BuildUri(new AuthorizeRequest
{
    redirect_uri = "http://localhost:3000/callback",
    state = "myState"
});
```


## More documentation

This extension is inspired by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/authorize-uri), check its documentation for more information.
