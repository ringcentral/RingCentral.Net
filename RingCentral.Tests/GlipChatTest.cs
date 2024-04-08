using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class GlipChatTest
    {
        [Fact]
        public async void GetEveryOneTeam()
        {
            var rc = await SharedRestClient.GetInstance();
            var result = await rc.TeamMessaging().V1().Chats()
                .List(new ListGlipChatsNewParameters {type = new[] {"Everyone"}});
            Assert.Single(result.records);
        }
    }
}