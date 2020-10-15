using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RingCentral.Net.PubNub;
using Xunit;

namespace RingCentral.Tests
{
    public class SubscriptionTest
    {
        private Task<GetSMSMessageInfoResponse> SendSms(RestClient rc)
        {
            return rc.Restapi().Account().Extension().Sms().Post(new CreateSMSMessage
            {
                from = new MessageStoreCallerInfoRequest
                {
                    phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                },
                to = new[]
                {
                    new MessageStoreCallerInfoRequest
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                    }
                },
                text = "Hello world"
            });
        }

        [Fact]
        public async void TestSetupSubscription()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                
                var pubNubExtension = new PubNubExtension();
                rc.InstallExtension(pubNubExtension);

                var eventFilters = new[]
                {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                    "/restapi/v1.0/account/~/extension/~/message-store"
                };
                var messages = new List<string>();
                var messageStoreMessageCount = 0;
                var subscription = await pubNubExtension.Subscribe(eventFilters, message =>
                {
                    messages.Add(message);
                    dynamic jObject = JObject.Parse(message);
                    var eventString = (string) jObject.@event;
                    if (new Regex("/account/\\d+/extension/\\d+/message-store").Match(eventString).Success)
                    {
                        messageStoreMessageCount += 1;
                        var messageEvent = JsonConvert.DeserializeObject<MessageEvent>(message);
                        Assert.NotNull(messageEvent.uuid);
                        Assert.NotNull(messageEvent.body);
                    }
                });
                var subscriptionInfo = subscription.subscriptionInfo;
                Assert.NotNull(subscriptionInfo);
                Assert.NotNull(subscription.subscriptionInfo);
                Assert.Equal(eventFilters.Length, subscriptionInfo.eventFilters.Length);
                await SendSms(rc);
                await System.Threading.Tasks.Task.Delay(20000);
                Assert.True(messages.Count >= 1);
                Assert.True(messageStoreMessageCount >= 1);
                Assert.Contains(messages, message => message.Contains("message-store"));
                subscriptionInfo = await subscription.Refresh();
                Assert.NotNull(subscriptionInfo);
                Assert.NotNull(subscription.subscriptionInfo);
                Assert.Equal(eventFilters.Length, subscriptionInfo.eventFilters.Length);
                await subscription.Revoke();
                Assert.Null(subscription.subscriptionInfo);
            }
        }
    }
}