using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;
        public string accountId;

        public Index(Restapi.Index parent, string accountId = "~")
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null)
            {
                return $"{parent.Path()}/account/{accountId}";
            }

            return $"{parent.Path()}/account";
        }

        /// <summary>
        /// Returns basic information about a particular RingCentral customer account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.GetAccountInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (accountId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(accountId));
            }

            return await rc.Get<RingCentral.GetAccountInfoResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.Account.Index Account(string accountId = "~")
        {
            return new Restapi.Account.Index(this, accountId);
        }
    }
}