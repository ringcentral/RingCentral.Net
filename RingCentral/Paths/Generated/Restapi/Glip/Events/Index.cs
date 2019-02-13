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

        public async Task<RingCentral.GlipEventsInfo> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipEventsInfo>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipEventsInfo> List(object queryParams)
        {
            return await rc.Get<RingCentral.GlipEventsInfo>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipEventInfo> Post(RingCentral.GlipEventCreate glipEventCreate)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(false), glipEventCreate);
        }

        public async Task<RingCentral.GlipEventInfo> Post(object glipEventCreate)
        {
            return await rc.Post<RingCentral.GlipEventInfo>(this.Path(false), glipEventCreate);
        }

        public async Task<RingCentral.GlipEventInfo> Get()
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Get<RingCentral.GlipEventInfo>(this.Path());
        }

        public async Task<RingCentral.GlipEventInfo> Put(RingCentral.GlipEventCreate glipEventCreate)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Put<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate);
        }

        public async Task<RingCentral.GlipEventInfo> Put(object glipEventCreate)
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Put<RingCentral.GlipEventInfo>(this.Path(), glipEventCreate);
        }

        public async Task<string> Delete()
        {
            if (this.eventId == null)
            {
                throw new System.ArgumentNullException("eventId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }

    public class ListQueryParams
    {
        // Number of groups to be fetched by one request. The maximum value is 250, by default - 30.
        public long? recordCount;

        // Token of a page to be returned
        public string pageToken;
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