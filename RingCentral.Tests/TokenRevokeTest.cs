using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class TokenRevokeTest
    {
        [Fact]
        public async Task RevokeToken()
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
            Assert.NotNull(rc.Token);
            await rc.Revoke();
            Assert.Null(rc.Token);
        }
    }
}