using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.UnifiedPresence
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
            return $"{parent.Path()}/unified-presence";
        }

        /// <summary>
        /// Returns the unified presence status of the requested user(s). The set of parameters returned by this method differs whether you return the requester's presence or any other user presence.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence
        /// Rate Limit Group: Medium
        /// App Permission: ReadPresence
        /// User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UnifiedPresence>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the unified presence for the current user specified in path.
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// User Permission: EditPresenceStatus
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Patch(RingCentral.UpdateUnifiedPresence updateUnifiedPresence,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.UnifiedPresence>(this.Path(), updateUnifiedPresence, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.UnifiedPresence.Index UnifiedPresence()
        {
            return new Restapi.Account.Extension.UnifiedPresence.Index(this);
        }
    }
}