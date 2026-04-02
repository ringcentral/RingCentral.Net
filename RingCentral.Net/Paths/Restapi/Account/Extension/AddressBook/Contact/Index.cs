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
        /// Returns the user personal contacts.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
  public async Task<RingCentral.ContactList> List(RingCentral.ListContactsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates the user personal contact.
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
  public async Task<RingCentral.PersonalContactResource> Post(RingCentral.PersonalContactRequest personalContactRequest, RingCentral.CreateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactRequest, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Returns the user personal contact(s).
/// [Bulk request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
  public async Task<RingCentral.PersonalContactResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (contactId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(contactId));
    }return await rc.Get<RingCentral.PersonalContactResource>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates the user personal contact(s) (full resource update).
/// [Bulk request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
/// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
  public async Task<RingCentral.PersonalContactResource> Put(RingCentral.PersonalContactRequest personalContactRequest, RingCentral.UpdateContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (contactId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(contactId));
    }return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactRequest, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Deletes the user personal contact(s).
/// [Bulk request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (contactId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(contactId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }

        /// <summary>
        /// Updates particular values of a personal contact attributes specified in request (partial resource update). Omitted attributes will remain unchanged.
/// If any attribute is passed in request body with the null value, then this attribute value will be removed.
/// 
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}
        /// Rate Limit Group: Heavy
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
  public async Task<RingCentral.PersonalContactResource> Patch(RingCentral.PersonalContactRequest personalContactRequest, RingCentral.PatchContactParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (contactId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(contactId));
    }return await rc.Patch<RingCentral.PersonalContactResource>(this.Path(), personalContactRequest, queryParams, restRequestConfig);
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