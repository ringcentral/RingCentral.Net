using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber.SmsConfiguration
{
    public class Index
    {
        public PhoneNumber.Index parent;
        public RestClient rc;

        public Index(PhoneNumber.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sms-configuration";
        }

        /// <summary>
        ///     Returns SMS configuration for the specified phone number of the extension.
        ///     HTTP Method: get
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/phone-number/{phoneNumberId}/sms-configuration
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<SmsConfigurationResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SmsConfigurationResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public partial class Index
    {
        public SmsConfiguration.Index SmsConfiguration()
        {
            return new SmsConfiguration.Index(this);
        }
    }
}