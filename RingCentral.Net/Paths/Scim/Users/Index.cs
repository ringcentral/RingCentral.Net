using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public string id;
        public Scim.Index parent;
        public RestClient rc;

        public Index(Scim.Index parent, string id = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.id = id;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && id != null) return $"{parent.Path()}/Users/{id}";
            return $"{parent.Path()}/Users";
        }

        /// <summary>
        ///     Search/List Users
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Users
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<UserSearchResponse> List(SearchViaGet2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserSearchResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Create User
        ///     HTTP Method: post
        ///     Endpoint: /scim/{version}/Users
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<UserResponse> Post(CreateUser createUser, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<UserResponse>(Path(false), createUser, null, restRequestConfig);
        }

        /// <summary>
        ///     Get User
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Users/{id}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<UserResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Update/Replace User
        ///     HTTP Method: put
        ///     Endpoint: /scim/{version}/Users/{id}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<UserResponse> Put(User user, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<UserResponse>(Path(), user, null, restRequestConfig);
        }

        /// <summary>
        ///     Delete User
        ///     HTTP Method: delete
        ///     Endpoint: /scim/{version}/Users/{id}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Update/Patch User
        ///     HTTP Method: patch
        ///     Endpoint: /scim/{version}/Users/{id}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<UserResponse> Patch(UserPatch userPatch, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<UserResponse>(Path(), userPatch, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Users.Index Users(string id = null)
        {
            return new Users.Index(this, id);
        }
    }
}