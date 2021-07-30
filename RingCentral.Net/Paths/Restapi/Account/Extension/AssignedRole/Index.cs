using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/assigned-role";
        }

        /// <summary>
        /// Returns the list of roles assigned to the current extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.AssignedRolesResource> Get(
            RingCentral.ListUserAssignedRolesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AssignedRolesResource>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Updates the list of assigned roles for the current user.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// </summary>
        public async Task<RingCentral.AssignedRolesResource> Put(
            RingCentral.AssignedRolesResource assignedRolesResource, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.AssignedRolesResource>(this.Path(), assignedRolesResource, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AssignedRole.Index AssignedRole()
        {
            return new Restapi.Account.Extension.AssignedRole.Index(this);
        }
    }
}