using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class AccountTest
    {
        [Fact]
        public async Task GetAccount()
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

                var account = await rc.Restapi().Account().Get();
                Assert.NotNull(account);
                Assert.NotNull(account.serviceInfo);
            }
        }
    }
}