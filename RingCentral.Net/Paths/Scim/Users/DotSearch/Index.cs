using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Search/List Users
        /// HTTP Method: post
        /// Endpoint: /scim/{version}/Users/dotSearch
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> Post(RingCentral.SearchRequest searchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.UserSearchResponse>(this.Path(), searchRequest, null, restRequestConfig);
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