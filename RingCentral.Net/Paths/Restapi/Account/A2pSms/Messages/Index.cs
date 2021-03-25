using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.Messages
{
    public partial class Index
    {
        public RestClient rc;
        public string messageId;
        public Restapi.Account.A2pSms.Index parent;

        public Index(Restapi.Account.A2pSms.Index parent, string messageId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.messageId = messageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && messageId != null)
            {
                return $"{parent.Path()}/messages/{messageId}";
            }

            return $"{parent.Path()}/messages";
        }

        /// <summary>
        /// Returns the list of outbound/inbound A2P messages sent from/to A2P phone numbers of the current account. The list can be filtered by message batch ID and/or phone number.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/a2p-sms/messages
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.MessageListResponse> List(ListA2PSMSParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.MessageListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the details of an A2P SMS message by ID.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/a2p-sms/messages/{messageId}
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.MessageDetailsResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Get<RingCentral.MessageDetailsResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Restapi.Account.A2pSms.Messages.Index Messages(string messageId = null)
        {
            return new Restapi.Account.A2pSms.Messages.Index(this, messageId);
        }
    }
}