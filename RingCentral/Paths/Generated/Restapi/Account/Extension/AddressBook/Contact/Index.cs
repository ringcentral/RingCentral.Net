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

        public class ListQueryParams
        {
            // If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
            public string startsWith;

            // Sorts results by the specified property
            public string sortBy;

            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            public string phoneNumber;
        }

        public async Task<RingCentral.ContactList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.ContactList>(this.Path(false), queryParams);
        }

        public class PostQueryParams
        {
            // A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension
            public string dialingPlan;
        }

        public async Task<RingCentral.PersonalContactResource> Post(
            RingCentral.PersonalContactResource personalContactResource, PostQueryParams queryParams = null)
        {
            return await rc.Post<RingCentral.PersonalContactResource>(this.Path(false), personalContactResource,
                queryParams);
        }

        public async Task<RingCentral.PersonalContactResource> Get()
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Get<RingCentral.PersonalContactResource>(this.Path());
        }

        public class PutQueryParams
        {
            // A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension
            public string dialingPlan;
        }

        public async Task<RingCentral.PersonalContactResource> Put(
            RingCentral.PersonalContactResource personalContactResource, PutQueryParams queryParams = null)
        {
            if (this.contactId == null)
            {
                throw new System.ArgumentNullException("contactId");
            }

            return await rc.Put<RingCentral.PersonalContactResource>(this.Path(), personalContactResource, queryParams);
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