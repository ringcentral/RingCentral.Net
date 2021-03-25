using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Webhooks.Suspend
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
            return $"{parent.Path()}/suspend";
        }

        /// <summary>
        /// Suspends a webhook by ID.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/webhooks/{webhookId}/suspend
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public Restapi.Glip.Webhooks.Suspend.Index Suspend()
        {
            return new Restapi.Glip.Webhooks.Suspend.Index(this);
        }
    }
}