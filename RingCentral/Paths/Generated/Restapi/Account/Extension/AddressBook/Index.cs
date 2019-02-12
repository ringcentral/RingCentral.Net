namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook
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
            return $"{parent.Path()}/address-book";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AddressBook.Index AddressBook()
        {
            return new Restapi.Account.Extension.AddressBook.Index(this);
        }
    }
}