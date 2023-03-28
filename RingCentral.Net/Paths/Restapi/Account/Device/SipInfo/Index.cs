using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Device.SipInfo
{
    public class Index
    {
        public Device.Index parent;
        public RestClient rc;

        public Index(Device.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sip-info";
        }

        /// <summary>
        ///     Returns device SIP information.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}/sip-info
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<SipInfoResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SipInfoResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Device
{
    public partial class Index
    {
        public SipInfo.Index SipInfo()
        {
            return new SipInfo.Index(this);
        }
    }
}