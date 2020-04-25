using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Contact List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission Required: ReadContacts
        /// User Permission Required: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.ContactList> List(ListContactsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Contact
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission Required: Contacts
        /// User Permission Required: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactRequest personalContactRequest, CreateContactParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactRequest,
                queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Contact
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: ReadContacts
        /// User Permission Required: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Get(CancellationToken? cancellationToken = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Get<RingCentral.PersonalContactResource>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Contact
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: Contacts
        /// User Permission Required: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactRequest personalContactRequest, UpdateContactParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactRequest, queryParams,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Contact
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: Contacts
        /// User Permission Required: EditPersonalContacts
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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