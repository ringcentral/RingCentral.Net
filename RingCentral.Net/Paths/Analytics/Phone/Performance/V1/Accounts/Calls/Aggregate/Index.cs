using System.Threading.Tasks;

namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts.Calls.Aggregate
{
    public class Index
    {
        public Calls.Index parent;
        public RestClient rc;

        public Index(Calls.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/aggregate";
        }

        /// <summary>
        ///     Returns call performance aggregations filtered by parameters specified
        ///     HTTP Method: post
        ///     Endpoint: /analytics/phone/performance/v1/accounts/{accountId}/calls/aggregate
        ///     Rate Limit Group: Light
        ///     App Permission: Analytics
        /// </summary>
        public async Task<PerformanceCallsAggregatesResponse> Post(
            PerformanceCallsAggregatesRequest performanceCallsAggregatesRequest,
            AggregatePerformanceReportCallsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<PerformanceCallsAggregatesResponse>(Path(), performanceCallsAggregatesRequest,
                queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts.Calls
{
    public partial class Index
    {
        public Aggregate.Index Aggregate()
        {
            return new Aggregate.Index(this);
        }
    }
}