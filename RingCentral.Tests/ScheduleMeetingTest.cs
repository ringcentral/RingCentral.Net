using System;
using Xunit;

namespace RingCentral.Tests
{
    public class ScheduleMeetingTest
    {
        [Fact]
        public async void ScheduleMeeting()
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

                // meetings api is being deprecated

                // var meetingRequestResource = new MeetingRequestResource
                // {
                //     topic = "Test meeting created by C# SDK",
                //     meetingType = "Scheduled",
                //     schedule = new MeetingScheduleResource
                //     {
                //         durationInMinutes = 30,
                //         timeZone = new MeetingsTimezoneResource {id = "58"},
                //         // startTime = DateTime.UtcNow.AddDays(10).ToString("o") // does not work, because of datetime format
                //         startTime = "2030-05-20T22:21:25Z"
                //     }
                // };
                // var meetingInfo = await rc.Restapi().Account().Extension().Meeting().Post(meetingRequestResource);
                // Assert.NotNull(meetingInfo);

                // await rc.Restapi().Account().Extension().Meeting(meetingInfo.id).Delete();
            }
        }
    }
}