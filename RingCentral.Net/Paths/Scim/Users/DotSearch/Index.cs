using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Scim.Users.DotSearch
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Users.Index parent;

        public Index(Scim.Users.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/.search";
        }

        /// <summary>
        /// Operation: Search/List Users
        /// HTTP Method: POST
        /// Endpoint: /scim/v2/Users/.search
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> Post(RingCentral.SearchRequest searchRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.UserSearchResponse>(this.Path(), searchRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public Scim.Users.DotSearch.Index DotSearch()
        {
            return new Scim.Users.DotSearch.Index(this);
        }
    }
}