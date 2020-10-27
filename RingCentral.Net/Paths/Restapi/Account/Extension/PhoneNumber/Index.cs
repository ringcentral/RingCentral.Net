using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/phone-number";
        }

        /// <summary>
        /// Operation: Get Extension Phone Number List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserPhoneNumbers
        /// </summary>
        public async Task<RingCentral.GetExtensionPhoneNumbersResponse> Get(
            ListExtensionPhoneNumbersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetExtensionPhoneNumbersResponse>(this.Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.PhoneNumber.Index PhoneNumber()
        {
            return new Restapi.Account.Extension.PhoneNumber.Index(this);
        }
    }
}