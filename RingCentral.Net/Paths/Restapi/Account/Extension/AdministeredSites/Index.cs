using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AdministeredSites
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
            return $"{parent.Path()}/administered-sites";
        }

        /// <summary>
        ///     Returns a list of sites administered by the current user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<BusinessSiteCollectionResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<BusinessSiteCollectionResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the sites administered by the current user.
        ///     Please note: Only IDs of records are used for update.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditAssignedRoles
        /// </summary>
        public async Task<BusinessSiteCollectionResource> Put(
            BusinessSiteCollectionRequest businessSiteCollectionRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<BusinessSiteCollectionResource>(Path(), businessSiteCollectionRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AdministeredSites.Index AdministeredSites()
        {
            return new AdministeredSites.Index(this);
        }
    }
}