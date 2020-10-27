using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public RestClient rc;
        public string messageId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string messageId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.messageId = messageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && messageId != null)
            {
                return $"{parent.Path()}/message-store/{messageId}";
            }

            return $"{parent.Path()}/message-store";
        }

        /// <summary>
        /// Operation: Get Message List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store
        /// Rate Limit Group: Light
        /// App Permission: ReadMessages
        /// User Permission: ReadMessages
        /// </summary>
        public async Task<RingCentral.GetMessageList> List(ListMessagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Message
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Light
        /// App Permission: ReadMessages
        /// User Permission: ReadMessages
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Get<RingCentral.GetMessageInfoResponse>(this.Path(), null, restRequestConfig);
        }

        public async Task<BatchResponse<RingCentral.GetMessageInfoResponse>[]> BatchGet(
            RestRequestConfig restRequestConfig = null)
        {
            if (!this.Path().Contains(","))
            {
                throw new System.ArgumentException(
                    "In order to make a BatchGet, please specify multiple IDs delimited by ','");
            }

            return await rc.BatchGet<RingCentral.GetMessageInfoResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Message List
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Put(RingCentral.UpdateMessageRequest updateMessageRequest,
            UpdateMessageParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest, queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Message
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
        public async Task<string> Delete(DeleteMessageParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Delete<string>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageStore.Index MessageStore(string messageId = null)
        {
            return new Restapi.Account.Extension.MessageStore.Index(this, messageId);
        }
    }
}