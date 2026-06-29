using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Messages.Content
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageThreads.Messages.Index parent;
        public string attachmentId;
        public Index(Restapi.Account.MessageThreads.Messages.Index parent, string attachmentId = null)
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
        /// Returns media content of a rich message attachment.
        /// 
        /// See [Sending MMS](https://developers.ringcentral.com/guide/messaging/sms/sending-images) for the list of supported media types.
        /// 
        /// **This API must be called via media API entry point, e.g. https://media.ringcentral.com**
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/messages/{messageId}/content/{attachmentId}
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<byte[]> Get(RingCentral.MthReadMessageContentParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (attachmentId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(attachmentId));
            }
            return await rc.Get<byte[]>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Messages
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Messages.Content.Index Content(string attachmentId = null)
        {
            return new Restapi.Account.MessageThreads.Messages.Content.Index(this, attachmentId);
        }
    }
}