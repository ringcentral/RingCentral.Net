using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.SmsRegistrationBrands
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string tcrBrandId;
        public Index(Restapi.Account.Index parent, string tcrBrandId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.tcrBrandId = tcrBrandId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && tcrBrandId != null)
            {
                return $"{parent.Path()}/sms-registration-brands/{tcrBrandId}";
            }
            return $"{parent.Path()}/sms-registration-brands";
        }
        /// <summary>
        /// Returns a list of all TCR brands.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sms-registration-brands
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.BrandListResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.BrandListResponse>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns the TCR brand by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/sms-registration-brands/{tcrBrandId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadSMSRegistration
        /// </summary>
        public async Task<RingCentral.TcrBrandRecord> Get(RestRequestConfig restRequestConfig = null)
        {
            if (tcrBrandId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(tcrBrandId));
            }
            return await rc.Get<RingCentral.TcrBrandRecord>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.SmsRegistrationBrands.Index SmsRegistrationBrands(string tcrBrandId = null)
        {
            return new Restapi.Account.SmsRegistrationBrands.Index(this, tcrBrandId);
        }
    }
}