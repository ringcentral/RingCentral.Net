using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Text.V1.Async.Punctuate
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
            return $"{parent.Path()}/punctuate";
        }
        /// <summary>
        /// Returns Smart Punctuation to the provided webhook URI.
        /// HTTP Method: post
        /// Endpoint: /ai/text/v1/async/punctuate
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
        public async Task<RingCentral.CaiAsyncApiResponse> Post(RingCentral.PunctuateInput punctuateInput, RingCentral.CaiPunctuateParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CaiAsyncApiResponse>(this.Path(), punctuateInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Text.V1.Async
{
    public partial class Index
    {
        public Ai.Text.V1.Async.Punctuate.Index Punctuate()
        {
            return new Ai.Text.V1.Async.Punctuate.Index(this);
        }
    }
}