using System;
using System.Linq;
using System.Threading.Tasks;
using RingCentral.Paths.Restapi.Account.Extension.AddressBook.Contact;
using Xunit;

namespace RingCentral.Tests
{
    public class AfterCallTest
    {
        [Fact]
        public async Task AfterCall()
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
                EventHandler<HttpCallEventArgs> eventHandler = (object sender, HttpCallEventArgs eventArgs) =>
                {
                    var rateLimitRemaining = eventArgs.httpResponseMessage.Headers
                        .First(i => i.Key == "X-Rate-Limit-Remaining").Value.First();
                    count += 1;
                };
                rc.AfterHttpCall += eventHandler;

                const string phoneNumber = "+15889546648";
                var addressBook = rc.Restapi().Account().Extension().AddressBook();
                await addressBook.Contact().List(new ListQueryParams {phoneNumber = phoneNumber});

                // todo: make code below work
//                await addressBook.Contact().List(new { phoneNumber = phoneNumber });

                var china = await rc.Restapi().Dictionary().Country("46").Get();
                Assert.Equal("China", china.name);

                rc.AfterHttpCall -= eventHandler;
                Assert.Equal(2, count);
            }
        }
    }
}