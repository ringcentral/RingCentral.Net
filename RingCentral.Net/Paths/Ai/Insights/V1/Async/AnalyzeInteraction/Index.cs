using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Insights.V1.Async.AnalyzeInteraction
{
    public class Index
    {
        public Async.Index parent;
        public RestClient rc;

        public Index(Async.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/analyze-interaction";
        }

        /// <summary>
        ///     Returns multiple insights including summaries, emotion, key phrases, questions asked, and more in a single API
        ///     call.
        ///     HTTP Method: post
        ///     Endpoint: /ai/insights/v1/async/analyze-interaction
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(InteractionInput interactionInput,
            CaiAnalyzeInteractionParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), interactionInput, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Insights.V1.Async
{
    public partial class Index
    {
        public AnalyzeInteraction.Index AnalyzeInteraction()
        {
            return new AnalyzeInteraction.Index(this);
        }
    }
}