using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AdministeredSites
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

        public string Path()
        {
            return $"{parent.Path()}/administered-sites";
        }

        /// <summary>
        /// Returns the list of sites administered by the current user.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates user administered sites. Note: only IDs of records are used for update.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/administered-sites
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditAssignedRoles
        /// </summary>
        public async Task<RingCentral.BusinessSiteCollectionResource> Put(
            RingCentral.BusinessSiteCollectionRequest businessSiteCollectionRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.BusinessSiteCollectionResource>(this.Path(), businessSiteCollectionRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AdministeredSites.Index AdministeredSites()
        {
            return new Restapi.Account.Extension.AdministeredSites.Index(this);
        }
    }
}