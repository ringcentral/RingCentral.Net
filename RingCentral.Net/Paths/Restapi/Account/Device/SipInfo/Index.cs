using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Device.SipInfo
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Device.Index parent;

        public Index(Restapi.Account.Device.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sip-info";
        }

        /// <summary>
        /// Get Device SIP Info
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}/sip-info
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<RingCentral.SipInfoResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SipInfoResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public Restapi.Account.Device.SipInfo.Index SipInfo()
        {
            return new Restapi.Account.Device.SipInfo.Index(this);
        }
    }
}