using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class MeetingRecordingTest
{
    [Fact]
    public async void ListMeetingRecordings()
    {
        var rc = await ReusableRestClient.GetInstance();

        // meetings API is being deprecated

        // var r = await rc.Restapi().Account().MeetingRecordings().Get(
        //     new ListAccountMeetingRecordingsParameters
        //     {
        //         meetingStartTimeFrom = "2030-05-20T22:21:25Z"
        //     });
        // Assert.NotNull(r);
    }
}