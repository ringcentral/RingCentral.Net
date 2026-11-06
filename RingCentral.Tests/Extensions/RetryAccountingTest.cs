using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RingCentral.Net.Events;
using RingCentral.Net.RateLimit;
using RingCentral.Net.Retry;
using Xunit;

namespace RingCentral.Tests.Extensions;

[Collection("Sequential")]
public class RetryAccountingTest
{
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task SuccessiveRequestsHaveIndependentRetryAllowances(bool explicitConfig)
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = 0;
        rc.extensibleRequest = (request, _) => Respond(request,
            ++attempts % 2 == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK);
        await rc.InstallExtension(new RetryExtension(new RetryOptions
        {
            shouldRetry = (_, retriesAttempted) => retriesAttempted < 1,
            retryInterval = (_, _) => 0
        }));
        var config = explicitConfig ? new RestRequestConfig() : null;

        Assert.Equal(HttpStatusCode.OK, (await rc.Get("/test", restRequestConfig: config)).StatusCode);
        Assert.Equal(HttpStatusCode.OK, (await rc.Get("/test", restRequestConfig: config)).StatusCode);
        Assert.Equal(4, attempts);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task ExhaustionDoesNotConsumeNextRequestsAllowance(bool explicitConfig)
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = new List<int>();
        var intervals = new List<int>();
        var recoveryAttempts = 0;
        rc.extensibleRequest = (request, _) => Respond(request,
            request.RequestUri.AbsolutePath == "/exhaust" || ++recoveryAttempts == 1
                ? (HttpStatusCode)429
                : HttpStatusCode.OK);
        await rc.InstallExtension(new RetryExtension(new RetryOptions
        {
            shouldRetry = (_, count) =>
            {
                attempts.Add(count);
                return count < 2;
            },
            retryInterval = (_, count) =>
            {
                intervals.Add(count);
                return 0;
            }
        }));
        var config = explicitConfig ? new RestRequestConfig() : null;

        await Assert.ThrowsAsync<RestException>(() => rc.Get("/exhaust", restRequestConfig: config));
        Assert.Equal(HttpStatusCode.OK, (await rc.Get("/recover", restRequestConfig: config)).StatusCode);
        Assert.Equal(new[] { 0, 1, 2, 0 }, attempts);
        Assert.Equal(new[] { 0, 1, 0 }, intervals);
        Assert.Equal(2, recoveryAttempts);
    }

    [Fact]
    public async Task DefaultConfigDoesNotShareRetryAllowancesAcrossClients()
    {
        for (var i = 0; i < 2; i++)
        {
            var rc = new RestClient("test-client", "test-secret");
            var attempts = 0;
            rc.extensibleRequest = (request, _) => Respond(request,
                ++attempts == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK);
            await rc.InstallExtension(Retry(1));

            Assert.Equal(HttpStatusCode.OK, (await rc.Get("/test")).StatusCode);
            Assert.Equal(2, attempts);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task OverlappingRequestsHaveIndependentRetryAllowances(bool explicitConfig)
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = new ConcurrentDictionary<string, int>();
        var bothStarted = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        var firstCompleted = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        rc.extensibleRequest = async (request, _) =>
        {
            var path = request.RequestUri.AbsolutePath;
            var attempt = attempts.AddOrUpdate(path, 1, (_, count) => count + 1);
            if (attempt == 1)
            {
                if (path == "/first") await bothStarted.Task;
                else
                {
                    bothStarted.SetResult(true);
                    await firstCompleted.Task;
                }
            }

            return await Respond(request, attempt == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK);
        };
        await rc.InstallExtension(Retry(1));
        var config = explicitConfig ? new RestRequestConfig() : null;

        var first = rc.Get("/first", restRequestConfig: config);
        var second = rc.Get("/second", restRequestConfig: config);
        Assert.Equal(HttpStatusCode.OK, (await first.WaitAsync(TimeSpan.FromSeconds(5))).StatusCode);
        firstCompleted.SetResult(true);
        Assert.Equal(HttpStatusCode.OK, (await second.WaitAsync(TimeSpan.FromSeconds(5))).StatusCode);
        Assert.Equal(2, attempts["/first"]);
        Assert.Equal(2, attempts["/second"]);
    }

    [Fact]
    public async Task NonRetryableFailureIsPropagatedWithoutRetry()
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = 0;
        rc.extensibleRequest = (request, _) =>
        {
            attempts++;
            return Respond(request, HttpStatusCode.BadRequest);
        };
        await rc.InstallExtension(new RetryExtension(new RetryOptions { retryInterval = (_, _) => 0 }));

        var failure = await Assert.ThrowsAsync<RestException>(() => rc.Get("/test"));
        Assert.Equal(HttpStatusCode.BadRequest, failure.httpResponseMessage.StatusCode);
        Assert.Equal(1, attempts);
    }

    [Fact]
    public async Task RetriedRequestsPreserveContentAndConfig()
    {
        var rc = new RestClient("test-client", "test-secret");
        using var cancellation = new CancellationTokenSource();
        var config = new RestRequestConfig
        {
            cancellationToken = cancellation.Token,
            customHeaders = new Dictionary<string, string> { ["X-Test"] = "value" }
        };
        var attempts = 0;
        rc.extensibleRequest = async (request, receivedConfig) =>
        {
            Assert.Same(config, receivedConfig);
            Assert.Equal(cancellation.Token, receivedConfig.cancellationToken);
            Assert.Equal("value", receivedConfig.customHeaders["X-Test"]);
            Assert.Equal(HttpMethod.Post, request.Method);
            Assert.Equal("payload", await request.Content.ReadAsStringAsync());
            return await Respond(request, ++attempts == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK);
        };
        await rc.InstallExtension(Retry(1));

        Assert.Equal(HttpStatusCode.OK, (await rc.Post("/test", "payload", restRequestConfig: config)).StatusCode);
        Assert.Equal(2, attempts);
    }

    [Fact]
    public async Task AuthorizationRequestsHaveIndependentRetryAllowances()
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = 0;
        rc.extensibleRequest = (request, _) =>
        {
            Assert.Equal("/restapi/oauth/token", request.RequestUri.AbsolutePath);
            return Respond(request, ++attempts % 2 == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK,
                "{\"access_token\":\"fake-token\"}");
        };
        await rc.InstallExtension(Retry(1));

        Assert.Equal("fake-token", (await rc.Authorize("fake-jwt")).access_token);
        Assert.Equal("fake-token", (await rc.Authorize("fake-jwt")).access_token);
        Assert.Equal(4, attempts);
    }

    [Fact]
    public async Task RateLimitExtensionHasIndependentRetryAllowances()
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = 0;
        rc.extensibleRequest = (request, _) => Respond(request,
            ++attempts % 2 == 1 ? (HttpStatusCode)429 : HttpStatusCode.OK);
        await rc.InstallExtension(new RateLimitExtension(new RateLimitOptions { maxRetries = 1, rateLimitWindow = 0 }));

        Assert.Equal(HttpStatusCode.OK, (await rc.Get("/test")).StatusCode);
        Assert.Equal(HttpStatusCode.OK, (await rc.Get("/test")).StatusCode);
        Assert.Equal(4, attempts);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task CombinedExtensionsShareOneAllowanceAndReenterThePipeline(bool rateLimitFirst)
    {
        var rc = new RestClient("test-client", "test-secret");
        var attempts = 0;
        rc.extensibleRequest = (request, _) =>
        {
            attempts++;
            return Respond(request, (HttpStatusCode)429);
        };
        var retry = Retry(2);
        var rateLimit = new RateLimitExtension(new RateLimitOptions { maxRetries = 1, rateLimitWindow = 0 });
        await rc.InstallExtension(rateLimitFirst ? rateLimit : retry);
        await rc.InstallExtension(rateLimitFirst ? retry : rateLimit);
        var pipelineEntries = 0;
        var events = new EventsExtension();
        events.BeforeRequest += (_, _) => pipelineEntries++;
        await rc.InstallExtension(events);

        await Assert.ThrowsAsync<RestException>(() => rc.Get("/test"));
        Assert.Equal(3, attempts);
        Assert.Equal(3, pipelineEntries);
    }

    private static RetryExtension Retry(int maxRetries) => new(new RetryOptions
    {
        shouldRetry = (_, count) => count < maxRetries,
        retryInterval = (_, _) => 0
    });

    private static Task<HttpResponseMessage> Respond(HttpRequestMessage request, HttpStatusCode status,
        string content = "{}")
    {
        var response = new HttpResponseMessage(status) { Content = new StringContent(content) };
        if (!response.IsSuccessStatusCode) throw new RestException(response, request);
        return Task.FromResult(response);
    }
}
