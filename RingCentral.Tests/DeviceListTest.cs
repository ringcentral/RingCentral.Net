using System;
using Xunit;

namespace RingCentral.Tests
{
    public class DeviceListTest
    {
        [Fact]
        public async void GetDeviceList()
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

                var username = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME");
                var r = await rc.Get("/restapi/v1.0/account/~/device");
                var str = r.Content.ReadAsStringAsync();
                Assert.NotNull(str);
            }
        }
    }
}