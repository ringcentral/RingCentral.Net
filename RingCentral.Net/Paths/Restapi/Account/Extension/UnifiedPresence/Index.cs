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
        /// Operation: Get Unified Presence
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Get()
        {
            return await rc.Get<RingCentral.UnifiedPresence>(this.Path());
        }

        /// <summary>
        /// Operation: Update Unified Presence
        /// Http Patch /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence
        /// </summary>
        public async Task<RingCentral.UnifiedPresence> Patch(RingCentral.UpdateUnifiedPresence updateUnifiedPresence)
        {
            return await rc.Patch<RingCentral.UnifiedPresence>(this.Path(), updateUnifiedPresence);
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