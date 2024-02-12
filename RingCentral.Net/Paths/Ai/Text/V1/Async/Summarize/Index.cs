using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Text.V1.Async.Summarize
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
            return $"{parent.Path()}/summarize";
        }

        /// <summary>
        ///     Returns Conversational Summarization to webhook uri for segmented transcript of audios with start,end,speakerId,
        ///     text(alphanumeric and punctuations).
        ///     HTTP Method: post
        ///     Endpoint: /ai/text/v1/async/summarize
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(SummaryInput summaryInput,
            CaiSummarizeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), summaryInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Text.V1.Async
{
    public partial class Index
    {
        public Summarize.Index Summarize()
        {
            return new Summarize.Index(this);
        }
    }
}