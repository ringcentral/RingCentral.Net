using System.Threading.Tasks;

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
        /// Operation: Get Webhooks in Group
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Webhook in Group
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
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