using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class CancellationTest
{
    [Fact]
    public async Task CancelInFlightRequest()
    {
        using var source = new CancellationTokenSource();
        using var client = new HttpClient(new CancelingHandler(source));
        var originalClient = RestClient.httpClient;
        RestClient.httpClient = client;
        try
        {
            var rc = new RestClient("test-client", "test-secret")
            {
                token = new TokenInfo { access_token = "fake-token" }
            };
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => rc.Get("/test",
                restRequestConfig: new RestRequestConfig { cancellationToken = source.Token }));
        }
        finally
        {
            RestClient.httpClient = originalClient;
        }
    }

    private sealed class CancelingHandler(CancellationTokenSource source) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            source.Cancel();
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
        }
    }
}
