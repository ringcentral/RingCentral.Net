using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.UserRole.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Assigns multiple user roles.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: RoleManagement
        ///     User Permission: EditUserRoles
        /// </summary>
        public async Task<string> Post(BulkRoleAssignResource bulkRoleAssignResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), bulkRoleAssignResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}