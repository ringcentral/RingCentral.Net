using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.Events
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/events";
        }

        public async Task<RingCentral.GlipEventInfo> Post(RingCentral.GlipEventCreate glipEventCreate)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate);
        }

        public async Task<RingCentral.GlipEventInfo> Post(object glipEventCreate)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate);
        }

        public async Task<RingCentral.GlipEventInfo> Get()
        {
            return await rc.Get<RingCentral.GlipEventInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Events.Index Events()
        {
            return new Restapi.Glip.Groups.Events.Index(this);
        }
    }
}