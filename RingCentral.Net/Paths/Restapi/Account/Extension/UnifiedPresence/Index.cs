using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.UnifiedPresence
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

        public string Path()
        {
            return $"{parent.Path()}/unified-presence";
        }

        /// <summary>
        ///     Returns the unified presence status of the requested user(s). The set of parameters returned by this method differs
        ///     whether you return the requester's presence or any other user presence.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/unified-presence
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadPresence
        ///     User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UnifiedPresence>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the unified presence for the current user specified in path.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/unified-presence
        ///     Rate Limit Group: Medium
        ///     App Permission: EditPresence
        ///     User Permission: EditPresenceStatus
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Patch(UpdateUnifiedPresence updateUnifiedPresence,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.UnifiedPresence>(Path(), updateUnifiedPresence, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public UnifiedPresence.Index UnifiedPresence()
        {
            return new UnifiedPresence.Index(this);
        }
    }
}