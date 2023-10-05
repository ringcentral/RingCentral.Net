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

If you would like to keep your app 24 * 7 running. You need to handle some unexpected situations. Like network outage.

Below is a sample code to handle network outage.

```cs
var timer = new PeriodicTimer(TimeSpan.FromMinutes(10));
while (await timer.WaitForNextTickAsync())
{
    if (!wsExtension.ws.IsRunning)
    {
        wsExtension.Reconnect();
    }
}
```

Upon network outage or other unexpected situations, the SDK cannot reconnect automatically. 
You need to write some code to handle such case.


## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/ws)
, check its documentation for more information.
