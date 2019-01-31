using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users
{
    public class Index
    {
        public Scim.Index parent;
        public RestClient rc;
        public string id;

        public Index(Scim.Index parent, string id = null)
        {
            this.parent = parent;
            this.rc = this.parent.rc;
            this.id = id;
        }

        public string Path()
        {
            if (this.id == null)
            {
                return $"{parent.Path()}/Users";
            }

            return $"{parent.Path()}/Users/{this.id}";
        }

        public async Task<UserSearchResponse> Get()
        {
            return await rc.Get<UserSearchResponse>(this.Path());
        }

        public async Task<UserResponse> Post(User user)
        {
            return await rc.Post<UserResponse>(this.Path(), user);
        }

        public async Task<string> Delete()
        {
            return await rc.Delete<string>(this.Path());
        }

        public DotSearch.Index DotSearch()
        {
            return new DotSearch.Index(this);
        }
    }
}