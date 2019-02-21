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

        public async Task<RingCentral.GetMessageList> List(ListMessagesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GetMessageList> List(object queryParams)
        {
            return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GetMessageInfoResponse> Get()
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Get<RingCentral.GetMessageInfoResponse>(this.Path());
        }

        public async Task<RingCentral.GetMessageInfoResponse> Put(RingCentral.UpdateMessageRequest updateMessageRequest)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest);
        }

        public async Task<RingCentral.GetMessageInfoResponse> Put(object updateMessageRequest)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest);
        }

        public async Task<string> Delete(DeleteMessageParameters queryParams = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Delete<string>(this.Path(), queryParams);
        }

        public async Task<string> Delete(object queryParams)
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