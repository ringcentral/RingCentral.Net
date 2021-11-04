using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Events
{
    public class Index
    {
        public string eventId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string eventId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipEventsInfo> List(ReadGlipEventsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipEventsInfo>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new calendar event.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/events
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipEventInfo> Post(GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipEventInfo>(Path(false), glipEventCreate, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns the specified calendar event(s) by ID(s).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));

            return await rc.Get<GlipEventInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified calendar event.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipEventInfo> Put(GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));

            return await rc.Put<GlipEventInfo>(Path(), glipEventCreate, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified calendar event.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (eventId == null) throw new ArgumentException("Parameter cannot be null", nameof(eventId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Events.Index Events(string eventId = null)
        {
            return new Events.Index(this, eventId);
        }
    }
}