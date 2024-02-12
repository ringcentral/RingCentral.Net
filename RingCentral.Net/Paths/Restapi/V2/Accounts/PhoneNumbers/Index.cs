using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers
{
    public partial class Index
    {
        public Accounts.Index parent;
        public string phoneNumberId;
        public RestClient rc;

        public Index(Accounts.Index parent, string phoneNumberId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.phoneNumberId = phoneNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && phoneNumberId != null) return $"{parent.Path()}/phone-numbers/{phoneNumberId}";
            return $"{parent.Path()}/phone-numbers";
        }

        /// <summary>
        ///     Returns the list of phone numbers assigned to RingCentral customer
        ///     account. Both company-level and extension-level numbers are returned.
        ///     Conferencing numbers, hot desk and ELIN numbers are not returned.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyPhoneNumbers
        /// </summary>
        public async Task<AccountPhoneNumberList> Get(ListAccountPhoneNumbersV2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountPhoneNumberList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     This method can only delete numbers that meet one of the following requirements:
        ///     - numbers that have `"usageType": "Inventory"`
        ///     - `"Forwarded"` numbers
        ///     - `"Forwarded Company"` numbers
        ///     In other words, this method will not delete numbers which are in use on the account - extension direct numbers,
        ///     main number, etc. It is possible to indicate phone numbers to be deleted using their IDs or exact string values
        ///     in e.164 format. However, the same lookup method (by ID or by value) must be used for all numbers within the same
        ///     API call.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<DeletePhoneNumbersResponse> Delete(DeletePhoneNumbersRequest deletePhoneNumbersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<DeletePhoneNumbersResponse>(Path(false), deletePhoneNumbersRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Assigns or reassigns a phone number as a company or extension number.
        ///     Assign scenarios supported:
        ///     - from Inventory to a company number;
        ///     - from Inventory to an extension number.
        ///     Reassign scenarios supported:
        ///     - from an extension to another extension;
        ///     - from an extension to a company number;
        ///     - from a company number to an extension.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/{phoneNumberId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<AccountPhoneNumberInfo> Patch(AssignPhoneNumberRequest assignPhoneNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (phoneNumberId == null) throw new ArgumentException("Parameter cannot be null", nameof(phoneNumberId));
            return await rc.Patch<AccountPhoneNumberInfo>(Path(), assignPhoneNumberRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public PhoneNumbers.Index PhoneNumbers(string phoneNumberId = null)
        {
            return new PhoneNumbers.Index(this, phoneNumberId);
        }
    }
}