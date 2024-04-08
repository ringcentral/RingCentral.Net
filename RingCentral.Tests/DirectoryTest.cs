using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class DirectoryTest
    {
        [Fact]
        public async void FetchDirectory()
        {
            var rc = await SharedRestClient.GetInstance();
            var directoryResource = await rc.Restapi().Account().Directory().Entries().List();
            var sites = directoryResource.records.Select(r => r.site).ToArray();
        }
    }
}