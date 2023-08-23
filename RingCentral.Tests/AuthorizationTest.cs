using System;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class AuthorizationTest
    {
        [Fact]
        public async void AuthorizeTest()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            var token = await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
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
            try
            {
                await temp.Refresh(); // refresh null token
                throw new Exception("Line above should throw");
            }
            catch (ArgumentNullException ane)
            {
                Assert.Equal("tokenToRefresh", ane.ParamName);
            }

            Assert.Null(temp.token);

            // revoke null token
            await temp.Revoke();
            Assert.Null(temp.token);

            await rc.Revoke();
        }

        [Fact]
        public async void TestRefreshWithTokenAsParameter()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
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
        public async void LoadTokenTest()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
            );

            // suppose data is read from file
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

        // [Fact]
        // public async void GetLoginLinkTest()
        // {
        //     var rc = new RestClient(
        //         Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
        //         Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
        //         Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
        //     );
        //     var str = await rc.Restapi(null).Oauth().Authorize().Post(new AuthorizeRequest
        //     {
        //         response_type = "code",
        //         redirect_uri = "http://localhost:8080/oauth2callback",
        //         client_id = Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID")
        //     });
        //     Assert.True(str.Length > 0);
        //     Assert.StartsWith("<!DOCTYPE HTML>", str);
        // }
    }
}