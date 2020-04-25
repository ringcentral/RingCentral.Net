using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Sync Messages
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync
        /// </summary>
        public async Task<RingCentral.GetMessageSyncResponse> Get(SyncMessagesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetMessageSyncResponse>(this.Path(), queryParams, cancellationToken);
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