using System;
using System.Threading;
using Xunit;

namespace RingCentral.Tests
{
    public class EventsTest
    {
        [Fact]
        public async void TokenEvent()
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
                var temp = 0;
                rc.TokenRefreshed += (sender, args) => { temp += 1; };
                await rc.Refresh();
                Thread.Sleep(3000);
                await rc.Refresh();
                Thread.Sleep(3000);
                await rc.Refresh();
                Assert.Equal(3, temp);
            }
        }
    }
}