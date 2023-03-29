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

## Limitations

Each WebSocketExtension can only create one subscription.
If you need to create multiple subscriptions, you need to create multiple WebSocketExtension instances.
Creating multiple subscriptions with one WebSocketExtension instance will cause the last subscription to override the previous ones.

## More documentation

This extension is inspired by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/ws), check its documentation for more information.

## Todo

- Auto recover
