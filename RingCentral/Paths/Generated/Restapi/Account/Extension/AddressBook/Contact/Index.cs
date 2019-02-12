using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook.Contact
{
    public partial class Index
    {
        public RestClient rc;
        public string contactId;
        public Restapi.Account.Extension.AddressBook.Index parent;

        public Index(Restapi.Account.Extension.AddressBook.Index parent, string contactId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.contactId = contactId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && contactId != null)
            {
                return $"{parent.Path()}/contact/{contactId}";
            }

            return $"{parent.Path()}/contact";
        }

        public async Task<RingCentral.ContactList> List()
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false));
        }

        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactResource personalContactResource)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactResource);
        }

        public async Task<RingCentral.PersonalContactResource> Get()
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Get<RingCentral.PersonalContactResource>(this.Path());
        }

        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactResource personalContactResource)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactResource);
        }

        public async Task<string> Delete()
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook
{
    public partial class Index
    {
        public Restapi.Account.Extension.AddressBook.Contact.Index Contact(string contactId = null)
        {
            return new Restapi.Account.Extension.AddressBook.Contact.Index(this, contactId);
        }
    }
}