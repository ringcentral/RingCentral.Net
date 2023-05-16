using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Mms
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/mms";
        }

        /// <summary>
        ///     Creates and sends a new media message or multiple messages. Sending MMS
        ///     messages simultaneously to different recipients is limited up to 50
        ///     requests per minute; relevant for all client applications.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/mms
        ///     Rate Limit Group: Medium
        ///     App Permission: SMS
        ///     User Permission: OutboundSMS
        /// </summary>
        public async Task<GetSMSMessageInfoResponse> Post(CreateMMSMessage createMMSMessage,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createMMSMessage);
            return await rc.Post<GetSMSMessageInfoResponse>(Path(), multipartFormDataContent, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Mms.Index Mms()
        {
            return new Mms.Index(this);
        }
    }
}