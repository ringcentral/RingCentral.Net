using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Index parent;
        public string id;

        public Index(Scim.Index parent, string id = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.id = id;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && id != null)
            {
                return $"{parent.Path()}/Users/{id}";
            }

            return $"{parent.Path()}/Users";
        }

        /// <summary>
        /// Search/List Users
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Users
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> List(RingCentral.SearchViaGet2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserSearchResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Create User
        /// HTTP Method: post
        /// Endpoint: /scim/{version}/Users
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.UserResponse> Post(RingCentral.CreateUser createUser,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.UserResponse>(this.Path(false), createUser, null, restRequestConfig);
        }

        /// <summary>
        /// Get User
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Users/{id}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.UserResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Update/Replace User
        /// HTTP Method: put
        /// Endpoint: /scim/{version}/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.UserResponse> Put(RingCentral.User user,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.UserResponse>(this.Path(), user, null, restRequestConfig);
        }

        /// <summary>
        /// Delete User
        /// HTTP Method: delete
        /// Endpoint: /scim/{version}/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Update/Patch User
        /// HTTP Method: patch
        /// Endpoint: /scim/{version}/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
        public async Task<RingCentral.UserResponse> Patch(RingCentral.UserPatch userPatch,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.UserResponse>(this.Path(), userPatch, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Users.Index Users(string id = null)
        {
            return new Scim.Users.Index(this, id);
        }
    }
}