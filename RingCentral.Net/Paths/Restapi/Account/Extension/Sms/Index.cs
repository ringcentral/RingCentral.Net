using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Sms
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
            return $"{parent.Path()}/sms";
        }

        /// <summary>
        /// Operation: Send SMS
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/sms
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// User Permission: OutboundSMS
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Post(RingCentral.CreateSMSMessage createSMSMessage,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), createSMSMessage, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Sms.Index Sms()
        {
            return new Restapi.Account.Extension.Sms.Index(this);
        }
    }
}