using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions.Insights
{
    public class Index
    {
        public Sessions.Index parent;
        public RestClient rc;

        public Index(Sessions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/insights";
        }

        /// <summary>
        ///     Returns the insights of all call recordings in a session
        ///     HTTP Method: get
        ///     Endpoint: /ai/ringsense/v1/public/accounts/{accountId}/domains/{domain}/sessions/{sourceSessionId}/insights
        ///     Rate Limit Group: Light
        ///     App Permission: RingSense
        /// </summary>
        public async Task<GetSessionInsightsResponse> Get(GetSessionInsightsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetSessionInsightsResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Sessions
{
    public partial class Index
    {
        public Insights.Index Insights()
        {
            return new Insights.Index(this);
        }
    }
}