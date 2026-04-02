using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Extensions
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Index parent;
public Index(Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/extensions";
        }
        /// <summary>
        /// Returns a list of extensions which use the specified device as a forwarding target.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets/devices/{deviceId}/extensions
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.CommExtensionListResource> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CommExtensionListResource>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Extensions.Index Extensions()
        {
            return new Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Devices.Extensions.Index(this);
        }
    }
}