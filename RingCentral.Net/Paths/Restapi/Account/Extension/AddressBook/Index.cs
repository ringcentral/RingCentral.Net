namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook
{
    public partial class Index
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
            return $"{parent.Path()}/address-book";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AddressBook.Index AddressBook()
        {
            return new AddressBook.Index(this);
        }
    }
}