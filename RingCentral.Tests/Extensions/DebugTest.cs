using System;
using RingCentral.Net.Debug;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    public class DebugTest
    {
        [Fact]
        public async void EnableDebugMode()
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
                var debugExtension = new DebugExtension();
                rc.InstallExtension(debugExtension);
                var extInfo = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extInfo);
                Assert.NotNull(extInfo.id);
            }
        }
    }
}