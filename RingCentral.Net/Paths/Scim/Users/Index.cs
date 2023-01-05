using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public Scim.Index parent;
        public RestClient rc;
        public string scimUserId;

        public Index(Scim.Index parent, string scimUserId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.scimUserId = scimUserId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && scimUserId != null) return $"{parent.Path()}/Users/{scimUserId}";
            return $"{parent.Path()}/Users";
        }

        /// <summary>
        ///     Returns the list of users satisfying search criteria
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Users
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimUserSearchResponse> List(ScimSearchViaGet2Parameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ScimUserSearchResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new user
        ///     HTTP Method: post
        ///     Endpoint: /scim/{version}/Users
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<ScimUserResponse> Post(ScimUser scimUser, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ScimUserResponse>(Path(false), scimUser, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a user by ID
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Users/{scimUserId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimUserResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (scimUserId == null) throw new ArgumentException("Parameter cannot be null", nameof(scimUserId));
            return await rc.Get<ScimUserResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a user
        ///     HTTP Method: put
        ///     Endpoint: /scim/{version}/Users/{scimUserId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<ScimUserResponse> Put(ScimUser scimUser, RestRequestConfig restRequestConfig = null)
        {
            if (scimUserId == null) throw new ArgumentException("Parameter cannot be null", nameof(scimUserId));
            return await rc.Put<ScimUserResponse>(Path(), scimUser, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a user
        ///     HTTP Method: delete
        ///     Endpoint: /scim/{version}/Users/{scimUserId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (scimUserId == null) throw new ArgumentException("Parameter cannot be null", nameof(scimUserId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a user (partial update)
        ///     HTTP Method: patch
        ///     Endpoint: /scim/{version}/Users/{scimUserId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<ScimUserResponse> Patch(ScimUserPatch scimUserPatch,
            RestRequestConfig restRequestConfig = null)
        {
            if (scimUserId == null) throw new ArgumentException("Parameter cannot be null", nameof(scimUserId));
            return await rc.Patch<ScimUserResponse>(Path(), scimUserPatch, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Users.Index Users(string scimUserId = null)
        {
            return new Users.Index(this, scimUserId);
        }
    }
}