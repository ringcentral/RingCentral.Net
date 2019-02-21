using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xunit;

namespace RingCentral.Tests
{
    // Note: this test class is for API troubleshooting only
    // Please do not reference the code here, it should not be used in production
    public class AuthorizeUriTest
    {
        [Fact]
        public async void GetQueryObj()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                var httpResponseMessage = await rc.Get("/restapi/oauth/authorize", new
                {
                    response_type = "code",
                    redirect_uri = "https://ringcentral.github.io/ringcentral-js-widget/page/redirect.html",
                    client_id = rc.clientId
                });
                Assert.Equal(HttpStatusCode.OK, httpResponseMessage.StatusCode);
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                Assert.Contains("<!DOCTYPE HTML>", content);
            }
        }

        [Fact]
        public async void PostQueryObj()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                var httpResponseMessage = await rc.Post("/restapi/oauth/authorize", null, new
                {
                    response_type = "code",
                    redirect_uri = "https://ringcentral.github.io/ringcentral-js-widget/page/redirect.html",
                    client_id = rc.clientId
                });
                Assert.Equal(HttpStatusCode.OK, httpResponseMessage.StatusCode);
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                Assert.Contains("<!DOCTYPE HTML>", content);
            }
        }

        [Fact]
        public async void PostFormUrlEncoded()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                var dict = new Dictionary<string, string>
                {
                    {"response_type", "code"},
                    {"redirect_uri", "https://ringcentral.github.io/ringcentral-js-widget/page/redirect.html"},
                    {"client_id", rc.clientId}
                };
                var httpResponseMessage = await rc.Request(HttpMethod.Post, "/restapi/oauth/authorize",
                    new FormUrlEncodedContent(dict));
                Assert.Equal(HttpStatusCode.OK, httpResponseMessage.StatusCode);
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                Assert.Contains("<!DOCTYPE HTML>", content);
            }
        }

        [Fact]
        public async void GetFormUrlEncoded()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                var dict = new Dictionary<string, string>
                {
                    {"response_type", "code"},
                    {"redirect_uri", "https://ringcentral.github.io/ringcentral-js-widget/page/redirect.html"},
                    {"client_id", rc.clientId}
                };
                try
                {
                    await rc.Request(HttpMethod.Get, "/restapi/oauth/authorize",
                        new FormUrlEncodedContent(dict));
                    throw new Exception("Line above should throw");
                }
                catch (RestException re)
                {
                    Assert.Equal(HttpStatusCode.BadRequest, re.HttpResponseMessage.StatusCode);
                    var content = await re.HttpResponseMessage.Content.ReadAsStringAsync();
                    Assert.Contains("Unsupported response type", content);
                }
            }
        }
    }
}