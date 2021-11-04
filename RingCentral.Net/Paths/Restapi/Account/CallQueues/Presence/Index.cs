using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Presence
{
    public class Index
    {
        public CallQueues.Index parent;
        public RestClient rc;

        public Index(CallQueues.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        ///     Returns presence status of the call queue members.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence
        ///     Rate Limit Group: Light
        ///     App Permission: ReadPresence
        /// </summary>
        public async Task<CallQueuePresence> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallQueuePresence>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates presence status of the call queue members in the specified queue.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence
        ///     Rate Limit Group: Medium
        ///     App Permission: EditPresence
        /// </summary>
        public async Task<CallQueuePresence> Put(
            CallQueueUpdatePresence callQueueUpdatePresence, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CallQueuePresence>(Path(), callQueueUpdatePresence, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Presence.Index Presence()
        {
            return new Presence.Index(this);
        }
    }
}