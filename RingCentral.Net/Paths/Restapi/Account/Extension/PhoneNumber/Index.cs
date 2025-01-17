using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/phone-number";
        }

        /// <summary>
        ///     Returns the list of phone numbers that are used by a particular extension,
        ///     can be filtered by the phone number type. The returned list contains all
        ///     numbers which are directly mapped to the given extension. Plus the features
        ///     and company-level numbers that may be used when performing different operations
        ///     on behalf of this extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/phone-number
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserPhoneNumbers
        /// </summary>
        public async Task<GetExtensionPhoneNumbersResponse> Get(
            ListExtensionPhoneNumbersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetExtensionPhoneNumbersResponse>(Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public PhoneNumber.Index PhoneNumber()
        {
            return new PhoneNumber.Index(this);
        }
    }
}