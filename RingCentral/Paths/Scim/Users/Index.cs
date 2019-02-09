using System;
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

        public async Task<UserSearchResponse> List()
        {
            return await rc.Get<UserSearchResponse>(this.Path());
        }

        public async Task<UserResponse> Get()
        {
            if (this.id == null)
            {
                throw new ArgumentNullException("id");
            }

            return await rc.Get<UserResponse>(this.Path());
        }

        public async Task<UserResponse> Post(User user)
        {
            return await rc.Post<UserResponse>(this.Path(), user);
        }

        public async Task<UserResponse> Put(User user)
        {
            return await rc.Put<UserResponse>(this.Path(), user);
        }

        public async Task<UserResponse> Patch(UserPatch userPatch)
        {
            return await rc.Put<UserResponse>(this.Path(), userPatch);
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