using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Messages
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageThreads.Index parent;
        public Index(Restapi.Account.MessageThreads.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/messages";
        }
        /// <summary>
        /// Returns a list of messages across one or more threads.
        /// All filters are applied as "AND" conditions.
        /// 
        /// The records are sorted by `creationTime` in ascending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/messages
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadMessageList> Get(RingCentral.MthListMessagesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ThreadMessageList>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates and sends a new message to one or more recipients.
        /// 
        /// The message is automatically attached to the thread specified in the `threadId` parameter. If `threadId`
        /// is omitted, it is routed to the matching thread based on the `from` and `to` phone numbers;
        /// a new thread is created automatically when no matching thread exists.
        /// 
        /// The endpoint accepts two request formats:
        /// - `application/json` - for text-only messages.
        /// - `multipart/form-data` - to send a message together with one or more binary attachments
        ///   (for MMS / rich messages). Put the message fields in the `metadata` part and each file in
        ///   an `attachments` part, as shown in the example below.
        /// 
        /// Note: a suggested attachment filename is optional; when needed, provide it via the `filename`
        /// field in the `Content-Disposition` header.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/messages
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadMessageModel> Post(RingCentral.MthSendMessageRequest mthSendMessageRequest, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(mthSendMessageRequest);
            return await rc.Post<RingCentral.ThreadMessageModel>(this.Path(), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes thread message(s).
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/messages
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<string> Delete(RingCentral.ThreadMessagesDeleteRequest threadMessagesDeleteRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), threadMessagesDeleteRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Messages.Index Messages()
        {
            return new Restapi.Account.MessageThreads.Messages.Index(this);
        }
    }
}