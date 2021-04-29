using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook.Contact
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.AddressBook.Index parent;
        public string contactId;

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
        /// Returns user personal contacts.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.ContactList> List(RingCentral.ListContactsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates personal user contact.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactRequest personalContactRequest,
            RingCentral.CreateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactRequest,
                queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns contact(s) by ID(s). Batch request is supported.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PersonalContactResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates personal contact information by contact ID(s). Batch request is supported
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactRequest personalContactRequest,
            RingCentral.UpdateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactRequest, queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes contact(s) by ID(s). Batch request is supported.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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