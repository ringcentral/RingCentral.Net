using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class ForwardingNumberTest
    {
        [Fact]
        public async void GetForwardingNumberList()
        {
            var rc = await ReusableRestClient.GetInstance();
            var extension = rc.Restapi().Account().Extension();

            var r = await extension.ForwardingNumber().List();
            Assert.NotNull(r.records);
//                Assert.NotEmpty(r.records);

            // a complicated way, not recommended
            var response = await rc.Get(extension.ForwardingNumber().Path(false));
            var body = await response.Content.ReadAsStringAsync();
            Assert.NotNull(response);
            Assert.NotEmpty(body);
        }
    }
}