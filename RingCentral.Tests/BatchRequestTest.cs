using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class BatchRequestTest
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
                var contactList = await rc.Restapi().Account().Extension().AddressBook().Contact().List();
                var ids = contactList.records.Select(c => c.id).Take(3);
                var str = await rc.Get<string>(rc.Restapi().Account().Extension().AddressBook()
                    .Contact(string.Join(",", ids)).Path());
            }
        }
    }
}