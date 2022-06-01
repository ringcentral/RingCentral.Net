using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AuditTrail.Search
{
    public class Index
    {
        public AuditTrail.Index parent;
        public RestClient rc;

        public Index(AuditTrail.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/search";
        }

        /// <summary>
        ///     Returns the audit trail data applying specific filters. Audit trail searching is limited to the last 10,000 records
        ///     or last 180 days, whichever comes first.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/audit-trail/search
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAuditTrail
        /// </summary>
        public async Task<AccountHistorySearchPublicResponse> Post(
            AccountHistorySearchPublicRequest accountHistorySearchPublicRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AccountHistorySearchPublicResponse>(Path(), accountHistorySearchPublicRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.AuditTrail
{
    public partial class Index
    {
        public Search.Index Search()
        {
            return new Search.Index(this);
        }
    }
}