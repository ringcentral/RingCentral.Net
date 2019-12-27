using System;
using Xunit;

namespace RingCentral.Tests
{
    public class ForwardingNumberTest
    {
        [Fact]
        public async void GetForwardingNumberList()
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
                var extension = rc.Restapi().Account().Extension();

                var r = await extension.ForwardingNumber().List();
                Assert.NotNull(r.records);
//                Assert.NotEmpty(r.records);

                // a complicated way, not recommended
                var response = await rc.Get(extension.ForwardingNumber().Path(false));
                var body = await response.Content.ReadAsStringAsync();
                Assert.NotNull(response);
                Assert.NotEmpty(body);
            }
        }
    }
}