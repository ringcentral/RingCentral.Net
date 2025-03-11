using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public string accountId;
        public V2.Index parent;
        public RestClient rc;

        public Index(V2.Index parent, string accountId = "~")
        {
            this.parent = parent;
            rc = parent.rc;
            this.accountId = accountId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null) return $"{parent.Path()}/accounts/{accountId}";
            return $"{parent.Path()}/accounts";
        }

        /// <summary>
        ///     Returns basic information about particular RingCentral account
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<AccountInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (accountId == null) throw new ArgumentException("Parameter cannot be null", nameof(accountId));
            return await rc.Get<AccountInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2
{
    public partial class Index
    {
        public Accounts.Index Accounts(string accountId = "~")
        {
            return new Accounts.Index(this, accountId);
        }
    }
}