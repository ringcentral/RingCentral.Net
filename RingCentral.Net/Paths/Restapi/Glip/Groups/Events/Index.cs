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

        /// <summary>
        /// Operation: Get Group Events
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEventInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Event by Group ID
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Post(RingCentral.GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate, null, restRequestConfig);
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