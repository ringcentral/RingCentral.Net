using RingCentral.Net.Debug;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    [Collection("Sequential")]
    public class DebugTest
    {
        [Fact]
        public async void EnableDebugMode()
        {
            var rc = await SharedRestClient.GetInstance();
            var debugExtension = new DebugExtension();
            await rc.InstallExtension(debugExtension);
            debugExtension.enabled = false; // remove this line to enable debug mode
            var extInfo = await rc.Restapi().Account().Extension().Get();
            Assert.NotNull(extInfo);
            Assert.NotNull(extInfo.id);
        }
    }
}