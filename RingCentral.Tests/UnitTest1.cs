using System;
using Xunit;

namespace RingCentral.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var rc = new RestClient("clientId", "clientSecret", "wss://ws-api.devtest.ringcentral.com/ws");
            rc.Authorize("username", "extension", "password");
        }
    }
}
