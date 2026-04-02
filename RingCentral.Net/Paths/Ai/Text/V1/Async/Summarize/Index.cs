using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Text.V1.Async.Summarize
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Text.V1.Async.Index parent;
public Index(Ai.Text.V1.Async.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/summarize";
        }
        /// <summary>
        /// Returns Conversational Summarization to the webhook URI for segmented transcript of audios
/// with start, end, speakerId, text(alphanumeric and punctuations).
/// 
        /// HTTP Method: post
        /// Endpoint: /ai/text/v1/async/summarize
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
  public async Task<RingCentral.CaiAsyncApiResponse> Post(RingCentral.SummaryInput summaryInput, RingCentral.CaiSummarizeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.CaiAsyncApiResponse>(this.Path(), summaryInput, queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Ai.Text.V1.Async
{
    public partial class Index
    {
        public Ai.Text.V1.Async.Summarize.Index Summarize()
        {
            return new Ai.Text.V1.Async.Summarize.Index(this);
        }
    }
}