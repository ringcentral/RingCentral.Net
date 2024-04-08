using System;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class TokenRefreshTest
    {
        [Fact]
        public async void RefreshToken()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
            );
            var refreshToken = rc.token.refresh_token;
            await rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotNull(rc.token.refresh_token);
            Assert.NotEqual(refreshToken, rc.token.refresh_token);

            rc.token.refresh_token = refreshToken;
            Assert.Equal(refreshToken, rc.token.refresh_token);
            await rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotNull(rc.token.refresh_token);
            Assert.NotEqual(refreshToken, rc.token.refresh_token);

            await rc.Revoke();
        }
    }
}