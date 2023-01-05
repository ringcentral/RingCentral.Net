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
        ///     Returns the list of users satisfying search criteria
        ///     HTTP Method: post
        ///     Endpoint: /scim/{version}/Users/dotSearch
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimUserSearchResponse> Post(ScimSearchRequest scimSearchRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ScimUserSearchResponse>(Path(), scimSearchRequest, null, restRequestConfig);
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