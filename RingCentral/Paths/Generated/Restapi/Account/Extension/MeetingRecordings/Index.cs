using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingRecordings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
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
            public string page;

            // Number of items per page. The `max` value is supported to indicate the maximum size - 300
            public string perPage;
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MeetingRecordings.Index MeetingRecordings()
        {
            return new Restapi.Account.Extension.MeetingRecordings.Index(this);
        }
    }
}