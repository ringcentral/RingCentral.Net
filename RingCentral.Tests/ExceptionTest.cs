using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class ExceptionTest
    {
        [Fact]
        public async Task WrongPassword()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_SERVER_URL"] as string
            );
            var ex = await Assert.ThrowsAsync<RestException>(async () =>
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    "wrong-password"
                );
            });
            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpResponseMessage.StatusCode);
            Assert.Contains("invalid_grant", ex.Message);
        }
    }
}