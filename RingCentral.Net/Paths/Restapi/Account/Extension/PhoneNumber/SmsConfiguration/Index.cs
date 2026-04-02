using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber.SmsConfiguration
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Extension.PhoneNumber.Index parent;
public Index(Restapi.Account.Extension.PhoneNumber.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sms-configuration";
        }
        /// <summary>
        /// Returns SMS configuration for the specified phone number of the extension.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/phone-number/{phoneNumberId}/sms-configuration
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.SmsConfigurationResource> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.SmsConfigurationResource>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public partial class Index
    {
        public Restapi.Account.Extension.PhoneNumber.SmsConfiguration.Index SmsConfiguration()
        {
            return new Restapi.Account.Extension.PhoneNumber.SmsConfiguration.Index(this);
        }
    }
}