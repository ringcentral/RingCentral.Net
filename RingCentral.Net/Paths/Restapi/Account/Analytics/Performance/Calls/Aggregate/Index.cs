using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Analytics.Performance.Calls.Aggregate
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
        ///     Returns a call performance report aggregated by parameters specified.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/analytics/performance/calls/aggregate
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PerformanceCallsAggregatesResponse> Post(
            PerformanceCallsAggregatesRequest performanceCallsAggregatesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<PerformanceCallsAggregatesResponse>(Path(),
                performanceCallsAggregatesRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Analytics.Performance.Calls
{
    public partial class Index
    {
        public Aggregate.Index Aggregate()
        {
            return new Aggregate.Index(this);
        }
    }
}