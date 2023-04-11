using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string webhookId;

        public Index(V1.Index parent, string webhookId = null)
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
        ///     Endpoint: /team-messaging/v1/webhooks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMWebhookList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMWebhookList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns webhooks(s) with the specified id(s).
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/webhooks/{webhookId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMWebhookList> Get(RestRequestConfig restRequestConfig = null)
        {
            if (webhookId == null) throw new ArgumentException("Parameter cannot be null", nameof(webhookId));
            return await rc.Get<TMWebhookList>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a webhook by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/v1/webhooks/{webhookId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (webhookId == null) throw new ArgumentException("Parameter cannot be null", nameof(webhookId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Webhooks.Index Webhooks(string webhookId = null)
        {
            return new Webhooks.Index(this, webhookId);
        }
    }
}