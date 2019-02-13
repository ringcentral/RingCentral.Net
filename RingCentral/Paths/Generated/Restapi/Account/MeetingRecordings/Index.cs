using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MeetingRecordings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingId;

        // Recordings of meetings started after the time specified will be returned. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingStartTimeFrom;

        // Recordings of meetings started before the time specified will be returned. The default value is current time. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingStartTimeTo;

        // Page number
        public long? page;

        // Number of items per page. The `max` value is supported to indicate the maximum size - 300
        public long? perPage;
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MeetingRecordings.Index MeetingRecordings()
        {
            return new Restapi.Account.MeetingRecordings.Index(this);
        }
    }
}