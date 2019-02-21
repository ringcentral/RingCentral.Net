using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Subscription
{
    public partial class Index
    {
        public RestClient rc;
        public string subscriptionId;
        public Restapi.Index parent;

        public Index(Restapi.Index parent, string subscriptionId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.subscriptionId = subscriptionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && subscriptionId != null)
            {
                return $"{parent.Path()}/subscription/{subscriptionId}";
            }

            return $"{parent.Path()}/subscription";
        }

        public async Task<RingCentral.RecordsCollectionResourceSubscriptionResponse> List()
        {
            return await rc.Get<RingCentral.RecordsCollectionResourceSubscriptionResponse>(this.Path(false));
        }

        public async Task<RingCentral.SubscriptionInfo> Post(
            RingCentral.CreateSubscriptionRequest createSubscriptionRequest)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createSubscriptionRequest);
        }

        public async Task<RingCentral.SubscriptionInfo> Post(object createSubscriptionRequest)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createSubscriptionRequest);
        }

        public async Task<RingCentral.SubscriptionInfo> Get()
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Get<RingCentral.SubscriptionInfo>(this.Path());
        }

        public async Task<RingCentral.SubscriptionInfo> Put(
            RingCentral.ModifySubscriptionRequest modifySubscriptionRequest,
            UpdateSubscriptionParameters queryParams = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), modifySubscriptionRequest, queryParams);
        }

        public async Task<RingCentral.SubscriptionInfo> Put(object modifySubscriptionRequest, object queryParams)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), modifySubscriptionRequest, queryParams);
        }

        public async Task<string> Delete()
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.Subscription.Index Subscription(string subscriptionId = null)
        {
            return new Restapi.Subscription.Index(this, subscriptionId);
        }
    }
}