using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageSync
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/message-sync";
        }

        /// <summary>
        ///     Synchronizes messages.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-sync
        ///     Rate Limit Group: Light
        ///     App Permission: ReadMessages
        ///     User Permission: ReadMessages
        /// </summary>
        public async Task<GetMessageSyncResponse> Get(SyncMessagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetMessageSyncResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public MessageSync.Index MessageSync()
        {
            return new MessageSync.Index(this);
        }
    }
}