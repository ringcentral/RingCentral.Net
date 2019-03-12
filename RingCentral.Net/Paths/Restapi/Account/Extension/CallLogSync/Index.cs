using System.Threading.Tasks;

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

        // Operation: Sync User Call Log
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync
        public async Task<RingCentral.CallLogSync> Get(SyncUserCallLogParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CallLogSync>(this.Path(), queryParams);
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