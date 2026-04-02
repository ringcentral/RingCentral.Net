using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallLogExtractSync
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-log-extract-sync";
        }
        /// <summary>
        /// Extracts all company's call log records that were updated after the specified time.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-log-extract-sync
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
  public async Task<RingCentral.CallLogExtractSyncResponse> Get(RingCentral.ExtractSyncAccountCallLogParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CallLogExtractSyncResponse>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallLogExtractSync.Index CallLogExtractSync()
        {
            return new Restapi.Account.CallLogExtractSync.Index(this);
        }
    }
}