using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public RestClient rc;
        public string id;
        public Scim.Index parent;

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
        /// Operation: Search/List Users
        /// HTTP Method: GET
        /// Endpoint: /scim/v2/Users
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> List(SearchViaGet2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserSearchResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create User
        /// HTTP Method: POST
        /// Endpoint: /scim/v2/Users
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserResponse> Post(RingCentral.CreateUser createUser,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.UserResponse>(this.Path(false), createUser, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get User
        /// HTTP Method: GET
        /// Endpoint: /scim/v2/Users/{id}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Get<RingCentral.UserResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update/Replace User
        /// HTTP Method: PUT
        /// Endpoint: /scim/v2/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserResponse> Put(RingCentral.User user,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Put<RingCentral.UserResponse>(this.Path(), user, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete User
        /// HTTP Method: DELETE
        /// Endpoint: /scim/v2/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update/Patch User
        /// HTTP Method: PATCH
        /// Endpoint: /scim/v2/Users/{id}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserResponse> Patch(RingCentral.UserPatch userPatch,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

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