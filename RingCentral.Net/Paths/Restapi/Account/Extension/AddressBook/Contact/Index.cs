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

        /// <summary>
        /// Operation: Get Contact List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.ContactList> List(ListContactsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Contact
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactRequest personalContactRequest, CreateContactParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactRequest,
                queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Contact
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Get<RingCentral.PersonalContactResource>(this.Path(), null, restRequestConfig);
        }

        public async Task<BatchResponse<RingCentral.PersonalContactResource>[]> BatchGet(
            RestRequestConfig restRequestConfig = null)
        {
            if (!this.Path().Contains(","))
            {
                throw new System.ArgumentException(
                    "In order to make a BatchGet, please specify multiple IDs delimited by ','");
            }

            return await rc.BatchGet<RingCentral.PersonalContactResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Contact
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactRequest personalContactRequest, UpdateContactParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactRequest, queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Contact
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

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