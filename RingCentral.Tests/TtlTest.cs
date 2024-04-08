using System;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class TtlTest
    {
        [Fact]
        public async void TestAuth()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                var token = await rc.Authorize(new GetTokenRequest
                {
                    grant_type = "urn:ietf:params:oauth:grant-type:jwt-bearer",
                    assertion = Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN"),
                    access_token_ttl = 1800,
                    refresh_token_ttl = 302400
                });
                Assert.True(token.expires_in > 1700 && token.expires_in < 1900);
                Assert.True(token.refresh_token_expires_in > 302300 && token.refresh_token_expires_in < 302500);
            }
        }

        [Fact]
        public async void TestRefresh()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                var token = await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                Assert.True(token.expires_in > 3500 && token.expires_in < 3700);
                Assert.True(token.refresh_token_expires_in > 604700 && token.refresh_token_expires_in < 604900);

                token = await rc.Authorize(new GetTokenRequest
                {
                    grant_type = "refresh_token",
                    refresh_token = token.refresh_token,
                    access_token_ttl = 1800,
                    refresh_token_ttl = 302400
                });
                Assert.True(token.expires_in > 1700 && token.expires_in < 1900);
                Assert.True(token.refresh_token_expires_in > 302300 && token.refresh_token_expires_in < 302500);
            }
        }
    }
}