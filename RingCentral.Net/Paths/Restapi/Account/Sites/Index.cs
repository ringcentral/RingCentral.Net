using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Sites
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string siteId;

        public Index(Account.Index parent, string siteId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.siteId = siteId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && siteId != null) return $"{parent.Path()}/sites/{siteId}";
            return $"{parent.Path()}/sites";
        }

        /// <summary>
        ///     Returns a list of sites for the specified account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<SitesList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SitesList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a site for the specified account.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<SiteInfo> Post(CreateSiteRequest createSiteRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SiteInfo>(Path(false), createSiteRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a site by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<SiteInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null) throw new ArgumentException("Parameter cannot be null", nameof(siteId));
            return await rc.Get<SiteInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a site specified in path.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditExtensions
        ///     User Permission: Sites
        /// </summary>
        public async Task<SiteInfo> Put(SiteUpdateRequest siteUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null) throw new ArgumentException("Parameter cannot be null", nameof(siteId));
            return await rc.Put<SiteInfo>(Path(), siteUpdateRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a site specified in path.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/sites/{siteId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: Sites
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (siteId == null) throw new ArgumentException("Parameter cannot be null", nameof(siteId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Sites.Index Sites(string siteId = null)
        {
            return new Sites.Index(this, siteId);
        }
    }
}