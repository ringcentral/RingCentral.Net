using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Favorite Contact List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite
        /// Rate Limit Group: Light
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.FavoriteContactList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.FavoriteContactList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Favorite Contact List
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite
        /// Rate Limit Group: Medium
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.FavoriteContactList> Put(RingCentral.FavoriteCollection favoriteCollection,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.FavoriteContactList>(this.Path(), favoriteCollection, null,
                restRequestConfig);
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