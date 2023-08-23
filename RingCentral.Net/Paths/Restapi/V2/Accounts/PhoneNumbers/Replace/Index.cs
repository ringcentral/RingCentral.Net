using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers.Replace
{
    public class Index
    {
        public PhoneNumbers.Index parent;
        public RestClient rc;

        public Index(PhoneNumbers.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/replace";
        }

        /// <summary>
        ///     Replaces (swaps) phone numbers from Inventory with the main, company, direct or company fax numbers.
        ///     This method is used to replace temporary numbers when the porting process is complete.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/{phoneNumberId}/replace
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyPhoneNumbers
        /// </summary>
        public async Task<AccountPhoneNumberInfo> Post(ReplacePhoneNumberRequest replacePhoneNumberRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AccountPhoneNumberInfo>(Path(), replacePhoneNumberRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers
{
    public partial class Index
    {
        public Replace.Index Replace()
        {
            return new Replace.Index(this);
        }
    }
}