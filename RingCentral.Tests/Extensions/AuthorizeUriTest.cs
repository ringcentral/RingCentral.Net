using System;
using System.Net;
using RingCentral.Net.AuthorizeUri;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    public class AuthorizeUriTest
    {
        [Fact]
        public async void AuthorizeUri()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );

            var authorizeUriExtension = new AuthorizeUriExtension();
            await rc.InstallExtension(authorizeUriExtension);

            var redirectUri = "http://localhost:3000/callback";

            var uri = authorizeUriExtension.BuildUri(new AuthorizeRequest
            {
                redirect_uri = redirectUri,
                state = "myState"
            });
            Assert.NotNull(uri);
            Assert.Contains("state=myState", uri);

            try
            {
                await rc.Authorize("fakeCode", redirectUri);
                throw new Exception("Code above should throw");
            }
            catch (RestException re)
            {
                Assert.Equal(HttpStatusCode.BadRequest, re.httpResponseMessage.StatusCode);
            }

            var uri2 = authorizeUriExtension.BuildUri(new AuthorizeRequest
            {
                redirect_uri = redirectUri,
                client_id = rc.clientId, // optional
                response_type = "code", // optional
                state = "hello",
                ui_options = "hide_logo"
            });
            Assert.NotNull(uri2);
            Assert.Contains("state=hello", uri2);
            Assert.Contains("ui_options=hide_logo", uri2);

            var uri3 = authorizeUriExtension.BuildUri(new AuthorizeRequest
            {
                redirect_uri = redirectUri,
                state = "hello",
                ui_options = "hide_logo"
            });
            Assert.NotNull(uri3);
            Assert.Contains("response_type=code", uri3);
            Assert.Contains($"client_id={rc.clientId}", uri3);
        }
    }
}