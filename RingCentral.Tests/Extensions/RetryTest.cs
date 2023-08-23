using System;
using RingCentral.Net.Retry;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    public class RetryTest
    {
        [Fact]
        public async void EnableAutoRetry()
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
                var retryExtension = new RetryExtension();
                await rc.InstallExtension(retryExtension);
                retryExtension.enabled = false; // remove this line to enable auto retry
                var extInfo = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extInfo);
                Assert.NotNull(extInfo.id);
            }
        }
    }
}