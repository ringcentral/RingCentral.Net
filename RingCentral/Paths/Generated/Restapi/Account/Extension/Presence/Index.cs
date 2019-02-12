using System.Threading.Tasks;

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

        public async Task<RingCentral.GetPresenceInfo> Get()
        {
            return await rc.Get<RingCentral.GetPresenceInfo>(this.Path());
        }

        public async Task<RingCentral.PresenceInfoResource> Put(RingCentral.PresenceInfoResource presenceInfoResource)
        {
            return await rc.Put<RingCentral.PresenceInfoResource>(this.Path(), presenceInfoResource);
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