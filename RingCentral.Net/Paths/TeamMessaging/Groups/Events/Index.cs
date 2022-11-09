using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Groups.Events
{
    public class Index
    {
        public Groups.Index parent;
        public RestClient rc;

        public Index(Groups.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/events";
        }

        /// <summary>
        ///     Returns a list of calendar events available for the current user within the specified group. Users can only see
        ///     their personal tasks and public tasks.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/groups/{groupId}/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMEventInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new calendar event within the specified group.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/groups/{groupId}/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventInfo> Post(TMCreateEventRequest tMCreateEventRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMEventInfo>(Path(), tMCreateEventRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Groups
{
    public partial class Index
    {
        public Events.Index Events()
        {
            return new Events.Index(this);
        }
    }
}