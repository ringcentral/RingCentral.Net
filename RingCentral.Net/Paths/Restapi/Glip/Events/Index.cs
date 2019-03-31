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
        /// Http Get /restapi/v1.0/glip/events
        /// </summary>
        public async Task<RingCentral.GlipEventsInfo> List(LoadGlipEventsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipEventsInfo>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Create Event
        /// Http Post /restapi/v1.0/glip/events
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Post(RingCentral.GlipEventCreate glipEventCreate)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(false), glipEventCreate);
        }

        /// <summary>
        /// Operation: Get Event
        /// Http Get /restapi/v1.0/glip/events/{eventId}
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Get()
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Get<RingCentral.GlipEventInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Event
        /// Http Put /restapi/v1.0/glip/events/{eventId}
        /// </summary>
        public async Task<RingCentral.GlipEventInfo> Put(RingCentral.GlipEventCreate glipEventCreate)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Put<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate);
        }

        /// <summary>
        /// Operation: Delete Event
        /// Http Delete /restapi/v1.0/glip/events/{eventId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Delete<string>(this.Path());
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