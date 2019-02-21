using System;
using System.Threading.Tasks;
using RingCentral.Paths.Restapi.Account.Extension.AddressBook.Contact;
using Xunit;

namespace RingCentral.Tests
{
    public class QueryParamsTest
    {
        [Fact]
        public async Task ArrayParams()
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
                const string phoneNumber = "+15889546648";
                const string phoneNumber2 = "+17700083226";
                var addressBook = rc.Restapi().Account().Extension().AddressBook();

                void EventHandler1(object sender, HttpCallEventArgs eventArgs)
                {
                    Assert.Equal($"?phoneNumber={phoneNumber}", eventArgs.httpRequestMessage.RequestUri.Query);
                    count += 1;
                }

                rc.AfterHttpCall += EventHandler1;
                await addressBook.Contact().List(new ListContactsParameters {phoneNumber = new[] {phoneNumber}});
                rc.AfterHttpCall -= EventHandler1;
                Assert.Equal(1, count);

                void EventHandler2(object sender, HttpCallEventArgs eventArgs)
                {
                    Assert.Equal($"?phoneNumber={phoneNumber}&phoneNumber={phoneNumber2}",
                        eventArgs.httpRequestMessage.RequestUri.Query);
                    count += 1;
                }

                rc.AfterHttpCall += EventHandler2;
                await addressBook.Contact().List(new ListContactsParameters
                    {phoneNumber = new[] {phoneNumber, phoneNumber2}});
                rc.AfterHttpCall -= EventHandler2;
                Assert.Equal(2, count);
            }
        }
    }
}