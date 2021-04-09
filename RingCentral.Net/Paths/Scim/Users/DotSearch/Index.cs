using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users.DotSearch
{
    public class Index
    {
        public Users.Index parent;
        public RestClient rc;

        public Index(Users.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/.search";
        }

        /// <summary>
        ///     Search/List Users
        ///     HTTP Method: post
        ///     Endpoint: /scim/{version}/Users/dotSearch
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<UserSearchResponse> Post(SearchRequest searchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<UserSearchResponse>(Path(), searchRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public DotSearch.Index DotSearch()
        {
            return new DotSearch.Index(this);
        }
    }
}