using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Webhooks.Activate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Webhooks.Index parent;

        public Index(Restapi.Glip.Webhooks.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/activate";
        }

        // Operation: activateGlipWebhook
        // Http Post /restapi/v1.0/glip/webhooks/{webhookId}/activate
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public Restapi.Glip.Webhooks.Activate.Index Activate()
        {
            return new Restapi.Glip.Webhooks.Activate.Index(this);
        }
    }
}