using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Extensions.CommHandling.Voice.Index parent;
public Index(Restapi.V2.Accounts.Extensions.CommHandling.Voice.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/forwarding-targets";
        }
        /// <summary>
        /// Returns the extension's forwarding targets.
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.CommForwardingTargetsResource> Get(RingCentral.ReadForwardingTargetsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CommForwardingTargetsResource>(this.Path(), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Removes the specified forwarding targets from the extension's communication handling rules.
        /// HTTP Method: delete
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<RingCentral.CommRemoveForwardingTargetsResponse> Delete(RingCentral.CommRemoveForwardingTargetsRequest commRemoveForwardingTargetsRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Delete<RingCentral.CommRemoveForwardingTargetsResponse>(this.Path(), commRemoveForwardingTargetsRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Index ForwardingTargets()
        {
            return new Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets.Index(this);
        }
    }
}