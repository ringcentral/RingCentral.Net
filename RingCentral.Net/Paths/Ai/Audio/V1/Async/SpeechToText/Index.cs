using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Audio.V1.Async.SpeechToText
{
    public partial class Index
    {
        public RestClient rc;
public Ai.Audio.V1.Async.Index parent;
public Index(Ai.Audio.V1.Async.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/speech-to-text";
        }
        /// <summary>
        /// Returns Speech to Text Conversion to the provided webhook URI.
        /// HTTP Method: post
        /// Endpoint: /ai/audio/v1/async/speech-to-text
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
  public async Task<RingCentral.CaiAsyncApiResponse> Post(RingCentral.AsrInput asrInput, RingCentral.CaiSpeechToTextParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.CaiAsyncApiResponse>(this.Path(), asrInput, queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public Ai.Audio.V1.Async.SpeechToText.Index SpeechToText()
        {
            return new Ai.Audio.V1.Async.SpeechToText.Index(this);
        }
    }
}