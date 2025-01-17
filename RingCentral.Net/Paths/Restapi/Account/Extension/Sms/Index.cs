using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Sms
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
            return $"{parent.Path()}/sms";
        }

        /// <summary>
        ///     Creates and sends a new text message or multiple messages. You can send SMS
        ///     messages simultaneously to different recipients up to 40 requests per minute;
        ///     this limitation is relevant for all client applications. Sending and receiving
        ///     SMS is available for Toll-Free Numbers within the USA. You can send up to
        ///     10 attachments in a single MMS message; the size of all attachments linked
        ///     is limited up to 1500000 bytes.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/sms
        ///     Rate Limit Group: Medium
        ///     App Permission: SMS
        ///     User Permission: OutboundSMS
        /// </summary>
        public async Task<GetSMSMessageInfoResponse> Post(CreateSMSMessage createSMSMessage,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createSMSMessage);
            return await rc.Post<GetSMSMessageInfoResponse>(Path(), multipartFormDataContent, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Sms.Index Sms()
        {
            return new Sms.Index(this);
        }
    }
}