using System;
using System.Net;
using System.Threading.Tasks;
using RingCentral;
using Xunit;

namespace RingCentral.Tests
{
    public class UnitTest1
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
            var responseMessage = await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );
            Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
            var responseString = await responseMessage.Content.ReadAsStringAsync();
            Assert.Contains("access_token", responseString);
            Assert.NotNull(rc.token);
            Assert.NotEmpty(rc.token.access_token);
        }
    }
}