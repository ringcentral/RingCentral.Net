using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries.Search
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Directory.Entries.Index parent;

        public Index(Restapi.Account.Directory.Entries.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/search";
        }

        /// <summary>
        /// Returns contact information on corporate users of federated accounts according to the specified filtering and ordering.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/entries/search
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.DirectoryResource> Post(
            RingCentral.SearchDirectoryEntriesRequest searchDirectoryEntriesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.DirectoryResource>(this.Path(), searchDirectoryEntriesRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Search.Index Search()
        {
            return new Restapi.Account.Directory.Entries.Search.Index(this);
        }
    }
}