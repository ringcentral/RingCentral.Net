using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Sites.Ivr
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Sites.Index parent;
public Index(Restapi.Account.Sites.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/ivr";
        }
        /// <summary>
        /// Returns IVR settings for a site specified in path.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
  public async Task<RingCentral.SiteIVRSettings> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.SiteIVRSettings>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates IVR settings for a site specified in path.
/// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: Sites
        /// </summary>
  public async Task<RingCentral.SiteIVRSettings> Put(RingCentral.SiteIVRSettingsUpdate siteIVRSettingsUpdate, RestRequestConfig restRequestConfig = null)
  {
return await rc.Put<RingCentral.SiteIVRSettings>(this.Path(), siteIVRSettingsUpdate, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Restapi.Account.Sites.Ivr.Index Ivr()
        {
            return new Restapi.Account.Sites.Ivr.Index(this);
        }
    }
}