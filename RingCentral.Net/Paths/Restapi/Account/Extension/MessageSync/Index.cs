using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageSync
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
            return $"{parent.Path()}/message-sync";
        }

        /// <summary>
        /// Synchronizes messages.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-sync
        /// Rate Limit Group: Light
        /// App Permission: ReadMessages
        /// User Permission: ReadMessages
        /// </summary>
        public async Task<RingCentral.GetMessageSyncResponse> Get(RingCentral.SyncMessagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetMessageSyncResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageSync.Index MessageSync()
        {
            return new Restapi.Account.Extension.MessageSync.Index(this);
        }
    }
}