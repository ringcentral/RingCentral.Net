using System.Linq;
using RingCentral.Net.Events;
using Xunit;

namespace RingCentral.Tests.Extensions
{
    [Collection("Sequential")]
    public class EventsTest
    {
        [Fact]
        public async void RequestSuccess()
        {
            var rc = await SharedRestClient.GetInstance();

            var eventsExtension = new EventsExtension();
            await rc.InstallExtension(eventsExtension);

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

            eventsExtension.enabled = false;
        }
    }
}