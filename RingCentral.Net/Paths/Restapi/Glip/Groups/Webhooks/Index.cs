using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.Webhooks
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
            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        ///     Returns webhooks which are available for the current user by group ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipWebhookList>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new webhook.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipWebhookInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipWebhookInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Webhooks.Index Webhooks()
        {
            return new Webhooks.Index(this);
        }
    }
}