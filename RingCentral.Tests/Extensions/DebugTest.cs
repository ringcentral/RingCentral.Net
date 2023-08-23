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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                var debugExtension = new DebugExtension();
                await rc.InstallExtension(debugExtension);
                debugExtension.enabled = false; // remove this line to enable debug mode
                var extInfo = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extInfo);
                Assert.NotNull(extInfo.id);
            }
        }
    }
}