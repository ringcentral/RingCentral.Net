using System;
using Xunit;

namespace RingCentral.Tests;

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
                dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
                dateTo = DateTime.UtcNow.AddDays(-3)
                    .ToString("o") // don't want the very latest data because there might be sync issue
            });
        Assert.Single(callLogResponse.records);

        // sometimes it doesn't work with the prefixing "+"
        // sometimes it works, strange
        // callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
        // {
        //     perPage = 1,
        //     dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
        //     dateTo = DateTime.UtcNow.AddDays(-3).ToString("o"),
        //     phoneNumber = fromNumber // +123456789
        // });
        // Assert.Single(callLogResponse.records);

        var fromNumber = callLogResponse.records[0].from.phoneNumber;
        callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
        {
            perPage = 1,
            dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
            dateTo = DateTime.UtcNow.AddDays(-3).ToString("o"),
            phoneNumber = fromNumber.TrimStart('+') // 123456789
        });
        Assert.Single(callLogResponse.records);
    }
}