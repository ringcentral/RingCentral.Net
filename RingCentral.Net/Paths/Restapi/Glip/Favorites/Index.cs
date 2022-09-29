using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Favorites
{
    public class Index
    {
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorites";
        }

        /// <summary>
        ///     Returns a list of the current user's favorite chats.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/favorites
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipChatsListWithoutNavigation> Get(ListFavoriteChatsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipChatsListWithoutNavigation>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Favorites.Index Favorites()
        {
            return new Favorites.Index(this);
        }
    }
}