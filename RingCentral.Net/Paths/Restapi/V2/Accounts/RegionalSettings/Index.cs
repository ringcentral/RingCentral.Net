using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.RegionalSettings
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Index parent;
public Index(Restapi.V2.Accounts.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/regional-settings";
        }
        /// <summary>
        /// Returns the account's regional settings.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/regional-settings
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.RegionalSettings> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.RegionalSettings>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates the account's regional settings.
        /// HTTP Method: patch
        /// Endpoint: /restapi/v2/accounts/{accountId}/regional-settings
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.RegionalSettings> Patch(RingCentral.AccountRegionalSettingRequest accountRegionalSettingRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Patch<RingCentral.RegionalSettings>(this.Path(), accountRegionalSettingRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.RegionalSettings.Index RegionalSettings()
        {
            return new Restapi.V2.Accounts.RegionalSettings.Index(this);
        }
    }
}