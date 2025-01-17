using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Metadata.MultichannelRecordings.Content
{
    public class Index
    {
        public MultichannelRecordings.Index parent;
        public RestClient rc;

        public Index(MultichannelRecordings.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        ///     Returns media content of a multichannel call recording
        ///     **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/metadata/multichannel-recordings/{metadataId}/content
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadCallRecording
        /// </summary>
        public async Task<string> Get(ReadMultichannelCallRecordingContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Metadata.MultichannelRecordings
{
    public partial class Index
    {
        public Content.Index Content()
        {
            return new Content.Index(this);
        }
    }
}