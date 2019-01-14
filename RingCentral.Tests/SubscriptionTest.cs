using System;
using System.Collections;
using System.Threading;
using Xunit;

namespace RingCentral.Tests
{
    public class SubscriptionTest
    {
        public IDictionary env = Environment.GetEnvironmentVariables();

        private void SendSms(RestClient rc)
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
            rc.Post<GetMessageInfoResponse>("/restapi/v1.0/account/~/extension/~/sms", body);
        }

        [Fact]
        public async void TestSetupSubscription()
        {
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
                var eventFilters = new string[] {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                    "/restapi/v1.0/account/~/extension/~/message-store"
                };
                var count = 0;
                var r = await rc.Subscribe(eventFilters, message =>
                {
                    count += 1;
                });
                Assert.Equal(200, r.metadata.status);
                Assert.Equal("WebSocket", r.body.deliveryMode.transportType);

                SendSms(rc);

                Thread.Sleep(25000);

                var r2 = await rc.Delete<string>($"/restapi/v1.0/subscription/{r.body.id}");
                Console.WriteLine(r2.rawMessage);

                Assert.True(count >= 1);
            }
        }
    }
}
