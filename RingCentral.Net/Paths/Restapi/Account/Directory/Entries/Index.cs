using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Company Directory Entries
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/directory/entries
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DirectoryResource> List(ListDirectoryEntriesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.DirectoryResource>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Corporate Directory Entry
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/directory/entries/{entryId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.ContactResource> Get(CancellationToken? cancellationToken = null)
        {
            if (this.entryId == null)
            {
                throw new System.ArgumentNullException("entryId");
            }

            return await rc.Get<RingCentral.ContactResource>(this.Path(), null, cancellationToken);
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