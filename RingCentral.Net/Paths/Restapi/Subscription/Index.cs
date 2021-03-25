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

        /// <summary>
        /// Returns the list of subscriptions created by the logged-in user for the currently authorized client application.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/subscription
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.RecordsCollectionResourceSubscriptionResponse> List(
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RecordsCollectionResourceSubscriptionResponse>(this.Path(false), null,
                restRequestConfig);
        }

        /// <summary>
        /// Creates a new subscription.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/subscription
        /// Rate Limit Group: Medium
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Post(
            RingCentral.CreateSubscriptionRequest createSubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createSubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns the requested subscription by ID.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Get<RingCentral.SubscriptionInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the existent subscription. The client application can extend/narrow the events for which it receives notifications within the frame of one subscription. If event filters are specified, calling this method modifies them for the existing subscription. The method also allows to set the subscription expiration time. If other than `events` and `expiresIn` parameters are passed in request they will be ignored. If the request body is empty then the specified subscription will be just renewed without any event filter change and with expiration time default.
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Put(
            RingCentral.ModifySubscriptionRequest modifySubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), modifySubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Cancels the existent subscription.
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.subscriptionId == null)
            {
                throw new System.ArgumentNullException("subscriptionId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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