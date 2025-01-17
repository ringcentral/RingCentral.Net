using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string roleId;

        public Index(Account.Index parent, string roleId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.roleId = roleId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && roleId != null) return $"{parent.Path()}/user-role/{roleId}";

            return $"{parent.Path()}/user-role";
        }

        /// <summary>
        ///     Returns a list of account user roles.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserRoles
        /// </summary>
        public async Task<RolesCollectionResource> List(
            ListUserRolesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RolesCollectionResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a custom user role.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        ///     User Permission: EditUserRoles
        /// </summary>
        public async Task<string> Post(RoleResource roleResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(false), roleResource, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a user role assigned to the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserRoles
        /// </summary>
        public async Task<RoleResource> Get(ReadUserRoleParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (roleId == null) throw new ArgumentException("Parameter cannot be null", nameof(roleId));

            return await rc.Get<RoleResource>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates a user role assigned to the current account by ID.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        ///     User Permission: EditUserRoles
        /// </summary>
        public async Task<RoleResource> Put(RoleResource roleResource,
            RestRequestConfig restRequestConfig = null)
        {
            if (roleId == null) throw new ArgumentException("Parameter cannot be null", nameof(roleId));

            return await rc.Put<RoleResource>(Path(), roleResource, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a custom user role by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        ///     User Permission: EditUserRoles
        /// </summary>
        public async Task<string> Delete(DeleteCustomRoleParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (roleId == null) throw new ArgumentException("Parameter cannot be null", nameof(roleId));

            return await rc.Delete<string>(Path(), null, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public UserRole.Index UserRole(string roleId = null)
        {
            return new UserRole.Index(this, roleId);
        }
    }
}