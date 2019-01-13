using System;
using Xunit;

namespace RingCentral.Tests
{
    public class SubscriptionTest
    {
        [Fact]
        public async void TestSetupSubscription()
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSG_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                var eventFilters = new string[] { "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true" };
                var r = await rc.Subscribe(eventFilters, msg =>
                {
                    Console.WriteLine(msg);
                });
                Assert.Equal(200, r.metadata.status);
                Assert.Equal("WebSocket", r.body.deliveryMode.transportType);
            }
        }
    }
}
