using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public string accountId;
        public Restapi.Index parent;
        public RestClient rc;

        public Index(Restapi.Index parent, string accountId = "~")
        {
            this.parent = parent;
            rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null) return $"{parent.Path()}/account/{accountId}";

            return $"{parent.Path()}/account";
        }

        /// <summary>
        ///     Returns basic information about a particular RingCentral customer account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<GetAccountInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (accountId == null) throw new ArgumentException("Parameter cannot be null", nameof(accountId));

            return await rc.Get<GetAccountInfoResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Account.Index Account(string accountId = "~")
        {
            return new Account.Index(this, accountId);
        }
    }
}