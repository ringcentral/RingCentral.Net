using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook.Contact
{
    public class Index
    {
        public string contactId;
        public AddressBook.Index parent;
        public RestClient rc;

        public Index(AddressBook.Index parent, string contactId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.contactId = contactId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && contactId != null) return $"{parent.Path()}/contact/{contactId}";
            return $"{parent.Path()}/contact";
        }

        /// <summary>
        ///     Returns the user personal contacts.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadContacts
        ///     User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<ContactList> List(ListContactsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ContactList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates the user personal contact.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        ///     Rate Limit Group: Heavy
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<PersonalContactResource> Post(PersonalContactRequest personalContactRequest,
            CreateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<PersonalContactResource>(Path(false), personalContactRequest, queryParams,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the user personal contact(s).
        ///     [Batch request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadContacts
        ///     User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<PersonalContactResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (contactId == null) throw new ArgumentException("Parameter cannot be null", nameof(contactId));
            return await rc.Get<PersonalContactResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the user personal contact(s) (full resource update).
        ///     [Batch request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<PersonalContactResource> Put(PersonalContactRequest personalContactRequest,
            UpdateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (contactId == null) throw new ArgumentException("Parameter cannot be null", nameof(contactId));
            return await rc.Put<PersonalContactResource>(Path(), personalContactRequest, queryParams,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes the user personal contact(s).
        ///     [Batch request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (contactId == null) throw new ArgumentException("Parameter cannot be null", nameof(contactId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates particular values of a personal contact attributes specified in request (partial resource update). Omitted
        ///     attributes will remain unchanged.
        ///     If any attribute is passed in request body with the null value, then this attribute value will be removed.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: Contacts
        ///     User Permission: EditPersonalContacts
        /// </summary>
        public async Task<PersonalContactResource> Patch(PersonalContactRequest personalContactRequest,
            PatchContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (contactId == null) throw new ArgumentException("Parameter cannot be null", nameof(contactId));
            return await rc.Patch<PersonalContactResource>(Path(), personalContactRequest, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBook
{
    public partial class Index
    {
        public Contact.Index Contact(string contactId = null)
        {
            return new Contact.Index(this, contactId);
        }
    }
}