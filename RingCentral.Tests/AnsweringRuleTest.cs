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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                var answeringRules = await rc.Restapi().Account().Extension().AnsweringRule().List();
                var answeringRule = answeringRules.records[0];
                Assert.NotNull(answeringRule);

                await rc.Restapi().Account().Extension().AnsweringRule(answeringRule.id).Put(
                    new UpdateAnsweringRuleRequest
                    {
                        enabled = answeringRule.enabled
                    });
            }
        }
    }
}