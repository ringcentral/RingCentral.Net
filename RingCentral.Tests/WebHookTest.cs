using System;
using Xunit;

namespace RingCentral.Tests
{
    public class WebHookTest
    {
        [Fact]
        public async void SetupWebHook()
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
                try
                {
                    await rc.Restapi().Subscription().Post(new CreateSubscriptionRequest
                    {
                        eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"},
                        deliveryMode = new NotificationDeliveryModeRequest
                        {
                            transportType = "WebHook",
                            address = "http://www.example.com/webhook"
                        }
                    });
                }
                catch (RestException re)
                {
                    Assert.Contains("{\"errorCode\":\"SUB-522\"", re.Message);
                }
            }
        }
    }
}