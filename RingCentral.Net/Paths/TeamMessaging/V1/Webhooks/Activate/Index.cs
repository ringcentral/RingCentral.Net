using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks.Activate
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Webhooks.Index parent;
public Index(TeamMessaging.V1.Webhooks.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/activate";
        }
        /// <summary>
        /// Activates a webhook by ID.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/webhooks/{webhookId}/activate
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks
{
    public partial class Index
    {
        public TeamMessaging.V1.Webhooks.Activate.Index Activate()
        {
            return new TeamMessaging.V1.Webhooks.Activate.Index(this);
        }
    }
}