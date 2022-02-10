using System.Threading.Tasks;

namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts.Calls.Timeline
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
            return $"{parent.Path()}/timeline";
        }

        /// <summary>
        ///     Returns call performance data aggregated for specified time intervals.
        ///     HTTP Method: post
        ///     Endpoint: /analytics/phone/performance/v1/accounts/{accountId}/calls/timeline
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PerformanceCallsTimelineResponse> Post(
            PerformanceCallsTimelineRequest performanceCallsTimelineRequest,
            PerformanceReportCallsTimelineParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<PerformanceCallsTimelineResponse>(Path(), performanceCallsTimelineRequest, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Analytics.Phone.Performance.V1.Accounts.Calls
{
    public partial class Index
    {
        public Timeline.Index Timeline()
        {
            return new Timeline.Index(this);
        }
    }
}