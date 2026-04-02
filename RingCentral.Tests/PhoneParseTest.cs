using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class PhoneParseTest
{
    [Fact]
    public async void ParseNumber()
    {
        var rc = await ReusableRestClient.GetInstance();

        var r = await rc.Restapi().V2().NumberParser().Parse().Post(new ParsePhoneNumbersRequest
        {
            originalStrings = new[] { "+1650-666-8888", "+1650-666-9999" }
        });
        Assert.NotNull(r);
    }
}