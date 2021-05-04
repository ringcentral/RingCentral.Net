using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Conversations
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string chatId;

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
        /// Returns the list of conversations where the user is a member. All records in response are sorted by creation time of a conversation in ascending order. Conversation is a chat of the *Group* type.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/conversations
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationsList> List(
            RingCentral.ListGlipConversationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipConversationsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new conversation or opens the existing one. If the conversation already exists, then its ID will be returned in response. A conversation is an adhoc discussion between a particular set of users, not featuring any specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation (group), it creates a whole new conversation.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/conversations
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Post(
            RingCentral.CreateGlipConversationRequest createGlipConversationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipConversationInfo>(this.Path(false), createGlipConversationRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns information about the specified conversation, including the list of conversation participants. A conversation is an adhoc discussion between a particular set of users, not featuring any specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation, it creates a whole new conversation.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/conversations/{chatId}
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(chatId));
            }

            return await rc.Get<RingCentral.GlipConversationInfo>(this.Path(), null, restRequestConfig);
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