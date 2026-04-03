using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records.Insights
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Ringsense.V1.Public.Accounts.Domains.Records.Index parent;
        public Index(Ai.Ringsense.V1.Public.Accounts.Domains.Records.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/insights";
        }
        /// <summary>
        /// Returns the insights of a call recording
        /// HTTP Method: get
        /// Endpoint: /ai/ringsense/v1/public/accounts/{accountId}/domains/{domain}/records/{sourceRecordId}/insights
        /// Rate Limit Group: Light
        /// App Permission: RingSense
        /// </summary>
        public async Task<RingCentral.RecordingInsights> Get(RingCentral.GetRecordingInsightsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RecordingInsights>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records
{
    public partial class Index
    {
        public Ai.Ringsense.V1.Public.Accounts.Domains.Records.Insights.Index Insights()
        {
            return new Ai.Ringsense.V1.Public.Accounts.Domains.Records.Insights.Index(this);
        }
    }
}