using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Sites.Ivr
{
    public class Index
    {
        public Sites.Index parent;
        public RestClient rc;

        public Index(Sites.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/ivr";
        }

        /// <summary>
        ///     Returns IVR settings for a site specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<SiteIVRSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SiteIVRSettings>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates IVR settings for a site specified in path.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}/ivr
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: Sites
        /// </summary>
        public async Task<SiteIVRSettings> Put(SiteIVRSettingsUpdate siteIVRSettingsUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<SiteIVRSettings>(Path(), siteIVRSettingsUpdate, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Ivr.Index Ivr()
        {
            return new Ivr.Index(this);
        }
    }
}