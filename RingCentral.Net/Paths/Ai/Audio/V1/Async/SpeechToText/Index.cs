using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Audio.V1.Async.SpeechToText
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
            return $"{parent.Path()}/speech-to-text";
        }

        /// <summary>
        ///     Returns Speech to Text Conversion to the provided webhook uri.
        ///     HTTP Method: post
        ///     Endpoint: /ai/audio/v1/async/speech-to-text
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(AsrInput asrInput, CaiSpeechToTextParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), asrInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public SpeechToText.Index SpeechToText()
        {
            return new SpeechToText.Index(this);
        }
    }
}