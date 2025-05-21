using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.History.Account.Meetings
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/meetings";
        }

        /// <summary>
        ///     Returns the list of completed meetings owned by all users of the account.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/history/account/{accountId}/meetings
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<AdminAccessMeetings> Get(ListAccountMeetingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AdminAccessMeetings>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.History.Account
{
    public partial class Index
    {
        public Meetings.Index Meetings()
        {
            return new Meetings.Index(this);
        }
    }
}