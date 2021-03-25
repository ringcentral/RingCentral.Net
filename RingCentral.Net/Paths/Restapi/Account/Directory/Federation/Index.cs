using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Federation
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Directory.Index parent;

        public Index(Restapi.Account.Directory.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/federation";
        }

        /// <summary>
        /// Returns information on a federation and associated accounts.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/directory/federation
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.FederationResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.FederationResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Federation.Index Federation()
        {
            return new Restapi.Account.Directory.Federation.Index(this);
        }
    }
}