using System.Net;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class WebHookTest
{
    [Fact]
    public async void SetupWebHook()
    {
        var rc = await ReusableRestClient.GetInstance();
        try
        {
            await rc.Restapi().Subscription().Post(new CreateSubscriptionRequest
            {
                eventFilters = new[] { "/restapi/v1.0/account/~/extension/~/message-store" },
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
            // Or: webhook URI response is 404
            Assert.Equal(HttpStatusCode.BadRequest, re.httpResponseMessage.StatusCode);
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
//                   Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
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