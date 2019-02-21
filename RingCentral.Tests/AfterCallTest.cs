using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class AfterCallTest
    {
        [Fact]
        public async void AfterCall()
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

                var count = 0;

                void EventHandler(object sender, HttpCallEventArgs eventArgs)
                {
                    var rateLimitRemaining = eventArgs.httpResponseMessage.Headers.First(i => i.Key == "X-Rate-Limit-Remaining").Value.First();
                    Assert.True(int.Parse(rateLimitRemaining) > 0);
                    count += 1;
                }

                rc.AfterHttpCall += EventHandler;

                const string phoneNumber = "+15889546648";
                var addressBook = rc.Restapi().Account().Extension().AddressBook();

                await addressBook.Contact().List(new ListContactsParameters {phoneNumber = new[] {phoneNumber}});

                var china = await rc.Restapi().Dictionary().Country("46").Get();
                Assert.Equal("China", china.name);

                rc.AfterHttpCall -= EventHandler;
                Assert.Equal(2, count);
            }
        }
    }
}