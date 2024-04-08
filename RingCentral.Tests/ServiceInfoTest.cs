using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class ServiceInfoTest
    {
        [Fact]
        public async void ServiceInfo()
        {
            var rc = await SharedRestClient.GetInstance();

            // account service-info
            var account = rc.Restapi().Account();
            var accountServiceInfo = await account.ServiceInfo().Get();
            var faxReceiving = accountServiceInfo.serviceFeatures.First(item => item.featureName == "FaxReceiving")
                .enabled;
            Assert.True(faxReceiving);

            // meetings api is being deprecated

            // // meeting service-info
            // var meetingServiceInfo = await account.Extension().Meeting().ServiceInfo().Get();
            // Assert.NotNull(meetingServiceInfo);
            // Assert.StartsWith("http", meetingServiceInfo.uri);
        }
    }
}