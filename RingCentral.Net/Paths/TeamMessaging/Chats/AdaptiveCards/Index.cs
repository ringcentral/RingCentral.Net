using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Chats.AdaptiveCards
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/adaptive-cards";
        }

        /// <summary>
        ///     Creates a new adaptive card in the chat specified in path.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/chats/{chatId}/adaptive-cards
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<AdaptiveCardShortInfo> Post(AdaptiveCardRequest adaptiveCardRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<AdaptiveCardShortInfo>(Path(), adaptiveCardRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Chats
{
    public partial class Index
    {
        public AdaptiveCards.Index AdaptiveCards()
        {
            return new AdaptiveCards.Index(this);
        }
    }
}