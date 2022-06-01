using System;
using Xunit;

namespace RingCentral.Tests
{
    public class AnsweringRuleTest
    {
        [Fact]
        public async void UpdateAnsweringRule()
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

                var answeringRules = await rc.Restapi().Account().AnsweringRule().List();
                var answeringRule = answeringRules.records[0];
                Assert.NotNull(answeringRule);
                Assert.True(answeringRules.records.Length > 1);

                var answeringRules2 = await rc.Get<CompanyAnsweringRuleList>("/restapi/v1.0/account/~/answering-rule",
                    new {perPage = 1});
                Assert.NotNull(answeringRules2);
                Assert.True(answeringRules2.records.Length == 1);
//                await rc.Patch(rc.Restapi().Account().AnsweringRule(answeringRule.id).Path(), new
//                {
//                    enabled = true
//                });
            }
        }
    }
}