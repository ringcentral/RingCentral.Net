using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class TokenRefreshTest
    {
        [Fact]
        public async Task RefreshTokenTest()
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
        }
    }
}