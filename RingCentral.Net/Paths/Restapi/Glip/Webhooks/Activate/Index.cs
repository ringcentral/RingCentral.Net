using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /// <summary>
        /// Activates a webhook by ID.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}/activate
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
        public Restapi.Glip.Webhooks.Activate.Index Activate()
        {
            return new Restapi.Glip.Webhooks.Activate.Index(this);
        }
    }
}