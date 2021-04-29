using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Events
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string eventId;

        public Index(Restapi.Glip.Index parent, string eventId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.eventId = eventId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && eventId != null)
            {
                return $"{parent.Path()}/events/{eventId}";
            }

            return $"{parent.Path()}/events";
        }

        /// <summary>
        /// Returns all calendar events created by the current user.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/events
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventsInfo> List(RingCentral.ReadGlipEventsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEventsInfo>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new calendar event.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/events
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Post(RingCentral.GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(false), glipEventCreate, null, restRequestConfig);
        }

        /// <summary>
        /// Returns the specified calendar event(s) by ID(s).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEventInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the specified calendar event.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Put(RingCentral.GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified calendar event.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Events.Index Events(string eventId = null)
        {
            return new Restapi.Glip.Events.Index(this, eventId);
        }
    }
}