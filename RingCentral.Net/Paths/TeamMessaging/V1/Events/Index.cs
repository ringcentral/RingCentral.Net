using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Events
{
    public class Index
    {
        public string eventId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string eventId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.eventId = eventId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && eventId != null) return $"{parent.Path()}/events/{eventId}";
            return $"{parent.Path()}/events";
        }

        /// <summary>
        ///     Returns all calendar events created by the current user.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventList> List(ReadGlipEventsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMEventList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new calendar event.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventInfo> Post(TMCreateEventRequest tMCreateEventRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMEventInfo>(Path(false), tMCreateEventRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns the specified calendar event(s) by ID(s).
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));
            return await rc.Get<TMEventInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified calendar event.
        ///     HTTP Method: put
        ///     Endpoint: /team-messaging/v1/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMEventInfo> Put(TMCreateEventRequest tMCreateEventRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));
            return await rc.Put<TMEventInfo>(Path(), tMCreateEventRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified calendar event.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/v1/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Events.Index Events(string eventId = null)
        {
            return new Events.Index(this, eventId);
        }
    }
}