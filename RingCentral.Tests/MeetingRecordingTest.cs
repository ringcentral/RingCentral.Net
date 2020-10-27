using System;
using System.Net;
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
                try
                {
                    var r = await rc.Restapi().Account().MeetingRecordings().Get();
                    Assert.NotNull(r);

                    var str = await rc.Get<string>(rc.Restapi().Account().MeetingRecordings().Path());
                    Assert.NotNull(str);
                }
                catch (RestException re)
                {
                    // todo: https://jira.ringcentral.com/browse/PLA-49859
                    Assert.Equal(HttpStatusCode.Forbidden, re.httpResponseMessage.StatusCode);
                }
            }
        }
    }
}