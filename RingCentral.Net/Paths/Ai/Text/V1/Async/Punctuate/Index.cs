using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Text.V1.Async.Punctuate
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
            return $"{parent.Path()}/punctuate";
        }

        /// <summary>
        ///     Returns Smart Punctuation to the provided webhook URI.
        ///     HTTP Method: post
        ///     Endpoint: /ai/text/v1/async/punctuate
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(PunctuateInput punctuateInput,
            CaiPunctuateParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), punctuateInput, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Text.V1.Async
{
    public partial class Index
    {
        public Punctuate.Index Punctuate()
        {
            return new Punctuate.Index(this);
        }
    }
}