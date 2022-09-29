using System.Threading.Tasks;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation.Fetch
{
    public class Index
    {
        public Aggregation.Index parent;
        public RestClient rc;

        public Index(Aggregation.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/fetch";
        }

        /// <summary>
        ///     Returns call aggregations filtered by parameters specified
        ///     HTTP Method: post
        ///     Endpoint: /analytics/calls/v1/accounts/{accountId}/aggregation/fetch
        ///     Rate Limit Group: Light
        ///     App Permission: Analytics
        /// </summary>
        public async Task<AggregationResponse> Post(AggregationRequest aggregationRequest,
            AnalyticsCallsAggregationFetchParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AggregationResponse>(Path(), aggregationRequest, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation
{
    public partial class Index
    {
        public Fetch.Index Fetch()
        {
            return new Fetch.Index(this);
        }
    }
}