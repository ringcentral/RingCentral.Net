using System;
using Xunit;

namespace RingCentral.Tests
{
    /// <summary>
    ///     Test v2 of APIs, such as /restapi/v2/account/~
    /// </summary>
    public class V2Test
    {
        [Fact]
        public async void GetAccountInfo()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

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
}