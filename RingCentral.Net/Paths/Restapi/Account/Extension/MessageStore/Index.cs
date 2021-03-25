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
        /// Returns the list of messages from an extension mailbox.
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
        /// Returns individual message record(s) by the given message ID(s). The length of inbound messages is unlimited. Batch request is supported.
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

        /// <summary>
        /// Updates message(s) by ID(s). Currently only message read status can be updated. Batch request is supported, max number of IDs passed as query/path parameters is 50. Alternative syntax is supported - user messages can be updated by passing multiple IDs in request body as an array of string, max number of IDs passed in request body is 1000. In this case asterisk is used in the path instead of IDs.
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
        /// Deletes message(s) by the given message ID(s). The first call of this method transfers the message to the 'Delete' status. The second call transfers the deleted message to the 'Purged' status. If it is required to make the message 'Purged' immediately (from the first call), then set the query parameter purge to 'True'.
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