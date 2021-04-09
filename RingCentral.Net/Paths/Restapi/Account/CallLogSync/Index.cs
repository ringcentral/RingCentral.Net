using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallLogSync
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-log-sync";
        }

        /// <summary>
        ///     Synchronizes company call log records.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log-sync
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<AccountCallLogSyncResponse> Get(
            SyncAccountCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AccountCallLogSyncResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallLogSync.Index CallLogSync()
        {
            return new CallLogSync.Index(this);
        }
    }
}