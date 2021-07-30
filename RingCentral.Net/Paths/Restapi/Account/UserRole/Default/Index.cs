using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.UserRole.Default
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.UserRole.Index parent;

        public Index(Restapi.Account.UserRole.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/default";
        }

        /// <summary>
        /// Returns account default user role.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/default
        /// Rate Limit Group: Light
        /// App Permission: RoleManagement
        /// User Permission: Roles
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates account default user role.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/default
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: Roles
        /// </summary>
        public async Task<string> Put(RingCentral.DefaultUserRoleRequest defaultUserRoleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<string>(this.Path(), defaultUserRoleRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public Restapi.Account.UserRole.Default.Index Default()
        {
            return new Restapi.Account.UserRole.Default.Index(this);
        }
    }
}