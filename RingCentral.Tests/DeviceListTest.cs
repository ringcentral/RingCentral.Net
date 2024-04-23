using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class DeviceListTest
    {
        [Fact]
        public async void GetDeviceList()
        {
            var rc = await ReusableRestClient.GetInstance();
            var r = await rc.Get("/restapi/v1.0/account/~/device");
            var str = r.Content.ReadAsStringAsync();
            Assert.NotNull(str);
        }
    }
}