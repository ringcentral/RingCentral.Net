using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallLogExtractSync
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-log-extract-sync";
        }

        /// <summary>
        ///     Extracts all company's call log records that were updated after the specified time.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log-extract-sync
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallLog
        ///     User Permission: ReadCallLog
        /// </summary>
        public async Task<CallLogExtractSyncResponse> Get(ExtractSyncAccountCallLogParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallLogExtractSyncResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallLogExtractSync.Index CallLogExtractSync()
        {
            return new CallLogExtractSync.Index(this);
        }
    }
}