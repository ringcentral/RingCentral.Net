using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Conversations
{
    public class Index
    {
        public string chatId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null) return $"{parent.Path()}/conversations/{chatId}";

            return $"{parent.Path()}/conversations";
        }

        /// <summary>
        ///     Returns the list of conversations where the user is a member. All records in response are sorted by creation time
        ///     of a conversation in ascending order. Conversation is a chat of the *Group* type.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/conversations
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipConversationsList> List(
            ListGlipConversationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipConversationsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new conversation or opens the existing one. If the conversation already exists, then its ID will be
        ///     returned in response. A conversation is an adhoc discussion between a particular set of users, not featuring any
        ///     specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation
        ///     (group), it creates a whole new conversation.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/conversations
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipConversationInfo> Post(
            CreateGlipConversationRequest createGlipConversationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipConversationInfo>(Path(false), createGlipConversationRequest,
                null, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified conversation, including the list of conversation participants. A
        ///     conversation is an adhoc discussion between a particular set of users, not featuring any specific name or
        ///     description; it is a chat of 'Group' type. If you add a person to the existing conversation, it creates a whole new
        ///     conversation.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/conversations/{chatId}
        ///     Rate Limit Group: Light
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipConversationInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipConversationInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Conversations.Index Conversations(string chatId = null)
        {
            return new Conversations.Index(this, chatId);
        }
    }
}