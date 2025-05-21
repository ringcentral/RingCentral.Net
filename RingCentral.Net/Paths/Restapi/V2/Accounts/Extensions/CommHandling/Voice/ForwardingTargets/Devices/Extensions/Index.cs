using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Extensions
{
    public class Index
    {
        public Devices.Index parent;
        public RestClient rc;

        public Index(Devices.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/extensions";
        }

        /// <summary>
        ///     Returns a list of extensions which use the specified device as a forwarding target.
        ///     HTTP Method: get
        ///     Endpoint:
        ///     /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets/devices/{deviceId}/extensions
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommExtensionListResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CommExtensionListResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices
{
    public partial class Index
    {
        public Extensions.Index Extensions()
        {
            return new Extensions.Index(this);
        }
    }
}