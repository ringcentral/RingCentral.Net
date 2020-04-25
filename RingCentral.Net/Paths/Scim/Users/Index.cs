using System.Threading.Tasks;
using System.Threading;

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
        /// Rate Limit Group: Light
        /// Http Get /scim/v2/Users
        /// </summary>
        public async Task<RingCentral.UserSearchResponse> List(SearchViaGet2Parameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.UserSearchResponse>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create User
        /// Rate Limit Group: Heavy
        /// Http Post /scim/v2/Users
        /// </summary>
        public async Task<RingCentral.UserResponse> Post(RingCentral.CreateUser createUser,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.UserResponse>(this.Path(false), createUser, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get User
        /// Rate Limit Group: Light
        /// Http Get /scim/v2/Users/{id}
        /// </summary>
        public async Task<RingCentral.UserResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Get<RingCentral.UserResponse>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update/Replace User
        /// Rate Limit Group: Heavy
        /// Http Put /scim/v2/Users/{id}
        /// </summary>
        public async Task<RingCentral.UserResponse> Put(RingCentral.User user,
            CancellationToken? cancellationToken = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Put<RingCentral.UserResponse>(this.Path(), user, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete User
        /// Rate Limit Group: Heavy
        /// Http Delete /scim/v2/Users/{id}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update/Patch User
        /// Rate Limit Group: Heavy
        /// Http Patch /scim/v2/Users/{id}
        /// </summary>
        public async Task<RingCentral.UserResponse> Patch(RingCentral.UserPatch userPatch,
            CancellationToken? cancellationToken = null)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Patch<RingCentral.UserResponse>(this.Path(), userPatch, null, cancellationToken);
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