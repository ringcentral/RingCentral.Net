using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Conversations
{
    public class Index
    {
        public string chatId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string chatId = null)
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
        ///     Endpoint: /team-messaging/v1/conversations
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMConversationList> List(ListGlipConversationsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMConversationList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new conversation or opens the existing one. If the conversation already exists, then its ID will be
        ///     returned in response. A conversation is an adhoc discussion between a particular set of users, not featuring any
        ///     specific name or description; it is a chat of 'Group' type. If you add a person to the existing conversation
        ///     (group), it creates a whole new conversation.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/conversations
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMConversationInfo> Post(CreateConversationRequest createConversationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMConversationInfo>(Path(false), createConversationRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified conversation, including the list of conversation participants. A
        ///     conversation is an adhoc discussion between a particular set of users, not featuring any specific name or
        ///     description; it is a chat of 'Group' type. If you add a person to the existing conversation, it creates a whole new
        ///     conversation.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/conversations/{chatId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMConversationInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));
            return await rc.Get<TMConversationInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Conversations.Index Conversations(string chatId = null)
        {
            return new Conversations.Index(this, chatId);
        }
    }
}