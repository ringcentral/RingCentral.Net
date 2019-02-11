using System.Threading.Tasks;


namespace RingCentral.Paths.Scim.Users.DotSearch
{
    public partial class Index
    {
        public Scim.Users.Index parent;
        public RestClient rc;

        public Index(Scim.Users.Index parent)
        {
            this.parent = parent;
            this.rc = this.parent.rc;
        }

        public string Path()
        {
            return this.parent.Path() + "/.search";
        }

        public async Task<UserSearchResponse> Post(SearchRequest searchRequest)
        {
            return await this.rc.Post<UserSearchResponse>(this.Path(), searchRequest);
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