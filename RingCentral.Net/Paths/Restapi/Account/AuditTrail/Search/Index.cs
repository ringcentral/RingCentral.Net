using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AuditTrail.Search
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.AuditTrail.Index parent;
public Index(Restapi.Account.AuditTrail.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/search";
        }
        /// <summary>
        /// Returns the audit trail data with specific filters applied.
/// Audit trail searching is limited to the last 10,000 records or last 180 days, whichever comes first.
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/audit-trail/search
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAuditTrail
        /// </summary>
  public async Task<RingCentral.AccountHistorySearchPublicResponse> Post(RingCentral.AccountHistorySearchPublicRequest accountHistorySearchPublicRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.AccountHistorySearchPublicResponse>(this.Path(), accountHistorySearchPublicRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.AuditTrail
{
    public partial class Index
    {
        public Restapi.Account.AuditTrail.Search.Index Search()
        {
            return new Restapi.Account.AuditTrail.Search.Index(this);
        }
    }
}