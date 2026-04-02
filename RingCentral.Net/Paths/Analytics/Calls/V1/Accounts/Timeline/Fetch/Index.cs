using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Timeline.Fetch
{
    public partial class Index
    {
        public RestClient rc;
public Analytics.Calls.V1.Accounts.Timeline.Index parent;
public Index(Analytics.Calls.V1.Accounts.Timeline.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/fetch";
        }
        /// <summary>
        /// Returns time-value data aggregations filtered by parameters specified
        /// HTTP Method: post
        /// Endpoint: /analytics/calls/v1/accounts/{accountId}/timeline/fetch
        /// Rate Limit Group: Light
        /// App Permission: Analytics
        /// </summary>
  public async Task<RingCentral.TimelineResponse> Post(RingCentral.TimelineRequest timelineRequest, RingCentral.AnalyticsCallsTimelineFetchParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.TimelineResponse>(this.Path(), timelineRequest, queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Analytics.Calls.V1.Accounts.Timeline
{
    public partial class Index
    {
        public Analytics.Calls.V1.Accounts.Timeline.Fetch.Index Fetch()
        {
            return new Analytics.Calls.V1.Accounts.Timeline.Fetch.Index(this);
        }
    }
}