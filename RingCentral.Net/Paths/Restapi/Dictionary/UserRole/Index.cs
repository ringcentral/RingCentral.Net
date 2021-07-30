using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.UserRole
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string roleId;

        public Index(Restapi.Dictionary.Index parent, string roleId = null)
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
        /// Get Standard User Role List
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/user-role
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.RolesCollectionResource> List(
            RingCentral.ListStandardUserRoleParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RolesCollectionResource>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns standard user role.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/user-role/{roleId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.RoleResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (roleId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(roleId));
            }

            return await rc.Get<RingCentral.RoleResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.UserRole.Index UserRole(string roleId = null)
        {
            return new Restapi.Dictionary.UserRole.Index(this, roleId);
        }
    }
}