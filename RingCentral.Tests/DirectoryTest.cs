using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class DirectoryTest
    {
        [Fact]
        public async void FetchDirectory()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                var directoryResource = await rc.Restapi().Account().Directory().Entries().List();
                var sites = directoryResource.records.Select(r => r.site).ToArray();
            }
        }
    }
}