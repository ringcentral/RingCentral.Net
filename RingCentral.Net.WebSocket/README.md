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
Creating multiple subscriptions with one WebSocketExtension instance will cause the last subscription to override the
previous ones.

## 24 * 7 long running applications

In order to keep your WebSocket appliation 24 * 7 running, there are several things that you need to handle:

- first of all, you need to keep you token valid. You can use `rc.Refresh()` to refresh the token.
- secondly, you need to handle network outage. If there is a network outage, you need to `wsExtension.Reconnect()` when
  network is back.
- lastly, there is a rare case: There is a 5 active oauth sessions per user per app limit. If you try to create 5 +
  sessions, existing ones will be revoked and `rc.Refresh()` will fail and your WebSocket connection will not function
  either. In this case, you need to generate a new token and `wsExtension.Reconnect()`.

Please refer to this demo code:
https://github.com/tylerlong/RingCentral.WebSocket.Demo/blob/main/RingCentral.WebSocket.Demo/Program.cs

Please read the **comments** in the code carefully.
