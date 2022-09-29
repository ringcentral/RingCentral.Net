using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Subscription.Renew
{
    public class Index
    {
        public Subscription.Index parent;
        public RestClient rc;

        public Index(Subscription.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/renew";
        }

        /// <summary>
        ///     Renews the existing subscription (this request comes with empty body).
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}/renew
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SubscriptionInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Subscription
{
    public partial class Index
    {
        public Renew.Index Renew()
        {
            return new Renew.Index(this);
        }
    }
}