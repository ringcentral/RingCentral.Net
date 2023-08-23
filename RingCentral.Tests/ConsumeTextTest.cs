using System;
using Xunit;

namespace RingCentral.Tests
{
    public class ConsumeTextTest
    {
        [Fact]
        public async void UpdateGlipPostText()
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

                var currentExtension = await rc.Restapi().Account().Extension().Get();

                var foundIt = false;
                foreach (var group in (await rc.TeamMessaging().V1().Chats().List()).records)
                {
                    foreach (var post in (await rc.TeamMessaging().V1().Chats(group.id).Posts().List()).records)
                        if (post.creatorId == currentExtension.id.ToString() && post.text != null)
                        {
                            foundIt = true;

                            var newText = Guid.NewGuid().ToString();
                            var r = await rc.TeamMessaging().V1().Chats(group.id).Posts(post.id)
                                .Patch(new TMUpdatePostRequest {text = newText});
                            Assert.Equal(r.text, newText);

                            break;
                        }

                    if (foundIt) break;
                }

                Assert.True(foundIt);
            }
        }
    }
}