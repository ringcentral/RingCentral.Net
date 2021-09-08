using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string webhookId;

        public Index(Restapi.Glip.Index parent, string webhookId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.webhookId = webhookId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webhookId != null)
            {
                return $"{parent.Path()}/webhooks/{webhookId}";
            }

            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        /// Returns the list of all webhooks associated with the current account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns webhooks(s) with the specified id(s).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            if (webhookId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(webhookId));
            }

            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes a webhook by ID.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (webhookId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(webhookId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Webhooks.Index Webhooks(string webhookId = null)
        {
            return new Restapi.Glip.Webhooks.Index(this, webhookId);
        }
    }
}