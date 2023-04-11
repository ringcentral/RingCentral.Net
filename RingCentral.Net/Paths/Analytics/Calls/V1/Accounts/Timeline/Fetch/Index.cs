using System.Threading.Tasks;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Timeline.Fetch
{
    public class Index
    {
        public Timeline.Index parent;
        public RestClient rc;

        public Index(Timeline.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/fetch";
        }

        /// <summary>
        ///     Returns time-value data aggregations filtered by parameters specified
        ///     HTTP Method: post
        ///     Endpoint: /analytics/calls/v1/accounts/{accountId}/timeline/fetch
        ///     Rate Limit Group: Light
        ///     App Permission: Analytics
        /// </summary>
        public async Task<TimelineResponse> Post(TimelineRequest timelineRequest,
            AnalyticsCallsTimelineFetchParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TimelineResponse>(Path(), timelineRequest, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Timeline
{
    public partial class Index
    {
        public Fetch.Index Fetch()
        {
            return new Fetch.Index(this);
        }
    }
}