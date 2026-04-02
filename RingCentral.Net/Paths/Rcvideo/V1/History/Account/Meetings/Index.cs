using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.History.Account.Meetings
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.History.Account.Index parent;
public Index(Rcvideo.V1.History.Account.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/meetings";
        }
        /// <summary>
        /// Returns the list of completed meetings owned by all users of the account.
/// 
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/history/account/{accountId}/meetings
        /// Rate Limit Group: Light
        /// App Permission: Video
        /// </summary>
  public async Task<RingCentral.AdminAccessMeetings> Get(RingCentral.ListAccountMeetingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.AdminAccessMeetings>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.History.Account
{
    public partial class Index
    {
        public Rcvideo.V1.History.Account.Meetings.Index Meetings()
        {
            return new Rcvideo.V1.History.Account.Meetings.Index(this);
        }
    }
}