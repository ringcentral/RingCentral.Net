using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string siteId;
        public Index(Restapi.Account.Index parent, string siteId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.siteId = siteId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && siteId != null)
            {
                return $"{parent.Path()}/sites/{siteId}";
            }
            return $"{parent.Path()}/sites";
        }
        /// <summary>
        /// Returns a list of sites for the specified account.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.SitesList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SitesList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a site for the specified account.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.SiteInfo> Post(RingCentral.CreateSiteRequest createSiteRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SiteInfo>(this.Path(false), createSiteRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns a site by ID.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.SiteInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(siteId));
            }
            return await rc.Get<RingCentral.SiteInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a site specified in path.
        /// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: Sites
        /// </summary>
        public async Task<RingCentral.SiteInfo> Put(RingCentral.SiteUpdateRequest siteUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(siteId));
            }
            return await rc.Put<RingCentral.SiteInfo>(this.Path(), siteUpdateRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes a site specified in path.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: Sites
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(siteId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Sites.Index Sites(string siteId = null)
        {
            return new Restapi.Account.Sites.Index(this, siteId);
        }
    }
}