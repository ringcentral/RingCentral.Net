using Xunit;

namespace RingCentral.Tests
{
    /// <summary>
    ///     Test v2 of APIs, such as /restapi/v2/account/~
    /// </summary>
    [Collection("Sequential")]
    public class V2Test
    {
        [Fact]
        public async void GetAccountInfo()
        {
            var rc = await ReusableRestClient.GetInstance();

            var path = rc.Restapi().V2().Accounts().Path();
            Assert.Equal("/restapi/v2/accounts/~", path);

            // var accountInfo2 = await rc.Restapi().Account().Get();
            // Assert.NotNull(accountInfo2);

            // todo: I believe it is a server side issue, sandbox only, prod cannot reproduce
            // ref: https://jira.ringcentral.com/browse/PLA-76290
            // var accountInfo = await rc.Restapi().V2().Accounts().Get();
            // Assert.NotNull(accountInfo);
        }
    }
}