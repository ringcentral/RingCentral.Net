# WebSocket Extension

WebSocket Extension adds support for WebSocket protocol.

```cs
var rc = new RestClient(...);
var webSocketExtension = new WebSocketExtension(...);
await rc.InstallExtension(webSocketExtension);

var eventFilters = new[]
{
    "/restapi/v1.0/account/~/extension/~/message-store"
};
var subscription = await webSocketExtension.Subscribe(eventFilters, message =>
{
    // do something with message
});
```

## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/ws)
, check its documentation for more information.

## Todo

- Rest over WebSocket
- Auto recover
