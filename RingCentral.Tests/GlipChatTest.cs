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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                var result = await rc.TeamMessaging().Chats()
                    .List(new ListGlipChatsNewParameters {type = new[] {"Everyone"}});
                Assert.Single(result.records);
            }
        }
    }
}