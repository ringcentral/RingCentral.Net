using System;
using System.Net;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
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
                "wrong-jwt"
            );
        });
        Assert.Equal(HttpStatusCode.BadRequest, re.httpResponseMessage.StatusCode);
        Assert.Contains("Unparseable assertion", re.Message);
    }
}