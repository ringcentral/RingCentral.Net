using System.Threading.Tasks;

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

        // Operation: Renew Subscription
        // Http Post /restapi/v1.0/subscription/{subscriptionId}/renew
        public async Task<RingCentral.SubscriptionInfo> Post()
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path());
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