using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class AccountTest
    {
        [Fact]
        public async void GetAccount()
        {
            var rc = await ReusableRestClient.GetInstance();
            var account = await rc.Restapi().Account().Get();
            Assert.NotNull(account);
            Assert.NotNull(account.serviceInfo);
        }
    }
}