using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.AdaptiveCards
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
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/adaptive-cards
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipAdaptiveCardShortInfo> Post(GlipAdaptiveCardRequest glipAdaptiveCardRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipAdaptiveCardShortInfo>(Path(), glipAdaptiveCardRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public AdaptiveCards.Index AdaptiveCards()
        {
            return new AdaptiveCards.Index(this);
        }
    }
}