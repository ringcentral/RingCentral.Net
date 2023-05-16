using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Audio.V1.Async.SpeakerIdentify
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
            return $"{parent.Path()}/speaker-identify";
        }

        /// <summary>
        ///     Returns Speaker Identification to the provided webhook uri.
        ///     HTTP Method: post
        ///     Endpoint: /ai/audio/v1/async/speaker-identify
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<CaiAsyncApiResponse> Post(IdentifyInput identifyInput,
            CaiSpeakerIdentifyParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CaiAsyncApiResponse>(Path(), identifyInput, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1.Async
{
    public partial class Index
    {
        public SpeakerIdentify.Index SpeakerIdentify()
        {
            return new SpeakerIdentify.Index(this);
        }
    }
}