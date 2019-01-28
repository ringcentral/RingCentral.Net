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
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            var token = await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );
            Assert.Equal(token, rc.Token);
            Assert.NotNull(rc.Token);
            Assert.NotEmpty(rc.Token.access_token);

            await rc.Revoke();
        }
    }
}