using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records.Insights
{
    public class Index
    {
        public Records.Index parent;
        public RestClient rc;

        public Index(Records.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/insights";
        }

        /// <summary>
        ///     Returns the insights of a call recording
        ///     HTTP Method: get
        ///     Endpoint: /ai/ringsense/v1/public/accounts/{accountId}/domains/{domain}/records/{sourceRecordId}/insights
        ///     Rate Limit Group: Light
        ///     App Permission: RingSense
        /// </summary>
        public async Task<RecordingInsights> Get(GetRecordingInsightsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RecordingInsights>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1.Public.Accounts.Domains.Records
{
    public partial class Index
    {
        public Insights.Index Insights()
        {
            return new Insights.Index(this);
        }
    }
}