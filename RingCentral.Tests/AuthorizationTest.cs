using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            Assert.Equal(token, rc.token);
            Assert.NotNull(rc.token);
            Assert.NotEmpty(rc.token.access_token);

            var oldToken = rc.token.access_token;
            await rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotEqual(oldToken, rc.token.access_token);

            // refresh null token
            var temp = new RestClient("", "");
            await temp.Refresh(); // refresh null token
            Assert.Null(temp.token);

            // revoke null token
            await temp.Revoke();
            Assert.Null(temp.token);

            await rc.Revoke();
        }

        [Fact]
        public async void AuthorizeUri()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );

            var redirectUri = "http://localhost:3000/callback";

            var uri = rc.AuthorizeUri(redirectUri, "myState");
            Assert.NotNull(uri);
            Assert.Contains("state=myState", uri);

            try
            {
                await rc.Authorize("fakeCode", redirectUri);
                throw new Exception("Code above should throw");
            }
            catch (RestException re)
            {
                Assert.Equal(HttpStatusCode.BadRequest, re.HttpResponseMessage.StatusCode);
            }

            var uri2 = rc.AuthorizeUri(redirectUri, new OAuthOptions {state = "hello"}, new {ui_options = "hide_logo"});
            Assert.NotNull(uri2);
            Assert.Contains("state=hello", uri2);
            Assert.Contains("ui_options=hide_logo", uri2);
        }

        [Fact]
        public async void TestRefreshWithTokenOnly()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );

            // suppose data is read from file
            var data = JsonConvert.SerializeObject(rc.token);

            // suppose token is null (not logged in)
            rc.token = null;

            // deserialize to get token
            var token = JsonConvert.DeserializeObject<TokenInfo>(data);

            // refresh by refresh token
            await rc.Refresh(token.refresh_token);

            // got token from server
            Assert.NotNull(rc.token);

            // assert access_token not null
            Assert.NotNull(rc.token.access_token);

            await rc.Revoke();
        }


        [Fact]
        public async void TestRefreshWithSavedToken()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );

            // suppose data is read form file
            var data = JsonConvert.SerializeObject(rc.token);

            // suppose token is null (not logged in)
            rc.token = null;

            // deserialize to get token
            var token = JsonConvert.DeserializeObject<TokenInfo>(data);
            rc.token = token;

            // refresh
            await rc.Refresh();

            // got token from server
            Assert.NotNull(rc.token);

            // assert access_token is not null
            Assert.NotNull(rc.token.access_token);

            await rc.Revoke();
        }
    }
}