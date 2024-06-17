using System;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class CallLogTest
    {
        [Fact]
        public async void GetCallLogs()
        {
            var rc = await ReusableRestClient.GetInstance();

            var callLogResponse = await rc.Restapi().Account().CallLog().List(new ReadCompanyCallLogParameters
            {
                perPage = 3,
                dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o")
            });
            Assert.Equal(3, callLogResponse.records.Length);
        }

        [Fact]
        public async void FilterByPhoneNumber()
        {
            var rc = await ReusableRestClient.GetInstance();

            var callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(
                new ReadUserCallLogParameters
                {
                    perPage = 1,
                    dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o")
                });
            Assert.Single(callLogResponse.records);

            // it works with or without the prefixing "+" sign
            var fromNumber = callLogResponse.records[0].from.phoneNumber;
            callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
            {
                perPage = 1,
                dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
                phoneNumber = fromNumber // +123456789
            });
            Assert.Single(callLogResponse.records);
            callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
            {
                perPage = 1,
                dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
                phoneNumber = fromNumber.TrimStart('+') // 123456789
            });
            Assert.Single(callLogResponse.records);
        }
    }
}