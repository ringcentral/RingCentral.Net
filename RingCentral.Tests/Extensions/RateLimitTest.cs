using RingCentral.Net.RateLimit;
using Xunit;

namespace RingCentral.Tests.Extensions;

[Collection("Sequential")]
public class RateLimitTest
{
    [Fact]
    public async void EnableRateLimit()
    {
        var rc = await ReusableRestClient.GetInstance();
        var rateLimitExtension = new RateLimitExtension();
        await rc.InstallExtension(rateLimitExtension);
        rateLimitExtension.enabled = false; // remove this line to enable rate limit
        var extInfo = await rc.Restapi().Account().Extension().Get();
        Assert.NotNull(extInfo);
        Assert.NotNull(extInfo.id);
    }
}