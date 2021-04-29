using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Subscription
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;
        public string subscriptionId;

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
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/subscription
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.RecordsCollectionResourceSubscriptionResponse> List(
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RecordsCollectionResourceSubscriptionResponse>(this.Path(false), null,
                restRequestConfig);
        }

        /// <summary>
        /// Creates a new subscription.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/subscription
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Post(
            RingCentral.CreateSubscriptionRequest createSubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createSubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns the requested subscription by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SubscriptionInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the existent subscription. The client application can extend/narrow the events for which it receives notifications within the frame of one subscription. If event filters are specified, calling this method modifies them for the existing subscription. The method also allows to set the subscription expiration time. If other than `events` and `expiresIn` parameters are passed in request they will be ignored. If the request body is empty then the specified subscription will be just renewed without any event filter change and with expiration time default.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.SubscriptionInfo> Put(
            RingCentral.ModifySubscriptionRequest modifySubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), modifySubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Cancels the existent subscription.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
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