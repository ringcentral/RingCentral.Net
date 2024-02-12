using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.BusinessAddress
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/business-address";
        }

        /// <summary>
        ///     Returns business address of a company.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/business-address
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<AccountBusinessAddressResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountBusinessAddressResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the business address of a company that account is linked
        ///     to.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/business-address
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyInfo
        /// </summary>
        public async Task<AccountBusinessAddressResource> Put(
            ModifyAccountBusinessAddressRequest modifyAccountBusinessAddressRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<AccountBusinessAddressResource>(Path(), modifyAccountBusinessAddressRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public BusinessAddress.Index BusinessAddress()
        {
            return new BusinessAddress.Index(this);
        }
    }
}