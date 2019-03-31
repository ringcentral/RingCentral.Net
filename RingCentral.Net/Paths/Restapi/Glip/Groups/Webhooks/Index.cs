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
        /// Operation: Create Webhook in Group
        /// Http Post /restapi/v1.0/glip/groups/{groupId}/webhooks
        /// </summary>
        public async Task<RingCentral.GlipWebhookInfo> Post()
        {
            return await rc.Post<RingCentral.GlipWebhookInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Get Webhooks in Group
        /// Http Get /restapi/v1.0/glip/groups/{groupId}/webhooks
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> Get()
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path());
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