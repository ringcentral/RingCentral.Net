using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.SmsRegistrationBrands.Campaigns
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.SmsRegistrationBrands.Index parent;
        public string tcrCampaignId;
        public Index(Restapi.Account.SmsRegistrationBrands.Index parent, string tcrCampaignId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.tcrCampaignId = tcrCampaignId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && tcrCampaignId != null)
            {
                return $"{parent.Path()}/campaigns/{tcrCampaignId}";
            }
            return $"{parent.Path()}/campaigns";
        }
        /// <summary>
        /// Returns a list of TCR campaigns by the TCR brand ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sms-registration-brands/{tcrBrandId}/campaigns
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadSMSRegistration
        /// </summary>
        public async Task<RingCentral.CampaignListResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CampaignListResponse>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns the TCR campaign by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sms-registration-brands/{tcrBrandId}/campaigns/{tcrCampaignId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadSMSRegistration
        /// </summary>
        public async Task<RingCentral.TcrCampaignRecord> Get(RestRequestConfig restRequestConfig = null)
        {
            if (tcrCampaignId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(tcrCampaignId));
            }
            return await rc.Get<RingCentral.TcrCampaignRecord>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.SmsRegistrationBrands
{
    public partial class Index
    {
        public Restapi.Account.SmsRegistrationBrands.Campaigns.Index Campaigns(string tcrCampaignId = null)
        {
            return new Restapi.Account.SmsRegistrationBrands.Campaigns.Index(this, tcrCampaignId);
        }
    }
}