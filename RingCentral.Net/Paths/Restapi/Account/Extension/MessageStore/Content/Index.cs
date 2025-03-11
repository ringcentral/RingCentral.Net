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
        ///     Returns media content of a message attachment.
        ///     The content is typically an audio file (`audio/mpeg` or `audio/wav`) for voicemails,
        ///     TIFF or PDF for faxes and image/audio/video for MMS.
        ///     **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        ///     HTTP Method: get
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadMessages
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