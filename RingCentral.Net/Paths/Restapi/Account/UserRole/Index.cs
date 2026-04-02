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
        /// Returns a list of account user roles.
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
        /// Creates a custom user role.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
  public async Task<string> Post(RingCentral.RoleResource roleResource, RingCentral.CreateCustomRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(false), roleResource, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Returns a user role assigned to the current account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserRoles
        /// </summary>
  public async Task<RingCentral.RoleResource> Get(RingCentral.ReadUserRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (roleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
    }return await rc.Get<RingCentral.RoleResource>(this.Path(), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Updates a user role assigned to the current account by ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
  public async Task<RingCentral.RoleResource> Put(RingCentral.RoleResource roleResource, RingCentral.UpdateUserRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (roleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
    }return await rc.Put<RingCentral.RoleResource>(this.Path(), roleResource, queryParams, restRequestConfig);
  }

        /// <summary>
        /// Deletes a custom user role by ID.
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
    }return await rc.Delete<string>(this.Path(), null, queryParams, restRequestConfig);
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