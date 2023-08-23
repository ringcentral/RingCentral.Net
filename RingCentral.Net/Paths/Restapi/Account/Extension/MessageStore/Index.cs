using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public class Index
    {
        public string messageId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string messageId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.messageId = messageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && messageId != null) return $"{parent.Path()}/message-store/{messageId}";
            return $"{parent.Path()}/message-store";
        }

        /// <summary>
        ///     Returns a list of messages from an extension mailbox.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store
        ///     Rate Limit Group: Light
        ///     App Permission: ReadMessages
        ///     User Permission: ReadMessages
        /// </summary>
        public async Task<GetMessageList> List(ListMessagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetMessageList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes conversation(s) by conversation ID(s). Batch request is
        ///     supported, max number of IDs passed as query/path parameters is 50. Alternative
        ///     syntax is supported - user conversations can be deleted by passing multiple
        ///     IDs in request body as an array of string, max number of conversation IDs
        ///     passed in request body is 100. In this case asterisk is used in the path instead
        ///     of IDs
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store
        ///     Rate Limit Group: Medium
        ///     App Permission: EditMessages
        ///     User Permission: EditMessages
        /// </summary>
        public async Task<string> DeleteAll(DeleteMessageByFilterParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns an individual message record or multiple records by the given message ID(s).
        ///     The length of inbound messages is unlimited. Bulk syntax is supported.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadMessages
        ///     User Permission: ReadMessages
        /// </summary>
        public async Task<GetMessageInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (messageId == null) throw new ArgumentException("Parameter cannot be null", nameof(messageId));
            return await rc.Get<GetMessageInfoResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates message(s) by their ID(s). Currently only message read status
        ///     can be updated through this method.
        ///     Bulk syntax is supported, max number of IDs passed as query/path
        ///     parameters is 50. Alternative bulk syntax is also supported - user messages can be updated
        ///     by passing multiple IDs in request body as an array of string, max number
        ///     of IDs passed in the body is 1000. In this case asterisk is used in the
        ///     path instead of IDs.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditMessages
        ///     User Permission: EditMessages
        /// </summary>
        public async Task<GetMessageInfoResponse> Put(UpdateMessageRequest updateMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (messageId == null) throw new ArgumentException("Parameter cannot be null", nameof(messageId));
            return await rc.Put<GetMessageInfoResponse>(Path(), updateMessageRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes message(s) by the given message ID(s). The first call of
        ///     this method transfers the message to the 'Delete' status. The second call
        ///     transfers the deleted message to the 'Purged' status. If it is required to
        ///     make the message 'Purged' immediately (from the first call), then set the
        ///     query parameter purge to `true`.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditMessages
        ///     User Permission: EditMessages
        /// </summary>
        public async Task<string> Delete(string[] deleteMessageBulkRequest, DeleteMessageParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (messageId == null) throw new ArgumentException("Parameter cannot be null", nameof(messageId));
            return await rc.Delete<string>(Path(), deleteMessageBulkRequest, queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Patches message(s) by ID(s). Currently only message read status update and
        ///     restoring deleted messages are supported through this method.
        ///     For changing status of a message send `readStatus` set to either 'Read' or 'Unread' in request.
        ///     It is possible to restore a message and its attachments (if message status is 'Deleted') by sending
        ///     `availability` attribute set to 'Alive' in request body. If a message is already in 'Purged' state
        ///     then its attachments cannot be restored and the message itself is about to be physically deleted.
        ///     Bulk syntax (both traditional and alternative one) is supported.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditMessages
        ///     User Permission: EditMessages
        /// </summary>
        public async Task<GetMessageInfoResponse> Patch(PatchMessageRequest patchMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (messageId == null) throw new ArgumentException("Parameter cannot be null", nameof(messageId));
            return await rc.Patch<GetMessageInfoResponse>(Path(), patchMessageRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public MessageStore.Index MessageStore(string messageId = null)
        {
            return new MessageStore.Index(this, messageId);
        }
    }
}