using System.Threading.Tasks;

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

        // Operation: syncAddressBook
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync
        public async Task<RingCentral.AddressBookSync> Get(SyncAddressBookParameters queryParams = null)
        {
            return await rc.Get<RingCentral.AddressBookSync>(this.Path(), queryParams);
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