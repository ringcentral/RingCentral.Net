using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Favorites
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorites";
        }

        // Operation: listFavoriteChats
        public async Task<RingCentral.GlipChatsListWithoutNavigation> Get(
            ListFavoriteChatsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipChatsListWithoutNavigation>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Favorites.Index Favorites()
        {
            return new Restapi.Glip.Favorites.Index(this);
        }
    }
}