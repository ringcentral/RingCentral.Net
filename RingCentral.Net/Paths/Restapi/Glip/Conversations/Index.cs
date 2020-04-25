using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Conversations
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/conversations/{chatId}";
            }

            return $"{parent.Path()}/conversations";
        }

        /// <summary>
        /// Operation: Get Conversations
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/conversations
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationsList> List(ListGlipConversationsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipConversationsList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create/Open Conversation
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/conversations
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Post(
            RingCentral.CreateGlipConversationRequest createGlipConversationRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipConversationInfo>(this.Path(false), createGlipConversationRequest,
                null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Conversation
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/conversations/{chatId}
        /// Rate Limit Group: Light
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipConversationInfo>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Conversations.Index Conversations(string chatId = null)
        {
            return new Restapi.Glip.Conversations.Index(this, chatId);
        }
    }
}