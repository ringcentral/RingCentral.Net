using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public RestClient rc;
        public string entryId;
        public Restapi.Account.Directory.Index parent;

        public Index(Restapi.Account.Directory.Index parent, string entryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.entryId = entryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && entryId != null)
            {
                return $"{parent.Path()}/entries/{entryId}";
            }

            return $"{parent.Path()}/entries";
        }

        /// <summary>
        /// Returns contact information on corporate users of federated accounts. Please note: 1. `User`, `DigitalUser`, `VirtualUser` and `FaxUser` types are returned as `User` type. 2. `ApplicationExtension` type is not returned. 3. Only extensions in `Enabled`, `Disabled` and `NotActivated` state are returned.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/directory/entries
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DirectoryResource> List(ListDirectoryEntriesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.DirectoryResource>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns contact information on a particular corporate user of a federated account.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/directory/entries/{entryId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ContactResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.entryId == null)
            {
                throw new System.ArgumentNullException("entryId");
            }

            return await rc.Get<RingCentral.ContactResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Index Entries(string entryId = null)
        {
            return new Restapi.Account.Directory.Entries.Index(this, entryId);
        }
    }
}