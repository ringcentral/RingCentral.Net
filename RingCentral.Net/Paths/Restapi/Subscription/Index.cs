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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/subscription
        /// Rate Limit Group: Light
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.RecordsCollectionResourceSubscriptionResponse> List(
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.RecordsCollectionResourceSubscriptionResponse>(this.Path(false), null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Create Subscription
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/subscription
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Light
        /// App Permission Required: undefined
        /// User Permission Required: undefined
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
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
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
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
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