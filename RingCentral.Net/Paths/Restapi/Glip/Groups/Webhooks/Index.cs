using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Groups.Webhooks
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
            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        /// Returns webhooks which are available for the current user by group ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Creates a new webhook.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipWebhookInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipWebhookInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Webhooks.Index Webhooks()
        {
            return new Restapi.Glip.Groups.Webhooks.Index(this);
        }
    }
}