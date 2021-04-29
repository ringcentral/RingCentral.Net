using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.CallQueuePresence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-queue-presence";
        }

        /// <summary>
        /// Returns a list of agent's call queues with the agent presence status (per queue)
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// Rate Limit Group: Light
        /// App Permission: ReadPresence
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Get(
            RingCentral.ReadExtensionCallQueuePresenceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ExtensionCallQueuePresenceList>(this.Path(), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Updates availability of the agent for the call queues.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Put(
            RingCentral.ExtensionCallQueueUpdatePresenceList extensionCallQueueUpdatePresenceList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.ExtensionCallQueuePresenceList>(this.Path(),
                extensionCallQueueUpdatePresenceList, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallQueuePresence.Index CallQueuePresence()
        {
            return new Restapi.Account.Extension.CallQueuePresence.Index(this);
        }
    }
}