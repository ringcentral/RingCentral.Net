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
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store
        /// </summary>
        public async Task<RingCentral.GetMessageList> List(ListMessagesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Message(s)
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Get()
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Get<RingCentral.GetMessageInfoResponse>(this.Path());
        }

        /// <summary>
        /// Operation: Update Message(s)
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Put(RingCentral.UpdateMessageRequest updateMessageRequest)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest);
        }

        /// <summary>
        /// Operation: Delete Message(s)
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}
        /// </summary>
        public async Task<string> Delete(DeleteMessageParameters queryParams = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Delete<string>(this.Path(), queryParams);
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