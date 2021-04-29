using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.BusinessAddress
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-address";
        }

        /// <summary>
        /// Returns business address of a company.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/business-address
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.AccountBusinessAddressResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountBusinessAddressResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the business address of a company that account is linked to. Batch request is supported.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/business-address
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<RingCentral.AccountBusinessAddressResource> Put(
            RingCentral.ModifyAccountBusinessAddressRequest modifyAccountBusinessAddressRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.AccountBusinessAddressResource>(this.Path(),
                modifyAccountBusinessAddressRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.BusinessAddress.Index BusinessAddress()
        {
            return new Restapi.Account.BusinessAddress.Index(this);
        }
    }
}