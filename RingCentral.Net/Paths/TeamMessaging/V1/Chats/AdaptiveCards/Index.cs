using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.AdaptiveCards
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Chats.Index parent;
        public Index(TeamMessaging.V1.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/adaptive-cards";
        }
        /// <summary>
        /// Creates a new adaptive card in the chat specified in path.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/chats/{chatId}/adaptive-cards
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.AdaptiveCardShortInfo> Post(RingCentral.AdaptiveCardRequest adaptiveCardRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.AdaptiveCardShortInfo>(this.Path(), adaptiveCardRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.AdaptiveCards.Index AdaptiveCards()
        {
            return new TeamMessaging.V1.Chats.AdaptiveCards.Index(this);
        }
    }
}