using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole.Default
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.AssignedRole.Index parent;

        public Index(Restapi.Account.Extension.AssignedRole.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/default";
        }

        /// <summary>
        /// Assigns the default role to the currently logged-in user extension.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role/default
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.AssignedRolesResource> Put(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.AssignedRolesResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole
{
    public partial class Index
    {
        public Restapi.Account.Extension.AssignedRole.Default.Index Default()
        {
            return new Restapi.Account.Extension.AssignedRole.Default.Index(this);
        }
    }
}