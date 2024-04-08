using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class AnsweringRuleTest
    {
        [Fact]
        public async void UpdateAnsweringRule()
        {
            var rc = await SharedRestClient.GetInstance();

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