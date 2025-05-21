using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.RegionalSettings
{
    public class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/regional-settings";
        }

        /// <summary>
        ///     Returns information about particular account regional settings
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/regional-settings
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.RegionalSettings> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RegionalSettings>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Change information about particular account regional settings
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/regional-settings
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.RegionalSettings> Patch(
            AccountRegionalSettingRequest accountRegionalSettingRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.RegionalSettings>(Path(), accountRegionalSettingRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public RegionalSettings.Index RegionalSettings()
        {
            return new RegionalSettings.Index(this);
        }
    }
}