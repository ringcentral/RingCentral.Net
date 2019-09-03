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
                var groupId = (await rc.Restapi().Glip().Groups().List()).records[0].id;

                // todo: test the following
//                var postId = (await rc.Restapi().Glip().Groups(groupId).Posts().Get()).records[0].id;
//                var newText = Guid.NewGuid().ToString();
//                var r = await rc.Restapi().Glip().Groups(groupId).Posts(postId).Text().Put(newText);
//                Assert.Equal(r, newText);
            }
        }
    }
}