using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /// <summary>
        /// Returns the list of meeting recordings for the current account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/meeting-recordings
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: MeetingsRecordings
        /// </summary>
        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(
            RingCentral.ListAccountMeetingRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams, restRequestConfig);
        }
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