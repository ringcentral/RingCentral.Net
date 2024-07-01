using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RingCentral.Net.WebSocket;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class SubscriptionTest
{
    private Task<GetInternalTextMessageInfoResponse> SendPager(RestClient rc)
    {
        return rc.Restapi().Account().Extension().CompanyPager().Post(new CreateInternalTextMessageRequest
        {
            from = new PagerCallerInfoRequest
            {
                extensionId = rc.token.owner_id
            },
            to = new[]
            {
                new PagerCallerInfoRequest
                {
                    extensionId = rc.token.owner_id
                }
            },
            text = "Hello world"
        });
    }

    [Fact]
    public async void TestSetupSubscription()
    {
        var rc = await ReusableRestClient.GetInstance();

        var webSocketExtension = new WebSocketExtension();
        await rc.InstallExtension(webSocketExtension);

        var eventFilters = new[]
        {
            "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
            "/restapi/v1.0/account/~/extension/~/message-store"
        };
        var messages = new List<string>();
        var messageStoreMessageCount = 0;
        var subscription = await webSocketExtension.Subscribe(eventFilters, message =>
        {
            messages.Add(message);
            dynamic jObject = JObject.Parse(message);
            var eventString = (string)jObject.@event;
            if (new Regex("/account/\\d+/extension/\\d+/message-store").Match(eventString).Success)
            {
                messageStoreMessageCount += 1;
                var messageEvent = JsonConvert.DeserializeObject<MessageEvent>(message);
                Assert.NotNull(messageEvent.uuid);
                Assert.NotNull(messageEvent.body);
            }
        });
        var subscriptionInfo = subscription.SubscriptionInfo;
        Assert.NotNull(subscriptionInfo);
        Assert.NotNull(subscription.SubscriptionInfo);
        Assert.Equal(eventFilters.Length, subscriptionInfo.eventFilters.Length);
        await SendPager(rc);
        await Task.Delay(30000);
        Assert.True(messages.Count >= 1);
        Assert.True(messageStoreMessageCount >= 1);
        Assert.Contains(messages, message => message.Contains("message-store"));
        await webSocketExtension.Revoke();
        Assert.Null(subscription.SubscriptionInfo);

        webSocketExtension.enabled = false;
    }
}