using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.SmsRegistrationBrands.Campaigns.SubmitPhoneNumbers
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.SmsRegistrationBrands.Campaigns.Index parent;
public Index(Restapi.Account.SmsRegistrationBrands.Campaigns.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/submit-phone-numbers";
        }
        /// <summary>
        /// Links phone number(s) to a TCR campaign.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sms-registration-brands/{tcrBrandId}/campaigns/{tcrCampaignId}/submit-phone-numbers
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyPhoneNumbers
        /// </summary>
  public async Task<string> Post(RingCentral.AssignNumbersRequest assignNumbersRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), assignNumbersRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.SmsRegistrationBrands.Campaigns
{
    public partial class Index
    {
        public Restapi.Account.SmsRegistrationBrands.Campaigns.SubmitPhoneNumbers.Index SubmitPhoneNumbers()
        {
            return new Restapi.Account.SmsRegistrationBrands.Campaigns.SubmitPhoneNumbers.Index(this);
        }
    }
}