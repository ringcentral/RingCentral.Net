using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class AuthorizationTest
    {
        [Fact]
        public async Task AuthorizeTest()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_SERVER_URL"] as string
            );
            var token = await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );
            Assert.Equal(token, rc.Token);
            Assert.NotNull(rc.Token);
            Assert.NotEmpty(rc.Token.access_token);

            await rc.Revoke();
        }
    }
}