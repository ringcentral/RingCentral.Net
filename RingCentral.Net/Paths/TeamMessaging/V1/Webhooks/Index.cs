using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string webhookId;
public Index(TeamMessaging.V1.Index parent, string webhookId = null)
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
        /// Endpoint: /team-messaging/v1/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMWebhookList> List(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.TMWebhookList>(this.Path(false), null, restRequestConfig);
  }

        /// <summary>
        /// Returns webhooks(s) with the specified id(s).
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMWebhookList> Get(RestRequestConfig restRequestConfig = null)
  {
if (webhookId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(webhookId));
    }return await rc.Get<RingCentral.TMWebhookList>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a webhook by ID.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (webhookId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(webhookId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Webhooks.Index Webhooks(string webhookId = null)
        {
            return new TeamMessaging.V1.Webhooks.Index(this, webhookId);
        }
    }
}