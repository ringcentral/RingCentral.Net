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

        // Operation: Get Contact List
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        public async Task<RingCentral.ContactList> List(ListContactsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams);
        }

        // Operation: Create Contact
        // Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactResource personalContactResource, CreateContactParameters queryParams = null)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactResource,
                queryParams);
        }

        // Operation: Get Contact(s)
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        public async Task<RingCentral.PersonalContactResource> Get()
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Get<RingCentral.PersonalContactResource>(this.Path());
        }

        // Operation: Update Contact(s)
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactResource personalContactResource, UpdateContactParameters queryParams = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactResource, queryParams);
        }

        // Operation: Delete Contact(s)
        // Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
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