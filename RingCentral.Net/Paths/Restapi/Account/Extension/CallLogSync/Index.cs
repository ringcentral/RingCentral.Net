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

        /// <summary>
        /// Operation: Sync User Call Log
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.CallLogSync> Get(SyncUserCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallLogSync>(this.Path(), queryParams, restRequestConfig);
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