using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Mms
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/mms";
        }
        /// <summary>
        /// Creates and sends a new media message or multiple messages. Sending MMS
        /// messages simultaneously to different recipients is limited up to 50
        /// requests per minute; relevant for all client applications.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/mms
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// User Permission: OutboundSMS
        /// </summary>
        public async Task<RingCentral.GetSMSMessageInfoResponse> Post(RingCentral.CreateMMSMessage createMMSMessage, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createMMSMessage);
            return await rc.Post<RingCentral.GetSMSMessageInfoResponse>(this.Path(), multipartFormDataContent, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Mms.Index Mms()
        {
            return new Restapi.Account.Extension.Mms.Index(this);
        }
    }
}