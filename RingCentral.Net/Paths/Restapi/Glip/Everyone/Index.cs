using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Everyone
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/everyone";
        }

        /// <summary>
        /// Operation: Get Everyone Chat
        /// Http Get /restapi/v1.0/glip/everyone
        /// </summary>
        public async Task<RingCentral.GlipEveryoneInfo> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipEveryoneInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Everyone Сhat
        /// Http Patch /restapi/v1.0/glip/everyone
        /// </summary>
        public async Task<RingCentral.GlipEveryoneInfo> Patch(
            RingCentral.UpdateGlipEveryoneRequest updateGlipEveryoneRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Patch<RingCentral.GlipEveryoneInfo>(this.Path(), updateGlipEveryoneRequest, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Everyone.Index Everyone()
        {
            return new Restapi.Glip.Everyone.Index(this);
        }
    }
}