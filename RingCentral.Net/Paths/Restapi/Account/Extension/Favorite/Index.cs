using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Favorite
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/favorite";
        }

        /// <summary>
        ///     Returns the list of favorite contacts of the current extension.
        ///     Favorite contacts include both company contacts (extensions) and personal
        ///     contacts (address book records).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite
        ///     Rate Limit Group: Light
        ///     App Permission: ReadContacts
        ///     User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<FavoriteContactList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<FavoriteContactList>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the list of favorite contacts of the current extension.
        ///     Favorite contacts include both company contacts (extensions) and personal
        ///     contacts (address book records).**Please note**: Currently personal address
        ///     book size is limited to 10 000 contacts.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite
        ///     Rate Limit Group: Medium
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<FavoriteContactList> Put(FavoriteCollection favoriteCollection,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<FavoriteContactList>(Path(), favoriteCollection, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Favorite.Index Favorite()
        {
            return new Favorite.Index(this);
        }
    }
}