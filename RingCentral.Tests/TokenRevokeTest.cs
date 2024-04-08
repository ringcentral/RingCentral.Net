using System;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class TokenRevokeTest
    {
        [Fact]
        public async void RevokeToken()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
            );
            Assert.NotNull(rc.token);
            await rc.Revoke();
            Assert.Null(rc.token);
        }
    }
}