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

This extension assumes that there will be no network outage. If there is a network outage, it will not try to reconnect.

If you would like to keep your app 24 * 7 running. You need to handle network outage.

Below is a sample code to setup a timer to handle network outage.

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

Or you listen to WebSocket disconnect event instead:

```cs
wsExtension.ws.DisconnectionHappened.Subscribe(info =>
{
    wsExtension.Reconnect();
});
```
The disadvantage of this approach is that at the time of the event, the network outage maybe still ongoing and the `Reconnect()` will not succeed. It's up to you to handle this situation.

By the way, RingCentral.Net SDK expires too. By default it expires in 1 hour. You need to handle the expiration as well:

```cs
rc.Refresh();
```


## More documentation

This extension is inspired
by [its TypeScript counterpart](https://github.com/ringcentral/ringcentral-extensible/tree/master/packages/extensions/ws)
, check its documentation for more information.
