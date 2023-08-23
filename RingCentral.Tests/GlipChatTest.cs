using System;
using Xunit;

namespace RingCentral.Tests
{
    public class GlipChatTest
    {
        [Fact]
        public async void GetEveryOneTeam()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                var result = await rc.TeamMessaging().V1().Chats()
                    .List(new ListGlipChatsNewParameters {type = new[] {"Everyone"}});
                Assert.Single(result.records);
            }
        }
    }
}