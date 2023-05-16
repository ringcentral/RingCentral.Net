using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions.Renew
{
    public class Index
    {
        public Subscriptions.Index parent;
        public RestClient rc;

        public Index(Subscriptions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/renew";
        }

        /// <summary>
        ///     Renews the existing webinar subscription.
        ///     HTTP Method: post
        ///     Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}/renew
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SubscriptionInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions
{
    public partial class Index
    {
        public Renew.Index Renew()
        {
            return new Renew.Index(this);
        }
    }
}