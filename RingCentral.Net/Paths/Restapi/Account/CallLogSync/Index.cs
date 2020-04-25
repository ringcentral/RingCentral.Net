using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Sync Company Call Log
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-log-sync
        /// Rate Limit Group: Heavy
        /// App Permission Required: ReadCallLog
        /// User Permission Required: ReadCallLog
        /// </summary>
        public async Task<RingCentral.AccountCallLogSyncResponse> Get(SyncAccountCallLogParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AccountCallLogSyncResponse>(this.Path(), queryParams, cancellationToken);
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