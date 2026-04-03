using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class AnsweringRuleTest
{
    [Fact]
    public async void UpdateAnsweringRule()
    {
        var rc = await ReusableRestClient.GetInstance();

        var states = await rc.Restapi().V2().Accounts().Extensions().CommHandling().States().List();
        var stateRule = states.records[0];
        Assert.NotNull(stateRule);

        await rc.Restapi().V2().Accounts().Extensions().CommHandling().States(stateRule.id).Patch(
            new CommStateUpdateRequest
            {
                enabled = stateRule.enabled
            });
    }
}