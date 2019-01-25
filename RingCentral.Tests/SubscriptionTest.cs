using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class SubscriptionTest
    {
        private async void SendSms(RestClient rc)
        {
            var httpContent = new StringContent(JsonConvert.SerializeObject(new
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
            }), Encoding.UTF8, "application/json");
            await rc.Post("/restapi/v1.0/account/~/extension/~/sms", httpContent);
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

                var eventFilters = new[]
                {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                    "/restapi/v1.0/account/~/extension/~/message-store"
                };
                var subscription = new Subscription(rc, eventFilters, message =>
                {
                    // do something
                });
                var subscriptionInfo = await subscription.Subscribe();
                Assert.NotNull(subscriptionInfo);
                Assert.NotNull(subscription.subscriptionInfo);
                Assert.Equal(eventFilters.Length, subscriptionInfo.eventFilters.Length);
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