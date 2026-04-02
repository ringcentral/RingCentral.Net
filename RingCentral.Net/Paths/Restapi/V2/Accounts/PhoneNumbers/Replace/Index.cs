using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers.Replace
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.PhoneNumbers.Index parent;
public Index(Restapi.V2.Accounts.PhoneNumbers.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/replace";
        }
        /// <summary>
        /// Replaces (swaps) phone numbers from inventory with the main, company, direct or company fax numbers.
/// This method is used to replace temporary numbers when the porting process is complete.
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/phone-numbers/{phoneNumberId}/replace
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyPhoneNumbers
        /// </summary>
  public async Task<RingCentral.AccountPhoneNumberInfo> Post(RingCentral.ReplacePhoneNumberRequest replacePhoneNumberRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.AccountPhoneNumberInfo>(this.Path(), replacePhoneNumberRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.PhoneNumbers
{
    public partial class Index
    {
        public Restapi.V2.Accounts.PhoneNumbers.Replace.Index Replace()
        {
            return new Restapi.V2.Accounts.PhoneNumbers.Replace.Index(this);
        }
    }
}