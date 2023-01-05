using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingRecordings
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
        }

        /// <summary>
        ///     Returns the list of meetings recordings for the current user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting-recordings
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        /// </summary>
        public async Task<ListMeetingRecordingsResponse> Get(ListUserMeetingRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ListMeetingRecordingsResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public MeetingRecordings.Index MeetingRecordings()
        {
            return new MeetingRecordings.Index(this);
        }
    }
}