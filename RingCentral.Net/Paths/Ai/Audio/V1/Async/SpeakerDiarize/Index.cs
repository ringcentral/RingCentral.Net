using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Audio.V1.Async.SpeakerDiarize
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
            return $"{parent.Path()}/speaker-diarize";
        }

        /// <summary>
        ///     Identifies who said what. Speaker diarization will identify the speaker for each segment
        ///     so you can tell who spoke the sentence, paragraph, or phrase.
        ///     HTTP Method: post
        ///     Endpoint: /ai/audio/v1/async/speaker-diarize
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(DiarizeInput diarizeInput,
            CaiSpeakerDiarizeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), diarizeInput, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public SpeakerDiarize.Index SpeakerDiarize()
        {
            return new SpeakerDiarize.Index(this);
        }
    }
}