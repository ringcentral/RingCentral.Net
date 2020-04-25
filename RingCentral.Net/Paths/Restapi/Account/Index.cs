using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Account Info
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}
        /// Rate Limit Group: Light
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.GetAccountInfoResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.accountId == null)
            {
                throw new System.ArgumentNullException("accountId");
            }

            return await rc.Get<RingCentral.GetAccountInfoResponse>(this.Path(), null, cancellationToken);
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