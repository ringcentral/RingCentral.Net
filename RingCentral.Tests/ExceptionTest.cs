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
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            var ex = await Assert.ThrowsAsync<RestException>(async () =>
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    "wrong-password"
                );
            });
            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpResponseMessage.StatusCode);
            Assert.Contains("invalid_grant", ex.Message);
        }
    }
}