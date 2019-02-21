using System;
using System.Net;
using Xunit;

namespace RingCentral.Tests
{
    public class ExceptionTest
    {
        [Fact]
        public async void WrongPassword()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            var re = await Assert.ThrowsAsync<RestException>(async () =>
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    "wrong-password"
                );
            });
            Assert.Equal(HttpStatusCode.BadRequest, re.HttpResponseMessage.StatusCode);
            Assert.Contains("invalid_grant", re.Message);
        }
    }
}