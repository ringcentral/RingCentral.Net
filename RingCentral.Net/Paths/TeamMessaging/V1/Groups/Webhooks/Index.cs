using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Groups.Webhooks
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        ///     Returns webhooks which are available for the current user by group ID.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/groups/{groupId}/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMWebhookList>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new webhook.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/groups/{groupId}/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMWebhookInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMWebhookInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Groups
{
    public partial class Index
    {
        public Webhooks.Index Webhooks()
        {
            return new Webhooks.Index(this);
        }
    }
}