# Events Extension

This extension provides your with events about HTTP requests, so that you can subscribe to them.

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
)
var eventsExtension = new EventsExtension();
rc.InstallExtension(eventsExtension);

var count = 0;

void EventHandler(object sender, HttpMessages httpMessages)
{
    // do something with httpMessages
}

eventsExtension.RequestSuccess += EventHandler;
```
