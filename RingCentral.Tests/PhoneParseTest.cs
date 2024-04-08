using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class PhoneParseTest
    {
        [Fact]
        public async void ParseNumber()
        {
            var rc = await SharedRestClient.GetInstance();

            var r = await rc.Restapi().NumberParser().Parse().Post(new ParsePhoneNumberRequest
            {
                originalStrings = new[] {"+1650-666-8888", "+1650-666-9999"}
            });
            Assert.NotNull(r);
        }
    }
}