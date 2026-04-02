using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions.Renew
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Notifications.V1.Subscriptions.Index parent;
public Index(Webinar.Notifications.V1.Subscriptions.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/renew";
        }
        /// <summary>
        /// Renews the existing webinar subscription.
        /// HTTP Method: post
        /// Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}/renew
        /// Rate Limit Group: Light
        /// </summary>
  public async Task<RingCentral.SubscriptionInfo> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions
{
    public partial class Index
    {
        public Webinar.Notifications.V1.Subscriptions.Renew.Index Renew()
        {
            return new Webinar.Notifications.V1.Subscriptions.Renew.Index(this);
        }
    }
}