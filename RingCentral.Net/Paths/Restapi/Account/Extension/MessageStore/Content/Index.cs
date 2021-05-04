using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore.Content
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.MessageStore.Index parent;
        public string attachmentId;

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
        /// Returns a specific message attachment data as media stream.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadMessages
        /// User Permission: ReadMessageContent
        /// </summary>
        public async Task<byte[]> Get(RingCentral.ReadMessageContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (attachmentId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(attachmentId));
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