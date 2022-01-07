using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PhoneNumber
{
    public class Index
    {
        public Account.Index parent;
        public string phoneNumberId;
        public RestClient rc;

        public Index(Account.Index parent, string phoneNumberId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.phoneNumberId = phoneNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && phoneNumberId != null) return $"{parent.Path()}/phone-number/{phoneNumberId}";
            return $"{parent.Path()}/phone-number";
        }

        /// <summary>
        ///     Returns the list of phone numbers assigned to RingCentral customer account. Both company-level and extension-level
        ///     numbers are returned.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/phone-number
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<AccountPhoneNumbers> List(ListAccountPhoneNumbersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountPhoneNumbers>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the phone number(s) belonging to a certain account or extension by phoneNumberId(s). Batch request is
        ///     supported.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/phone-number/{phoneNumberId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<CompanyPhoneNumberInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (phoneNumberId == null) throw new ArgumentException("Parameter cannot be null", nameof(phoneNumberId));
            return await rc.Get<CompanyPhoneNumberInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public PhoneNumber.Index PhoneNumber(string phoneNumberId = null)
        {
            return new PhoneNumber.Index(this, phoneNumberId);
        }
    }
}