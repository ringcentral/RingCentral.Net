using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation.Fetch
{
    public partial class Index
    {
        public RestClient rc;
        public Analytics.Calls.V1.Accounts.Aggregation.Index parent;
        public Index(Analytics.Calls.V1.Accounts.Aggregation.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/fetch";
        }
        /// <summary>
        /// Returns call aggregations filtered by parameters specified
        /// HTTP Method: post
        /// Endpoint: /analytics/calls/v1/accounts/{accountId}/aggregation/fetch
        /// Rate Limit Group: Light
        /// App Permission: Analytics
        /// </summary>
        public async Task<RingCentral.AggregationResponse> Post(RingCentral.AggregationRequest aggregationRequest, RingCentral.AnalyticsCallsAggregationFetchParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.AggregationResponse>(this.Path(), aggregationRequest, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Aggregation
{
    public partial class Index
    {
        public Analytics.Calls.V1.Accounts.Aggregation.Fetch.Index Fetch()
        {
            return new Analytics.Calls.V1.Accounts.Aggregation.Fetch.Index(this);
        }
    }
}