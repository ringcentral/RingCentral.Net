using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.ForwardingTargets
{
    public partial class Index
    {
        public Voice.Index parent;
        public RestClient rc;

        public Index(Voice.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/forwarding-targets";
        }

        /// <summary>
        ///     Returns the extension's forwarding targets.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommForwardingTargetsResource> Get(ReadForwardingTargetsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CommForwardingTargetsResource>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Removes the specified forwarding targets from the extension's communication handling rules.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/forwarding-targets
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<CommRemoveForwardingTargetsResponse> Delete(
            CommRemoveForwardingTargetsRequest commRemoveForwardingTargetsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<CommRemoveForwardingTargetsResponse>(Path(), commRemoveForwardingTargetsRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public ForwardingTargets.Index ForwardingTargets()
        {
            return new ForwardingTargets.Index(this);
        }
    }
}