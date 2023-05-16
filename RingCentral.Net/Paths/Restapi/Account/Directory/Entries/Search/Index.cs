using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries.Search
{
    public class Index
    {
        public Entries.Index parent;
        public RestClient rc;

        public Index(Entries.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/search";
        }

        /// <summary>
        ///     Returns contact information on corporate users of federated accounts according to the specified filtering and
        ///     ordering.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/directory/entries/search
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<DirectoryResource> Post(SearchDirectoryEntriesRequest searchDirectoryEntriesRequest,
            SearchDirectoryEntriesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<DirectoryResource>(Path(), searchDirectoryEntriesRequest, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public Search.Index Search()
        {
            return new Search.Index(this);
        }
    }
}