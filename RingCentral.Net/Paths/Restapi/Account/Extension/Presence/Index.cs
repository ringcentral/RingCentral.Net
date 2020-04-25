using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Presence
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
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        /// Operation: Get User Presence Status
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence
        /// </summary>
        public async Task<RingCentral.GetPresenceInfo> Get(ReadUserPresenceStatusParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetPresenceInfo>(this.Path(), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Update User Presence Status
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence
        /// </summary>
        public async Task<RingCentral.PresenceInfoResponse> Put(RingCentral.PresenceInfoResource presenceInfoResource,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.PresenceInfoResponse>(this.Path(), presenceInfoResource, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Presence.Index Presence()
        {
            return new Restapi.Account.Extension.Presence.Index(this);
        }
    }
}