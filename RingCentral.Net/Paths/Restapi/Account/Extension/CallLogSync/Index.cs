using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLogSync
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
            return $"{parent.Path()}/call-log-sync";
        }

        /// <summary>
        ///     Synchronizes the user call log records.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/call-log-sync
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<CallLogSyncResponse> Get(SyncUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallLogSyncResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CallLogSync.Index CallLogSync()
        {
            return new CallLogSync.Index(this);
        }
    }
}