using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.Account.Recordings
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.Account.Index parent;
public Index(Rcvideo.V1.Account.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/recordings";
        }
        /// <summary>
        /// Returns the list of meeting recordings owned by all users of the account.
/// 
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/account/{accountId}/recordings
        /// Rate Limit Group: Light
        /// App Permission: Video
        /// </summary>
  public async Task<RingCentral.CloudRecordings> Get(RingCentral.GetAccountRecordingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CloudRecordings>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account
{
    public partial class Index
    {
        public Rcvideo.V1.Account.Recordings.Index Recordings()
        {
            return new Rcvideo.V1.Account.Recordings.Index(this);
        }
    }
}