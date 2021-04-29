using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBookSync
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
            return $"{parent.Path()}/address-book-sync";
        }

        /// <summary>
        /// Synchronizes user contacts.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book-sync
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.AddressBookSync> Get(RingCentral.SyncAddressBookParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AddressBookSync>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AddressBookSync.Index AddressBookSync()
        {
            return new Restapi.Account.Extension.AddressBookSync.Index(this);
        }
    }
}