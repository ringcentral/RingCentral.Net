using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Webhooks.Activate
{
    public class Index
    {
        public Webhooks.Index parent;
        public RestClient rc;

        public Index(Webhooks.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/activate";
        }

        /// <summary>
        ///     Activates a webhook by ID.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}/activate
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public Activate.Index Activate()
        {
            return new Activate.Index(this);
        }
    }
}