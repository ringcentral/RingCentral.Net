using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class MultipartMixed
    {
        [Fact]
        public async Task UpdateCompanyGreeting()
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
                var account = rc.Restapi().Account();
                var companyAnsweringRuleList = await account.AnsweringRule().List();
                var answeringRule = companyAnsweringRuleList.records.Last();
                var customCompanyGreetingInfo = await account.Greeting().Post(new CustomCompanyGreetingRequest
                {
                    type = "Company",
                    answeringRule = new CustomCompanyGreetingAnsweringRuleInfo
                    {
                        id = answeringRule.id
                    },
                    audio = new Attachment
                    {
                        fileName = "test.mp3",
                        bytes = File.ReadAllBytes("./test.mp3"),
                        contentType = "audio/mpeg"
                    },
                });
                Assert.Equal("Company", customCompanyGreetingInfo.type);
            }
        }

        [Fact]
        public async Task UpdateUserGreeting()
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
                var extension = rc.Restapi().Account().Extension();
                var userAnsweringRuleList = await extension.AnsweringRule().List();
                var answeringRule = userAnsweringRuleList.records.Last();
                var customGreetingInfo = await extension.Greeting().Post(new CustomGreetingRequest
                {
                    type = "Voicemail",
                    answeringRule = new CustomGreetingAnsweringRuleInfoRequest
                    {
                        id = answeringRule.id
                    },
                    audio = new Attachment
                    {
                        fileName = "test.mp3",
                        bytes = File.ReadAllBytes("./test.mp3"),
                        contentType = "audio/mpeg"
                    },
                });
                Assert.Equal("Voicemail", customGreetingInfo.type);
            }
        }
    }
}