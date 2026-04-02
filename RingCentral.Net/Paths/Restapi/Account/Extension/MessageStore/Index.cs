using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Extension.Index parent;
public string messageId;
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
        /// Returns a list of messages from an extension mailbox.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store
        /// Rate Limit Group: Light
        /// App Permission: ReadMessages
        /// User Permission: ReadMessages
        /// </summary>
  public async Task<RingCentral.GetMessageList> List(RingCentral.ListMessagesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Deletes conversation(s) by conversation ID(s).
/// [Bulk request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported - maximum number
/// of IDs passed as query/path parameters is 50. Alternative syntax is supported - the user's conversations can be deleted
/// by passing multiple IDs in request body as an array of string. Maximum number of conversation IDs passed in request body
/// is 100. In this case asterisk '*' is used in the path instead of IDs.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
  public async Task<string> DeleteAll(RingCentral.DeleteMessageByFilterParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Delete<string>(this.Path(false), null, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Returns an individual message record or multiple records by the given message ID(s).
/// The length of inbound messages is unlimited. [Bulk syntax](https://developers.ringcentral.com/guide/basics/batch-requests)
/// is supported.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Light
        /// App Permission: ReadMessages
        /// User Permission: ReadMessages
        /// </summary>
  public async Task<RingCentral.GetSingleMessageInfoResponse> Get(RestRequestConfig restRequestConfig = null)
  {
if (messageId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(messageId));
    }return await rc.Get<RingCentral.GetSingleMessageInfoResponse>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates message(s) by their ID(s). Currently, only the `readStatus`
/// can be updated using this method.
/// [Bulk syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported,
/// maximum number of IDs passed as query/path parameters is 50. Alternative bulk syntax is also
/// supported - the user's messages can be updated by passing multiple IDs in request body as
/// an array of string, maximum number of IDs passed in the body is 1000. In this case asterisk '*'
/// is used in the path instead of IDs.
/// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
  public async Task<RingCentral.GetMessageInfoResponse> Put(RingCentral.UpdateMessageRequest updateMessageRequest, RestRequestConfig restRequestConfig = null)
  {
if (messageId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(messageId));
    }return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes message(s) by the given message ID(s). The first call of
/// this method transfers the message to the 'Delete' status. The second call
/// moves the deleted message to the 'Purged' status. 
/// To immediately purge the message (skip the 'Deleted' status), 
/// set the query parameter `purge` to `true`.
/// 
/// **Please note: If you call this method without specifying any message IDs in the request, 
/// all your messages will be deleted/purged entirely.**
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
  public async Task<string> Delete(string[] deleteMessageBulkRequest, RingCentral.DeleteMessageParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (messageId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(messageId));
    }return await rc.Delete<string>(this.Path(), deleteMessageBulkRequest, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Patches message(s) by ID(s). Currently, only updating the `readStatus` and
/// restoring deleted messages are supported through this method.
/// 
/// For changing status of a message send `readStatus` set to either 'Read' or 'Unread' in request.
/// It is possible to restore a message and its attachments (if message status is 'Deleted') by sending
/// `availability` attribute set to 'Alive' in request body. If a message is already in 'Purged' state
/// then its attachments cannot be restored and the message itself is about to be physically deleted.
/// 
/// Bulk syntax (both traditional and alternative one) is supported.
/// 
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// Rate Limit Group: Medium
        /// App Permission: EditMessages
        /// User Permission: EditMessages
        /// </summary>
  public async Task<RingCentral.GetMessageInfoResponse> Patch(RingCentral.PatchMessageRequest patchMessageRequest, RestRequestConfig restRequestConfig = null)
  {
if (messageId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(messageId));
    }return await rc.Patch<RingCentral.GetMessageInfoResponse>(this.Path(), patchMessageRequest, null, restRequestConfig);
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