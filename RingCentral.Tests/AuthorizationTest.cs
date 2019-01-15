using System;
using Xunit;

namespace RingCentral.Net.Tests
{
    public class AuthorizationTest
    {
        [Fact]
        public async void TestPasswordFlow()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RingCentral(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSS_URL"] as string
            );
            var r = await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );
            Assert.Equal(200, r.metadata.status);
            Assert.NotNull(r.body.access_token);
            var accessToken = r.body.access_token;
            Assert.Equal(accessToken, rc.token.access_token);

            r = await rc.Refresh();
            Assert.Equal(200, r.metadata.status);
            Assert.NotNull(r.body.access_token);
            Assert.Equal(rc.token.access_token, r.body.access_token);
            Assert.NotEqual(accessToken, r.body.access_token);

            var r2 = await rc.Revoke();
            Assert.Equal(200, r2.metadata.status);
            Assert.Null(r2.body); // no response
        }
    }
}
