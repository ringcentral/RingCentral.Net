using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string subscriptionId;

        public Index(V1.Index parent, string subscriptionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.subscriptionId = subscriptionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && subscriptionId != null) return $"{parent.Path()}/subscriptions/{subscriptionId}";

            return $"{parent.Path()}/subscriptions";
        }

        /// <summary>
        ///     Returns a list of webinar subscriptions created by the user for the current authorized client application.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/notifications/v1/subscriptions
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionListResource> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SubscriptionListResource>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new webinar subscription for the current authorized user / client application.
        ///     HTTP Method: post
        ///     Endpoint: /webinar/notifications/v1/subscriptions
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<SubscriptionInfo> Post(
            CreateWebhookSubscriptionRequest createWebhookSubscriptionRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SubscriptionInfo>(Path(false), createWebhookSubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the webinar subscription by ID
        ///     HTTP Method: get
        ///     Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (subscriptionId == null) throw new ArgumentException("Parameter cannot be null", nameof(subscriptionId));

            return await rc.Get<SubscriptionInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the existing subscription. The client application can extend/narrow
        ///     the list of events for which it receives notifications within this subscription.
        ///     If event filters are specified, calling this method modifies them for the
        ///     existing subscription. The method also allows setting the subscription expiration time.
        ///     If other than `events` and `expiresIn` parameters are passed in the request they will be ignored.
        ///     If the request body is empty then the specified subscription will be just renewed without any
        ///     event filter modifications and with default expiration time.
        ///     HTTP Method: put
        ///     Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<SubscriptionInfo> Put(
            UpdateSubscriptionRequest updateSubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            if (subscriptionId == null) throw new ArgumentException("Parameter cannot be null", nameof(subscriptionId));

            return await rc.Put<SubscriptionInfo>(Path(), updateSubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Cancels the existing webinar subscription.
        ///     HTTP Method: delete
        ///     Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (subscriptionId == null) throw new ArgumentException("Parameter cannot be null", nameof(subscriptionId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Notifications.V1
{
    public partial class Index
    {
        public Subscriptions.Index Subscriptions(string subscriptionId = null)
        {
            return new Subscriptions.Index(this, subscriptionId);
        }
    }
}