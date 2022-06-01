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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

                var currentExtension = await rc.Restapi().Account().Extension().Get();

                var foundIt = false;
                foreach (var group in (await rc.Restapi().Glip().Chats().List()).records)
                {
                    foreach (var post in (await rc.Restapi().Glip().Chats(group.id).Posts().List()).records)
                        if (post.creatorId == currentExtension.id.ToString() && post.text != null)
                        {
                            foundIt = true;

                            var newText = Guid.NewGuid().ToString();
                            var r = await rc.Restapi().Glip().Chats(group.id).Posts(post.id)
                                .Patch(new GlipPatchPostBody {text = newText});
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