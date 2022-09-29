using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
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
            if (withParameter && chatId != null) return $"{parent.Path()}/chats/{chatId}";
            return $"{parent.Path()}/chats";
        }

        /// <summary>
        ///     Returns the list of chats where the user is a member and also public teams that can be joined.
        ///     All records in response are sorted by creation time of a chat in ascending order.
        ///     **Chat types**
        ///     There are multiple types of chats, including:
        ///     * **Personal** - each user is given a dedicated "personal chat" in which they are the only member.
        ///     * **Direct** - a chat between two individuals.
        ///     * **Group** - a chat between three or more named individuals. A "group" chat has no name.
        ///     * **Team** - a chat related to a specific topic. Members can come and go freely from this chat type.
        ///     * **Everyone** - a special chat containing every individual in a company.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipChatsList> List(ListGlipChatsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipChatsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about a chat by ID. **Note** 'Chat' is a general name for all types of threads including
        ///     *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific
        ///     name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all
        ///     employees, with a specific name)."
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipChatInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));
            return await rc.Get<GlipChatInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Chats.Index Chats(string chatId = null)
        {
            return new Chats.Index(this, chatId);
        }
    }
}