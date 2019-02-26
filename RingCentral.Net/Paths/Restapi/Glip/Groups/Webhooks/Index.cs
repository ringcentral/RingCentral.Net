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

        // Operation: createGlipGroupWebhook
        public async Task<RingCentral.GlipWebhookInfo> Post()
        {
            return await rc.Post<RingCentral.GlipWebhookInfo>(this.Path());
        }

        // Operation: listGlipGroupWebhooks
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