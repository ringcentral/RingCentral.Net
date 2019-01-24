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
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_SERVER_URL"] as string
            );
            var responseMessage = await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
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