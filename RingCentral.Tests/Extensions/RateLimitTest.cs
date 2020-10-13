using System;
using RingCentral.Net.RateLimit;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    public class RateLimitTest
    {
        [Fact]
        public async void EnableRateLimit()
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
                var rateLimitExtension = new RateLimitExtension();
                rc.InstallExtension(rateLimitExtension);
                rateLimitExtension.enabled = false; // remove this line to enable rate limit
                var extInfo = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extInfo);
                Assert.NotNull(extInfo.id);
            }
        }
    }
}