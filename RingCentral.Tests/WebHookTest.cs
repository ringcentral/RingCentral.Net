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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
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
                    // "errorCode":"SUB-523","message":"HTTPS is required"
                    Assert.Contains("{\"errorCode\":\"SUB-523\"", re.Message);
                }
            }
        }

//        [Fact]
//        public async void VerificationToken()
//        {
//            using (var rc = new RestClient(
//                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
//                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
//                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
//            ))
//            {
//                await rc.Authorize(
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
//                );
//                var subscriptionInfo = await rc.Restapi().Subscription().Post(new CreateSubscriptionRequest
//                {
//                    eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true"},
//                    deliveryMode = new NotificationDeliveryModeRequest
//                    {
//                        transportType = "WebHook",
//                        address = "https://75ef5993.ngrok.io/webhook",
//                        verificationToken = "hello-world"
//                    },
//                    expiresIn = 630720000
//                });
//                Assert.Equal(630720000, subscriptionInfo.expiresIn);
//            }
//        }
    }
}