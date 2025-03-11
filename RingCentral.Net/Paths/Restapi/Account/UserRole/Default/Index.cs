using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.UserRole.Default
{
    public class Index
    {
        public UserRole.Index parent;
        public RestClient rc;

        public Index(UserRole.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/default";
        }

        /// <summary>
        ///     Returns the default user role of the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/default
        ///     Rate Limit Group: Light
        ///     App Permission: RoleManagement
        ///     User Permission: Roles
        /// </summary>
        public async Task<DefaultUserRole> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DefaultUserRole>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the account default user role.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/default
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        ///     User Permission: Roles
        /// </summary>
        public async Task<DefaultUserRole> Put(DefaultUserRoleRequest defaultUserRoleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<DefaultUserRole>(Path(), defaultUserRoleRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public Default.Index Default()
        {
            return new Default.Index(this);
        }
    }
}