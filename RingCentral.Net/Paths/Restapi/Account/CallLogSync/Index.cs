using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallLogSync
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-log-sync";
        }

        /// <summary>
        /// Synchronizes company call log records.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-log-sync
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.AccountCallLogSyncResponse> Get(SyncAccountCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AccountCallLogSyncResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallLogSync.Index CallLogSync()
        {
            return new Restapi.Account.CallLogSync.Index(this);
        }
    }
}