using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.UserRole
{
    public class Index
    {
        public Dictionary.Index parent;
        public RestClient rc;
        public string roleId;

        public Index(Dictionary.Index parent, string roleId = null)
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
        ///     Returns a list of standard user roles.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/user-role
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<RolesCollectionResource> List(
            ListStandardUserRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RolesCollectionResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns a standard user role by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/user-role/{roleId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<RoleResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (roleId == null) throw new ArgumentException("Parameter cannot be null", nameof(roleId));

            return await rc.Get<RoleResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public UserRole.Index UserRole(string roleId = null)
        {
            return new UserRole.Index(this, roleId);
        }
    }
}