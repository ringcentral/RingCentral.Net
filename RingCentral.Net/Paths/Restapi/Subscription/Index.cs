using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Subscription
{
    public partial class Index
    {
        public Restapi.Index parent;
        public RestClient rc;
        public string subscriptionId;

        public Index(Restapi.Index parent, string subscriptionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.subscriptionId = subscriptionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && subscriptionId != null) return $"{parent.Path()}/subscription/{subscriptionId}";

            return $"{parent.Path()}/subscription";
        }

        /// <summary>
        ///     Returns a list of subscriptions created by the user for the current authorized client application.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/subscription
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionListResource> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SubscriptionListResource>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     This API allows client applications to register a new subscription so that it
        ///     can be notified of events when they occur on the platform.
        ///     A subscription relates to a set of events that a client application would like
        ///     to be informed of and the delivery channel by which they will be notified of
        ///     those events. How subscriptions are established depends upon the notification
        ///     channel the client application would like to use to receive the event
        ///     notification. For example, to create a webhook a developer would create a
        ///     subscription via a REST API call, while specifying a list of events or "event
        ///     filters" to be notified of, a transport type of `WebHook`, and the address or
        ///     URL to which they would like the webhook delivered.
        ///     However, developers wishing to subscribe to a set of events via a WebSocket
        ///     channel, would first connect to the WebSocket gateway, and then issue their
        ///     subscription request over the WebSocket itself, as opposed to making a REST
        ///     API call to this endpoint.
        ///     While the protocol for establishing a subscription may vary depending upon
        ///     the delivery channel for that subscription, the schemas used for representing
        ///     a subscription are the same across all delivery modes.
        ///     Subscriptions are currently limited to 20 subscriptions per user/extension (for particular application).
        ///     RingCentral currently supports the following delivery modes for event subscriptions:
        ///     * [WebHook](https://developers.ringcentral.com/guide/notifications/webhooks/quick-start) - to receive event
        ///     notifications as an HTTP POST to a given URL
        ///     * [WebSocket](https://developers.ringcentral.com/guide/notifications/websockets/quick-start) - to receive real-time
        ///     events over a persistent WebSocket connection
        ///     * [PubNub](https://developers.ringcentral.com/guide/notifications/push-notifications/quick-start) (deprecated) - to
        ///     receive a push notification sent directly to a client application
        ///     Developers should be aware that the PubNub delivery mode is currently
        ///     deprecated and will be removed in 2024. Developers are encouraged to
        ///     [migrate their client applications to use
        ///     WebSockets](https://developers.ringcentral.com/guide/notifications/websockets/migration/)
        ///     instead.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/subscription
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<SubscriptionInfo> Post(
            CreateSubscriptionRequest createSubscriptionRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SubscriptionInfo>(Path(false), createSubscriptionRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the existing subscription by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<SubscriptionInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (subscriptionId == null) throw new ArgumentException("Parameter cannot be null", nameof(subscriptionId));

            return await rc.Get<SubscriptionInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the existing subscription. The client application can extend or narrow
        ///     the list of events for which it receives notifications within the current subscription.
        ///     If event filters are specified, calling this method modifies them for the
        ///     existing subscription. The method also allows one to set an expiration time for the
        ///     subscription itself.
        ///     If parameters other than `events` and `expiresIn` are specified in the request they will be ignored.
        ///     If the request body is empty then the specified subscription will be renewed without any
        ///     event filter modifications and using the default expiration time.
        ///     If the request is sent with empty body, it just renews a subscription
        ///     (so it is an equivalent of the `POST /restapi/v1.0/subscription/{subscriptionId}/renew`).
        ///     Please note that `WebSocket` subscriptions cannot be updated via HTTP interface.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
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
        ///     Cancels the existing subscription.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/subscription/{subscriptionId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (subscriptionId == null) throw new ArgumentException("Parameter cannot be null", nameof(subscriptionId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Subscription.Index Subscription(string subscriptionId = null)
        {
            return new Subscription.Index(this, subscriptionId);
        }
    }
}