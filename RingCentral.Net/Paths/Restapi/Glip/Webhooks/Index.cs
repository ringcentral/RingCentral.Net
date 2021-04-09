using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public Glip.Index parent;
        public RestClient rc;
        public string webhookId;

        public Index(Glip.Index parent, string webhookId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.webhookId = webhookId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webhookId != null) return $"{parent.Path()}/webhooks/{webhookId}";
            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        ///     Returns the list of all webhooks associated with the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipWebhookList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipWebhookList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns webhooks(s) with the specified id(s).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipWebhookList>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a webhook by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/webhooks/{webhookId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Webhooks.Index Webhooks(string webhookId = null)
        {
            return new Webhooks.Index(this, webhookId);
        }
    }
}