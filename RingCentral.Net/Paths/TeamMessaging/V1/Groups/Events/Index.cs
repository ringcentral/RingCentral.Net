using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Groups.Events
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Groups.Index parent;
        public Index(TeamMessaging.V1.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/events";
        }
        /// <summary>
        /// Returns a list of calendar events available for the current user within the specified group. Users can only see their personal tasks and public tasks.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMEventInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a new calendar event within the specified group.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/groups/{groupId}/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMEventInfo> Post(RingCentral.TMCreateEventRequest tMCreateEventRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.TMEventInfo>(this.Path(), tMCreateEventRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Groups
{
    public partial class Index
    {
        public TeamMessaging.V1.Groups.Events.Index Events()
        {
            return new TeamMessaging.V1.Groups.Events.Index(this);
        }
    }
}