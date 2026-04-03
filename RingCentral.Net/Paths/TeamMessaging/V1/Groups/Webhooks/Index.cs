using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Groups.Webhooks
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
            return $"{parent.Path()}/webhooks";
        }
        /// <summary>
        /// Returns webhooks which are available for the current user by group ID.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMWebhookList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a new webhook.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMWebhookInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.TMWebhookInfo>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Groups
{
    public partial class Index
    {
        public TeamMessaging.V1.Groups.Webhooks.Index Webhooks()
        {
            return new TeamMessaging.V1.Groups.Webhooks.Index(this);
        }
    }
}