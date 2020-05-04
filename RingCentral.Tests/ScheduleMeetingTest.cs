using System;
using System.IO;
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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                var meetingRequestResource = new MeetingRequestResource
                {
                    topic = "Test meeting created by C# SDK",
                    meetingType = "Scheduled",
                    schedule = new MeetingScheduleResource
                    {
                        durationInMinutes = 30,
                        timeZone =  new TimezoneResource{ id = "58" },
                        // startTime = DateTime.UtcNow.AddDays(10).ToString("o") // does not work, because of datetime format
                        startTime = "2030-05-20T22:21:25Z"
                    }
                };
                var meetingInfo = await rc.Restapi().Account().Extension().Meeting().Post(meetingRequestResource);
                Assert.NotNull(meetingInfo);
                
                await rc.Restapi().Account().Extension().Meeting(meetingInfo.id).Delete();
            }
        }
    }
}