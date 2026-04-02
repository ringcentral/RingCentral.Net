using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions.Delegators
{
    public partial class Index
    {
        public RestClient rc;
public Rcvideo.V1.Accounts.Extensions.Index parent;
public Index(Rcvideo.V1.Accounts.Extensions.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/delegators";
        }
        /// <summary>
        /// Returns the list of users who can delegate bridge/meeting creation to the given user.
        /// HTTP Method: get
        /// Endpoint: /rcvideo/v1/accounts/{accountId}/extensions/{extensionId}/delegators
        /// Rate Limit Group: Medium
        /// App Permission: Video
        /// </summary>
  public async Task<RingCentral.DelegatorsListResult> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.DelegatorsListResult>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Accounts.Extensions
{
    public partial class Index
    {
        public Rcvideo.V1.Accounts.Extensions.Delegators.Index Delegators()
        {
            return new Rcvideo.V1.Accounts.Extensions.Delegators.Index(this);
        }
    }
}