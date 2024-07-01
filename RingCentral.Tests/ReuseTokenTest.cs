using System;
using RingCentral.Net.WebSocket;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class ReuseTokenTest
{
    [Fact]
    public async void ReuseTokenAfterSubscription()
    {
        var rc = await ReusableRestClient.GetInstance();
        var webSocketExtension = new WebSocketExtension();
        await rc.InstallExtension(webSocketExtension);

        var cachedToken = rc.token;

        // use the token to make API call
        rc.token = cachedToken;
        var ext = await rc.Restapi().Account().Extension().Get();
        Assert.NotNull(ext.id);

        // create a subscription
        var subscription = await webSocketExtension.Subscribe(
            new[] { "/restapi/v1.0/account/~/extension/~/message-store" },
            message => { Console.WriteLine(message); });

        // use the token again to make API call
        rc.token = cachedToken;
        ext = await rc.Restapi().Account().Extension().Get();
        Assert.NotNull(ext.id);

        webSocketExtension.enabled = false;
    }
}