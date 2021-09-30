using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MeetingRecordings
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
        }

        /// <summary>
        ///     Returns the list of meeting recordings for the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/meeting-recordings
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: MeetingsRecordings
        /// </summary>
        public async Task<ListMeetingRecordingsResponse> Get(ListAccountMeetingRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ListMeetingRecordingsResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public MeetingRecordings.Index MeetingRecordings()
        {
            return new MeetingRecordings.Index(this);
        }
    }
}