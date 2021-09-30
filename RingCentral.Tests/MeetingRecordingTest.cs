using System;
using Xunit;

namespace RingCentral.Tests
{
    public class MeetingRecordingTest
    {
        [Fact]
        public async void ListMeetingRecordings()
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

                // meetings API is being deprecated

                // var r = await rc.Restapi().Account().MeetingRecordings().Get(
                //     new ListAccountMeetingRecordingsParameters
                //     {
                //         meetingStartTimeFrom = "2030-05-20T22:21:25Z"
                //     });
                // Assert.NotNull(r);
            }
        }
    }
}