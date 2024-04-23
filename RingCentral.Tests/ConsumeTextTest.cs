using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class ConsumeTextTest
    {
        [Fact]
        public async void UpdateGlipPostText()
        {
            var rc = await ReusableRestClient.GetInstance();

            var currentExtension = await rc.Restapi().Account().Extension().Get();

            // todo: https://jira.ringcentral.com/browse/PLD-1880
            // var foundIt = false;
            // foreach (var group in (await rc.TeamMessaging().V1().Chats().List()).records)
            // {
            //     foreach (var post in (await rc.TeamMessaging().V1().Chats(group.id).Posts().List()).records)
            //         if (post.creatorId == currentExtension.id.ToString() && !string.IsNullOrEmpty(post.text))
            //         {
            //             foundIt = true;
            //
            //             var newText = Guid.NewGuid().ToString();
            //             var r = await rc.TeamMessaging().V1().Chats(group.id).Posts(post.id)
            //                 .Patch(new TMUpdatePostRequest {text = newText});
            //             Assert.Equal(r.text, newText);
            //
            //             break;
            //         }
            //
            //     if (foundIt) break;
            // }
            //
            // Assert.True(foundIt);
        }
    }
}