using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class TokenRefreshTest
    {
        [Fact]
        public async Task RefreshToken()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            var responseMessage = await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );
            var refreshToken = rc.Token.refresh_token;
            await rc.Refresh();
            Assert.NotNull(rc.Token);
            Assert.NotNull(rc.Token.refresh_token);
            Assert.NotEqual(refreshToken, rc.Token.refresh_token);

            rc.Token.refresh_token = refreshToken;
            Assert.Equal(refreshToken, rc.Token.refresh_token);
            await rc.Refresh();
            Assert.NotNull(rc.Token);
            Assert.NotNull(rc.Token.refresh_token);
            Assert.NotEqual(refreshToken, rc.Token.refresh_token);

            await rc.Revoke();
        }
    }
}