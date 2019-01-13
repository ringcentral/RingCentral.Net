using System;
using Xunit;

namespace RingCentral.Tests
{
    public class SmsTest : BaseTest
    {
        [Fact]
        public void TestSendSms()
        {
            AutoAuth(rc =>
            {
                // code for test sms
            });
        }
    }
}
