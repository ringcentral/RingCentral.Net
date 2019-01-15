using System;
using Xunit;

namespace RingCentral.Net.Tests
{
    public class SmsTest
    {
        [Fact]
        public async void TestSendSms()
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RingCentral(
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
                var r = await rc.Post<GetMessageInfoResponse>("/restapi/v1.0/account/~/extension/~/sms", body);
                Assert.Equal(200, r.metadata.status);
                Assert.Equal("Outbound", r.body.direction);
            }
        }
    }
}
