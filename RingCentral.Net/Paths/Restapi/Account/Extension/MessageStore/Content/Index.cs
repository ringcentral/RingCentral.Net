using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore.Content
{
    public partial class Index
    {
        public RestClient rc;
        public string attachmentId;
        public Restapi.Account.Extension.MessageStore.Index parent;

        public Index(Restapi.Account.Extension.MessageStore.Index parent, string attachmentId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.attachmentId = attachmentId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && attachmentId != null)
            {
                return $"{parent.Path()}/content/{attachmentId}";
            }

            return $"{parent.Path()}/content";
        }

        /// <summary>
        /// Operation: Get Message Content
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadMessages
        /// User Permission: ReadMessageContent
        /// </summary>
        public async Task<byte[]> Get(ReadMessageContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.attachmentId == null)
            {
                throw new System.ArgumentNullException("attachmentId");
            }

            return await rc.Get<byte[]>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageStore.Content.Index Content(string attachmentId = null)
        {
            return new Restapi.Account.Extension.MessageStore.Content.Index(this, attachmentId);
        }
    }
}