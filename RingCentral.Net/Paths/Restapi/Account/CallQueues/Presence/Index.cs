using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Presence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallQueues.Index parent;

        public Index(Restapi.Account.CallQueues.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        /// Operation: Get Call Queue Presence
        /// Http Get /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Get()
        {
            return await rc.Get<RingCentral.CallQueuePresence>(this.Path());
        }

        /// <summary>
        /// Operation: Update Call Queue Presence
        /// Http Put /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Put(
            RingCentral.CallQueueUpdatePresence callQueueUpdatePresence)
        {
            return await rc.Put<RingCentral.CallQueuePresence>(this.Path(), callQueueUpdatePresence);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Presence.Index Presence()
        {
            return new Restapi.Account.CallQueues.Presence.Index(this);
        }
    }
}