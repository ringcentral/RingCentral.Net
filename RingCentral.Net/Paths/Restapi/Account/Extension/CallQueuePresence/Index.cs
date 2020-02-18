using System.Threading.Tasks;

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
        /// Operation: Get Agent’s Call Queue Presence
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Get(
            ReadExtensionCallQueuePresenceParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ExtensionCallQueuePresenceList>(this.Path(), queryParams);
        }

        /// <summary>
        /// Operation: Update Call Queue Presence
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence
        /// </summary>
        public async Task<RingCentral.ExtensionCallQueuePresenceList> Put(
            RingCentral.ExtensionCallQueueUpdatePresenceList extensionCallQueueUpdatePresenceList)
        {
            return await rc.Put<RingCentral.ExtensionCallQueuePresenceList>(this.Path(),
                extensionCallQueueUpdatePresenceList);
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