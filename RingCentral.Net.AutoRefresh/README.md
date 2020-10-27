# Auto Refresh Extension

This extension will auto refresh your token every 30 minutes(customizable).

```cs
var rc = new RestClient(
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
);
var autoRefreshExtension = new AutoRefreshExtension();
rc.InstallExtension(autoRefreshExtension);
autoRefreshExtension.Start();
```

## Disclaimer

[Token management](https://medium.com/ringcentral-developers/ringcentral-token-management-477578f00954) is a complicated topic. 
There is no one-fit-all solution.
This extension is an quick-and-dirty out-of-box solution to refresh your token. It is by no means the best practice. 
It simply starts a background timers to refresh your token periodically. 
For serious production applications, you may need better token management strategy.
