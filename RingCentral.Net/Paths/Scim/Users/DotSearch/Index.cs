using System.Threading.Tasks;

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
        /// Operation: Search or List Users
        /// Http Post /scim/v2/Users/.search
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> Post(RingCentral.SearchRequest searchRequest)
        {
            return await rc.Post<RingCentral.UserSearchResponse>(this.Path(), searchRequest);
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