using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Index parent;
public string roleId;
public Index(Restapi.Account.Index parent, string roleId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.roleId = roleId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && roleId != null)
            {
                return $"{parent.Path()}/user-role/{roleId}";
            }
            return $"{parent.Path()}/user-role";
        }
        /// <summary>
        /// Returns the list of account user roles.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserRoles
        /// </summary>
  public async Task<RingCentral.RolesCollectionResource> List(RingCentral.ListUserRolesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.RolesCollectionResource>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates custom user role.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
  public async Task<string> Post(RingCentral.RoleResource roleResource, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(false), roleResource, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a user role on the current account by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserRoles
        /// </summary>
  public async Task<RingCentral.RoleResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (roleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
    }return await rc.Get<RingCentral.RoleResource>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates a user role on the current account by ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
  public async Task<string> Put(RingCentral.RoleResource roleResource, RestRequestConfig restRequestConfig = null)
  {
if (roleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
    }return await rc.Put<string>(this.Path(), roleResource, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes custom user role by ID.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
  public async Task<string> Delete(RingCentral.DeleteCustomRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (roleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
    }return await rc.Delete<string>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.UserRole.Index UserRole(string roleId = null)
        {
            return new Restapi.Account.UserRole.Index(this, roleId);
        }
    }
}