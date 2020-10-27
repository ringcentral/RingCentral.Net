using System.Threading.Tasks;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/everyone
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEveryoneInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEveryoneInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Everyone Сhat
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/glip/everyone
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEveryoneInfo> Patch(
            RingCentral.UpdateGlipEveryoneRequest updateGlipEveryoneRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.GlipEveryoneInfo>(this.Path(), updateGlipEveryoneRequest, null,
                restRequestConfig);
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