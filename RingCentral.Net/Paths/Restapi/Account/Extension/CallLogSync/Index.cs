using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLogSync
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
            return $"{parent.Path()}/call-log-sync";
        }

        /// <summary>
        /// Operation: Sync User Call Log
        /// Rate Limit Group: Heavy
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync
        /// </summary>
        public async Task<RingCentral.CallLogSync> Get(SyncUserCallLogParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallLogSync>(this.Path(), queryParams, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallLogSync.Index CallLogSync()
        {
            return new Restapi.Account.Extension.CallLogSync.Index(this);
        }
    }
}