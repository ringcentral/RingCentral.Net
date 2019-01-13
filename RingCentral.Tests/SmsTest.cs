using System;
using Xunit;

namespace RingCentral.Tests
{
    public class SmsTest
    {
        [Fact]
        public async void TestSendSms()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSG_URL"] as string
            );
            await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );

            await rc.Revoke();
        }
    }
}
