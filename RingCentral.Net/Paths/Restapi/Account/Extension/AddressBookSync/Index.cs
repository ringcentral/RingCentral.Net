using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBookSync
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

        public string Path()
        {
            return $"{parent.Path()}/address-book-sync";
        }

        /// <summary>
        ///     Synchronizes user contacts.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book-sync
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadContacts
        ///     User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.AddressBookSync> Get(SyncAddressBookParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AddressBookSync>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AddressBookSync.Index AddressBookSync()
        {
            return new AddressBookSync.Index(this);
        }
    }
}