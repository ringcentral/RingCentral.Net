using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.PhoneNumber
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string phoneNumberId;

        public Index(Restapi.Account.Index parent, string phoneNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.phoneNumberId = phoneNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && phoneNumberId != null)
            {
                return $"{parent.Path()}/phone-number/{phoneNumberId}";
            }

            return $"{parent.Path()}/phone-number";
        }

        /// <summary>
        /// Returns the list of phone numbers assigned to RingCentral customer account. Both company-level and extension-level numbers are returned.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/phone-number
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.AccountPhoneNumbers> List(
            RingCentral.ListAccountPhoneNumbersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountPhoneNumbers>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the phone number(s) belonging to a certain account or extension by phoneNumberId(s). Batch request is supported.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/phone-number/{phoneNumberId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<RingCentral.CompanyPhoneNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyPhoneNumberInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.PhoneNumber.Index PhoneNumber(string phoneNumberId = null)
        {
            return new Restapi.Account.PhoneNumber.Index(this, phoneNumberId);
        }
    }
}