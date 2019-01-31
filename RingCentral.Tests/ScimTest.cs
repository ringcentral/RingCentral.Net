using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class ScimTest
    {
        [Fact]
        public async Task GetServiceProviderConfig()
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

                var serviceProviderConfig = await rc.Scim().ServiceProviderConfig().Get();
                Assert.Equal(new[]{"urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig"}, serviceProviderConfig.schemas);
            }
        }
    }
}