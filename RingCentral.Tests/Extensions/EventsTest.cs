using System;
using System.Linq;
using RingCentral.Net.Events;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    public class EventsTest
    {
        [Fact]
        public async void RequestSuccess()
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

                var eventsExtension = new EventsExtension();
                rc.InstallExtension(eventsExtension);

                var count = 0;

                void EventHandler(object sender, HttpMessages httpMessages)
                {
                    var rateLimitRemaining = httpMessages.httpResponseMessage.Headers
                        .First(i => i.Key == "X-Rate-Limit-Remaining").Value.First();
                    Assert.True(int.Parse(rateLimitRemaining) > 0);
                    count += 1;
                }

                eventsExtension.RequestSuccess += EventHandler;

                const string phoneNumber = "+15889546648";
                var addressBook = rc.Restapi().Account().Extension().AddressBook();

                await addressBook.Contact().List(new ListContactsParameters {phoneNumber = new[] {phoneNumber}});

                var china = await rc.Restapi().Dictionary().Country("46").Get();
                Assert.Equal("China", china.name);

                eventsExtension.RequestSuccess -= EventHandler;
                Assert.Equal(2, count);
            }
        }
    }
}