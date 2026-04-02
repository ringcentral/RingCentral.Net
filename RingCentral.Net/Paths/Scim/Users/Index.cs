using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public RestClient rc;
public Scim.Index parent;
public string scimUserId;
public Index(Scim.Index parent, string scimUserId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.scimUserId = scimUserId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && scimUserId != null)
            {
                return $"{parent.Path()}/Users/{scimUserId}";
            }
            return $"{parent.Path()}/Users";
        }
        /// <summary>
        /// Returns the list of users satisfying search criteria
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Users
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.ScimUserSearchResponse> List(RingCentral.ScimSearchViaGet2Parameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.ScimUserSearchResponse>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a new user
        /// HTTP Method: post
        /// Endpoint: /scim/{version}/Users
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.ScimUserResponse> Post(RingCentral.ScimUser scimUser, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.ScimUserResponse>(this.Path(false), scimUser, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a user by ID
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Users/{scimUserId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.ScimUserResponse> Get(RestRequestConfig restRequestConfig = null)
  {
if (scimUserId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(scimUserId));
    }return await rc.Get<RingCentral.ScimUserResponse>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates a user
        /// HTTP Method: put
        /// Endpoint: /scim/{version}/Users/{scimUserId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.ScimUserResponse> Put(RingCentral.ScimUser scimUser, RestRequestConfig restRequestConfig = null)
  {
if (scimUserId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(scimUserId));
    }return await rc.Put<RingCentral.ScimUserResponse>(this.Path(), scimUser, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a user
        /// HTTP Method: delete
        /// Endpoint: /scim/{version}/Users/{scimUserId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (scimUserId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(scimUserId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }

        /// <summary>
        /// Updates a user (partial update)
        /// HTTP Method: patch
        /// Endpoint: /scim/{version}/Users/{scimUserId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.ScimUserResponse> Patch(RingCentral.ScimUserPatch scimUserPatch, RestRequestConfig restRequestConfig = null)
  {
if (scimUserId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(scimUserId));
    }return await rc.Patch<RingCentral.ScimUserResponse>(this.Path(), scimUserPatch, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Users.Index Users(string scimUserId = null)
        {
            return new Scim.Users.Index(this, scimUserId);
        }
    }
}