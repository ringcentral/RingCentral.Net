using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Net.Tests
{
    public class SubscriptionTest
    {
        public IDictionary env = Environment.GetEnvironmentVariables();

        private async void SendSms(RingClient rc)
        {
            var body = new CreateSMSMessage
            {
                from = new MessageStoreCallerInfoRequest
                {
                    phoneNumber = env["RINGCENTRAL_USERNAME"] as string
                },
                to = new MessageStoreCallerInfoRequest[]
                    {
                        new MessageStoreCallerInfoRequest
                        {
                            phoneNumber = env["RINGCENTRAL_RECEIVER"] as string
                        }
                    },
                text = "Hello world"
            };
            await rc.Post<GetMessageInfoResponse>("/restapi/v1.0/account/~/extension/~/sms", body);
        }

        [Fact]
        public async void TestSetupSubscription()
        {
            using (var rc = new RingClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSS_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                var eventFilters = new string[] {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                    "/restapi/v1.0/account/~/extension/~/message-store"
                };

                var count = 0;
                var subscription = new Subscription(rc, eventFilters, message =>
                {
                    count += 1;
                });
                var r = await subscription.Subscribe();
                Assert.Equal(200, r.metadata.status);
                Assert.Equal("WebSocket", r.body.deliveryMode.transportType);

                r = await subscription.Refresh();
                Assert.Equal(200, r.metadata.status);

                SendSms(rc);
                await Task.Delay(15000);

                var r2 = await subscription.Revoke();
                Assert.Equal(204, r2.metadata.status);

                Assert.True(count >= 1);
            }
        }
    }
}
