using System.Threading.Tasks;
using System.Threading;

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

        public string Path()
        {
            return $"{parent.Path()}/mms";
        }

        /// <summary>
        /// Operation: Send MMS
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/mms
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// User Permission: OutboundSMS
        /// </summary>
        public async Task<RingCentral.GetSMSMessageInfoResponse> Post(RingCentral.CreateMMSMessage createMMSMessage,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createMMSMessage);
            return await rc.Post<RingCentral.GetSMSMessageInfoResponse>(this.Path(), multipartFormDataContent, null,
                restRequestConfig);
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