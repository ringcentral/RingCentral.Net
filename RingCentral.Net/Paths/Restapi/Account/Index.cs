using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public RestClient rc;
        public string accountId;
        public Restapi.Index parent;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.GetAccountInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.accountId == null)
            {
                throw new System.ArgumentNullException("accountId");
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