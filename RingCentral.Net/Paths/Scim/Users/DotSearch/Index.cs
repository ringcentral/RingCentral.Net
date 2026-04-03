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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/.search";
        }
        /// <summary>
        /// Returns the list of users satisfying search criteria
        /// HTTP Method: post
        /// Endpoint: /scim/{version}/Users/dotSearch
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.ScimUserSearchResponse> Post(RingCentral.ScimSearchRequest scimSearchRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ScimUserSearchResponse>(this.Path(), scimSearchRequest, null, restRequestConfig);
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