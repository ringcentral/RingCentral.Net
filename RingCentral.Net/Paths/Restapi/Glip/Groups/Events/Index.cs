using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.Events
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
        ///     Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/events
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipEventInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new calendar event within the specified group.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/events
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipEventInfo> Post(GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipEventInfo>(Path(), glipEventCreate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Events.Index Events()
        {
            return new Events.Index(this);
        }
    }
}