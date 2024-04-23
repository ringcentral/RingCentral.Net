using RingCentral.Net.Retry;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    [Collection("Sequential")]
    public class RetryTest
    {
        [Fact]
        public async void EnableAutoRetry()
        {
            var rc = await ReusableRestClient.GetInstance();
            var retryExtension = new RetryExtension();
            await rc.InstallExtension(retryExtension);
            retryExtension.enabled = false; // remove this line to enable auto retry
            var extInfo = await rc.Restapi().Account().Extension().Get();
            Assert.NotNull(extInfo);
            Assert.NotNull(extInfo.id);
        }
    }
}