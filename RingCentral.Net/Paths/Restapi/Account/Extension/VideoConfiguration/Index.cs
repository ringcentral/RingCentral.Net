using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.VideoConfiguration
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/video-configuration";
        }
        /// <summary>
        /// Returns information about video configuration settings of the current user.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: Meetings
        /// </summary>
  public async Task<RingCentral.UserVideoConfiguration> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.UserVideoConfiguration>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.VideoConfiguration.Index VideoConfiguration()
        {
            return new Restapi.Account.Extension.VideoConfiguration.Index(this);
        }
    }
}