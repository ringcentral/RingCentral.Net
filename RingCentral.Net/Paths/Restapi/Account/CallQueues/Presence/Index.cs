using System.Threading.Tasks;
using System.Threading;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence
        /// Rate Limit Group: Light
        /// App Permission: ReadPresence
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallQueuePresence>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Call Queue Presence
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Put(
            RingCentral.CallQueueUpdatePresence callQueueUpdatePresence, CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.CallQueuePresence>(this.Path(), callQueueUpdatePresence, null,
                cancellationToken);
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