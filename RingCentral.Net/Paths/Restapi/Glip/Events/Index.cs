using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Events
{
    public partial class Index
    {
        public RestClient rc;
        public string eventId;
        public Restapi.Glip.Index parent;

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
        /// Operation: Get User Events List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/events
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventsInfo> List(ReadGlipEventsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipEventsInfo>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Event
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/events
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
        /// Operation: Get Event
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Get<RingCentral.GlipEventInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Event
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Put(RingCentral.GlipEventCreate glipEventCreate,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Put<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Event
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

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