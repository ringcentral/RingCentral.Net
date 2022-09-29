using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallQueuePresence
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-queue-presence";
        }

        /// <summary>
        ///     Returns a list of agent's call queues with the agent presence status (per queue).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence
        ///     Rate Limit Group: Light
        ///     App Permission: ReadPresence
        /// </summary>
        public async Task<ExtensionCallQueuePresenceList> Get(
            ReadExtensionCallQueuePresenceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ExtensionCallQueuePresenceList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates availability of the agent for the call queues.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-queue-presence
        ///     Rate Limit Group: Medium
        ///     App Permission: EditPresence
        /// </summary>
        public async Task<ExtensionCallQueuePresenceList> Put(
            ExtensionCallQueueUpdatePresenceList extensionCallQueueUpdatePresenceList,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<ExtensionCallQueuePresenceList>(Path(), extensionCallQueueUpdatePresenceList, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallQueuePresence.Index CallQueuePresence()
        {
            return new CallQueuePresence.Index(this);
        }
    }
}