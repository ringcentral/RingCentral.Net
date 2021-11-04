using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore.Content
{
    public class Index
    {
        public string attachmentId;
        public MessageStore.Index parent;
        public RestClient rc;

        public Index(MessageStore.Index parent, string attachmentId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.attachmentId = attachmentId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && attachmentId != null) return $"{parent.Path()}/content/{attachmentId}";

            return $"{parent.Path()}/content";
        }

        /// <summary>
        ///     Returns a specific message attachment data as media stream.
        ///     HTTP Method: get
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadMessages
        ///     User Permission: ReadMessageContent
        /// </summary>
        public async Task<byte[]> Get(ReadMessageContentParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (attachmentId == null) throw new ArgumentException("Parameter cannot be null", nameof(attachmentId));

            return await rc.Get<byte[]>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public Content.Index Content(string attachmentId = null)
        {
            return new Content.Index(this, attachmentId);
        }
    }
}