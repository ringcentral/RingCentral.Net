using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Recording.Content
{
    public class Index
    {
        public Recording.Index parent;
        public RestClient rc;

        public Index(Recording.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        ///     Returns media content of a call recording (`audio/mpeg` or `audio/wav`)
        ///     **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/recording/{recordingId}/content
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallRecording
        /// </summary>
        public async Task<byte[]> Get(ReadCallRecordingContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public Content.Index Content()
        {
            return new Content.Index(this);
        }
    }
}