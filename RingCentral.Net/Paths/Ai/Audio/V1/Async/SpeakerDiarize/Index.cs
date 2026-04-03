using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Audio.V1.Async.SpeakerDiarize
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
            return $"{parent.Path()}/speaker-diarize";
        }
        /// <summary>
        /// Identifies who said what. Speaker diarization will identify the speaker for each segment
        /// so you can tell who spoke the sentence, paragraph, or phrase.
        /// 
        /// HTTP Method: post
        /// Endpoint: /ai/audio/v1/async/speaker-diarize
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
        public async Task<RingCentral.CaiAsyncApiResponse> Post(RingCentral.DiarizeInput diarizeInput, RingCentral.CaiSpeakerDiarizeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CaiAsyncApiResponse>(this.Path(), diarizeInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public Ai.Audio.V1.Async.SpeakerDiarize.Index SpeakerDiarize()
        {
            return new Ai.Audio.V1.Async.SpeakerDiarize.Index(this);
        }
    }
}