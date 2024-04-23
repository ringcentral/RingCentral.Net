using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class RestapiTest
    {
        [Fact]
        public async void Get()
        {
            var rc = await ReusableRestClient.GetInstance();

            var restApi = await rc.Restapi().Get();
            Assert.Equal("v1.0", restApi.uriString);
        }

        [Fact]
        public async void List()
        {
            var rc = await ReusableRestClient.GetInstance();

            var restApis = await rc.Restapi().List();
            Assert.Equal("v1.0", restApis.apiVersions[0].uriString);
        }
    }
}