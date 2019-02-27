using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Favorite
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/favorite";
        }

        // Operation: listFavoriteContacts
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite
        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
        }

        // Operation: updateFavoriteContactList
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite
        public async Task<string> Put(RingCentral.FavoriteCollection favoriteCollection)
        {
            return await rc.Put<string>(this.Path(), favoriteCollection);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Favorite.Index Favorite()
        {
            return new Restapi.Account.Extension.Favorite.Index(this);
        }
    }
}