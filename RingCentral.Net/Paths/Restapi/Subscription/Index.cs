using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Subscriptions
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/subscription
        /// </summary>
        public async Task<RingCentral.RecordsCollectionResourceSubscriptionResponse> List(
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.RecordsCollectionResourceSubscriptionResponse>(this.Path(false), null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Create Subscription
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/subscription
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Post(
            RingCentral.CreateSubscriptionRequest createSubscriptionRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createSubscriptionRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get Subscription
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/subscription/{subscriptionId}
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Get<RingCentral.SubscriptionInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Renew Subscription / Update Event Filters
        /// Rate Limit Group: Medium
        /// Http Put /restapi/v1.0/subscription/{subscriptionId}
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Put(
            RingCentral.ModifySubscriptionRequest modifySubscriptionRequest,
            UpdateSubscriptionParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), modifySubscriptionRequest, queryParams,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Cancel Subscription
        /// Rate Limit Group: Medium
        /// Http Delete /restapi/v1.0/subscription/{subscriptionId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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