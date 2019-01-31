using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users.DotSearch
{
    public class Index
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