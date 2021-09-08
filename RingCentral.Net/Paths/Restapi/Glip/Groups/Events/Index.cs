using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Returns a list of calendar events available for the current user within the specified group. Users can only see their personal tasks and public tasks.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEventInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a new calendar event within the specified group.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
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