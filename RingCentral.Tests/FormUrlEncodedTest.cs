using System;
using Xunit;

namespace RingCentral.Tests
{
    // Note: this test class is for API troubleshooting only
    // Please do not reference the code here, it should not be used in production
    public class FormUrlEncodedTest
    {
        [Fact]
        public async void GetAndRevokeToken()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                var tokenInfo = await rc.Restapi(null).Oauth().Token().Post(new GetTokenRequest
                {
                    grant_type = "password",
                    username = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    extension = Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    password = Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                });
                Assert.NotNull(tokenInfo);
                Assert.True(tokenInfo.access_token.Length > 0);

                var r = await rc.Restapi(null).Oauth().Revoke().Post(new RevokeTokenRequest
                {
                    token = tokenInfo.access_token
                });
                Assert.Empty(r);
            }
        }
    }
}