using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get User Meeting Recordings List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting-recordings
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: MeetingsRecordings
        /// </summary>
        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(
            ListUserMeetingRecordingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams, restRequestConfig);
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