using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Subscription.Renew
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Subscription.Index parent;

        public Index(Restapi.Subscription.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/renew";
        }

        /// <summary>
        /// Renews an existent subscription by posting request with an empty body.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}/renew
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Subscription
{
    public partial class Index
    {
        public Restapi.Subscription.Renew.Index Renew()
        {
            return new Restapi.Subscription.Renew.Index(this);
        }
    }
}