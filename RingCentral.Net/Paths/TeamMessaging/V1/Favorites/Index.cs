using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Favorites
{
    public class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/favorites";
        }

        /// <summary>
        ///     Returns a list of the current user's favorite chats.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/favorites
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMChatListWithoutNavigation> Get(ListFavoriteChatsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMChatListWithoutNavigation>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Favorites.Index Favorites()
        {
            return new Favorites.Index(this);
        }
    }
}