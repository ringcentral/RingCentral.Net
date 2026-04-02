using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Index parent;
public string accountId;
public Index(Restapi.V2.Index parent, string accountId = "~")
      {
this.parent = parent;
this.rc = parent.rc;
this.accountId = accountId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && accountId != null)
            {
                return $"{parent.Path()}/accounts/{accountId}";
            }
            return $"{parent.Path()}/accounts";
        }
        /// <summary>
        /// Returns basic information about particular RingCentral account
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
  public async Task<RingCentral.AccountInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (accountId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(accountId));
    }return await rc.Get<RingCentral.AccountInfo>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Index Accounts(string accountId = "~")
        {
            return new Restapi.V2.Accounts.Index(this, accountId);
        }
    }
}