using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Insights.V1.Async.AnalyzeInteraction
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Insights.V1.Async.Index parent;
        public Index(Ai.Insights.V1.Async.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/analyze-interaction";
        }
        /// <summary>
        /// Returns multiple insights including summaries, key phrases, questions asked, and more in a single API call.
        /// 
        /// HTTP Method: post
        /// Endpoint: /ai/insights/v1/async/analyze-interaction
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
        public async Task<RingCentral.CaiAsyncApiResponse> Post(RingCentral.InteractionInput interactionInput, RingCentral.CaiAnalyzeInteractionParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CaiAsyncApiResponse>(this.Path(), interactionInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Insights.V1.Async
{
    public partial class Index
    {
        public Ai.Insights.V1.Async.AnalyzeInteraction.Index AnalyzeInteraction()
        {
            return new Ai.Insights.V1.Async.AnalyzeInteraction.Index(this);
        }
    }
}