using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Federation
{
    public class Index
    {
        public Directory.Index parent;
        public RestClient rc;

        public Index(Directory.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/federation";
        }

        /// <summary>
        ///     Returns information on a federation and associated accounts.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/federation
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<FederationResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<FederationResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Federation.Index Federation()
        {
            return new Federation.Index(this);
        }
    }
}