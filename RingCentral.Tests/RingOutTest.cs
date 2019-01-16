using System;
using Xunit;

namespace RingCentral.Net.Tests
{
    public class RingOutTest
    {
        [Fact]
        public async void TestRingOut()
        {
            var env = Environment.GetEnvironmentVariables();
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
                // var r = await rc.Post("/restapi/v1.0/account/~/extension/~/ring-out", new MakeRingOutRequest
                // {
                //     from = new MakeRingOutCallerInfoRequestFrom
                //     {
                //         phoneNumber = env["RINGCENTRAL_USERNAME"] as string
                //     },
                //     to = new MakeRingOutCallerInfoRequestTo
                //     {
                //         phoneNumber = env["RINGCENTRAL_RECEIVER"] as string
                //     }
                // });

                // Assert.Equal(200, r.metadata.status);
                // Console.WriteLine(r.body);
            }
        }
    }
}
