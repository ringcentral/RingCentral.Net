using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Notifications.V1.Subscriptions
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Notifications.V1.Index parent;
public string subscriptionId;
public Index(Webinar.Notifications.V1.Index parent, string subscriptionId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.subscriptionId = subscriptionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && subscriptionId != null)
            {
                return $"{parent.Path()}/subscriptions/{subscriptionId}";
            }
            return $"{parent.Path()}/subscriptions";
        }
        /// <summary>
        /// Returns a list of webinar subscriptions created by the user for the current authorized client application.
        /// HTTP Method: get
        /// Endpoint: /webinar/notifications/v1/subscriptions
        /// Rate Limit Group: Light
        /// </summary>
  public async Task<RingCentral.SubscriptionListResource> List(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.SubscriptionListResource>(this.Path(false), null, restRequestConfig);
  }

        /// <summary>
        /// Creates a new webinar subscription for the current authorized user / client application.
        /// HTTP Method: post
        /// Endpoint: /webinar/notifications/v1/subscriptions
        /// Rate Limit Group: Medium
        /// </summary>
  public async Task<RingCentral.SubscriptionInfo> Post(RingCentral.CreateWebhookSubscriptionRequest createWebhookSubscriptionRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.SubscriptionInfo>(this.Path(false), createWebhookSubscriptionRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns the webinar subscription by ID
        /// HTTP Method: get
        /// Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        /// Rate Limit Group: Light
        /// </summary>
  public async Task<RingCentral.SubscriptionInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (subscriptionId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(subscriptionId));
    }return await rc.Get<RingCentral.SubscriptionInfo>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates the existing subscription. The client application can extend/narrow
/// the list of events for which it receives notifications within this subscription.
/// If event filters are specified, calling this method modifies them for the
/// existing subscription. The method also allows setting the subscription expiration time.
/// If other than `events` and `expiresIn` parameters are passed in the request they will be ignored.
/// If the request body is empty then the specified subscription will be just renewed without any
/// event filter modifications and with default expiration time.
/// 
        /// HTTP Method: put
        /// Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        /// Rate Limit Group: Medium
        /// </summary>
  public async Task<RingCentral.SubscriptionInfo> Put(RingCentral.UpdateSubscriptionRequest updateSubscriptionRequest, RestRequestConfig restRequestConfig = null)
  {
if (subscriptionId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(subscriptionId));
    }return await rc.Put<RingCentral.SubscriptionInfo>(this.Path(), updateSubscriptionRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Cancels the existing webinar subscription.
        /// HTTP Method: delete
        /// Endpoint: /webinar/notifications/v1/subscriptions/{subscriptionId}
        /// Rate Limit Group: Medium
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (subscriptionId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(subscriptionId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.Notifications.V1
{
    public partial class Index
    {
        public Webinar.Notifications.V1.Subscriptions.Index Subscriptions(string subscriptionId = null)
        {
            return new Webinar.Notifications.V1.Subscriptions.Index(this, subscriptionId);
        }
    }
}