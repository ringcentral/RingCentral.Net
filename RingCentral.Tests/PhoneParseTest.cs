using System;
using Xunit;

namespace RingCentral.Tests
{
    public class PhoneParseTest
    {
        [Fact]
        public async void ParseNumber()
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

                var r = await rc.Restapi().NumberParser().Parse().Post(new ParsePhoneNumberRequest
                {
                    originalStrings = new[] {"+1650-666-8888", "+1650-666-9999"}
                });
                Assert.NotNull(r);
            }
        }
    }
}