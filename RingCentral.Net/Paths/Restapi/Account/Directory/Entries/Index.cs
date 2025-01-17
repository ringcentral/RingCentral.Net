using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public string entryId;
        public Directory.Index parent;
        public RestClient rc;

        public Index(Directory.Index parent, string entryId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.entryId = entryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && entryId != null) return $"{parent.Path()}/entries/{entryId}";

            return $"{parent.Path()}/entries";
        }

        /// <summary>
        ///     Returns contact information on corporate users of federated accounts. Please note: 1. `User`, `DigitalUser`,
        ///     `VirtualUser` and `FaxUser` types are returned as `User` type. 2. `ApplicationExtension` type is not returned. 3.
        ///     Only extensions in `Enabled`, `Disabled` and `NotActivated` state are returned.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/entries
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<DirectoryResource> List(
            ListDirectoryEntriesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DirectoryResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns contact information on a particular corporate user of a federated account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/entries/{entryId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ContactResource> Get(ReadDirectoryEntryParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (entryId == null) throw new ArgumentException("Parameter cannot be null", nameof(entryId));

            return await rc.Get<ContactResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Entries.Index Entries(string entryId = null)
        {
            return new Entries.Index(this, entryId);
        }
    }
}