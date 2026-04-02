using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Insights
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Index parent;
public Index(Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/insights";
        }
        /// <summary>
        /// Returns the insights of all call recordings in a session
        /// HTTP Method: get
        /// Endpoint: /ai/ringsense/v1/public/accounts/{accountId}/domains/{domain}/sessions/{sourceSessionId}/insights
        /// Rate Limit Group: Light
        /// App Permission: RingSense
        /// </summary>
  public async Task<RingCentral.SessionsInsightsResource> Get(RingCentral.GetSessionInsightsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.SessionsInsightsResource>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Insights.Index Insights()
        {
            return new Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Insights.Index(this);
        }
    }
}