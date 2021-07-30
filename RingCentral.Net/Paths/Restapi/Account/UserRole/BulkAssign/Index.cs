using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.UserRole.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Assigns multiple user roles.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/user-role/{roleId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: RoleManagement
        /// User Permission: EditUserRoles
        /// </summary>
        public async Task<string> Post(RingCentral.BulkRoleAssignResource bulkRoleAssignResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), bulkRoleAssignResource, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.UserRole
{
    public partial class Index
    {
        public Restapi.Account.UserRole.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.UserRole.BulkAssign.Index(this);
        }
    }
}