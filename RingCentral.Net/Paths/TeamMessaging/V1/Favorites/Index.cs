using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Favorites
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public Index(TeamMessaging.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/favorites";
        }
        /// <summary>
        /// Returns a list of the current user's favorite chats.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/favorites
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMChatListWithoutNavigation> Get(RingCentral.ListFavoriteChatsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMChatListWithoutNavigation>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Favorites.Index Favorites()
        {
            return new TeamMessaging.V1.Favorites.Index(this);
        }
    }
}