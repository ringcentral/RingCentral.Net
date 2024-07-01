using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class GlipAttachmentTest
{
    [Fact]
    public async void PostAttachment()
    {
        var rc = await ReusableRestClient.GetInstance();
        var groupId = (await rc.TeamMessaging().V1().Chats().List()).records[0].id;
        // https://jira.ringcentral.com/browse/PLD-803
        // var postInfo = await rc.Restapi().Glip().Groups(groupId).Posts().Post(new GlipCreatePost
        // {
        //     attachments = new[]
        //     {
        //         new GlipMessageAttachmentInfoRequest
        //         {
        //             type = "Card",
        //             fallback = "fallback",
        //             color = "#000000",
        //             intro = "intro",
        //             text = "text",
        //             title = "title",
        //             imageUri = "https://www.baidu.com/img/bd_logo1.png"
        //         }
        //     }
        // });
        // Assert.Equal("https://www.baidu.com/img/bd_logo1.png", postInfo.attachments[0].imageUri);
    }
}