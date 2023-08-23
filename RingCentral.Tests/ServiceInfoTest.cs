using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class ServiceInfoTest
    {
        [Fact]
        public async void ServiceInfo()
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
}