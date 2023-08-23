using System;
using Xunit;

namespace RingCentral.Tests
{
    public class PermissionsTest
    {
        [Fact]
        public async void GetPermissions()
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

                var str = await rc.Get<string>("/restapi/v1.0/dictionary/permission/HUD");
                Assert.Contains("HUD", str);
            }
        }
    }
}