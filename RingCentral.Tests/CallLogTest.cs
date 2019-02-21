using System;
using Xunit;

namespace RingCentral.Tests
{
    public class CallLogTest
    {
        [Fact]
        public async void GetCallLogs()
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

                var callLogResponse = await rc.Restapi().Account().CallLog().List(new LoadCompanyCallLogParameters
                {
                    perPage = 3,
                    dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o")
                });
                Assert.Equal(3, callLogResponse.records.Length);
            }
        }
    }
}