using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole.Default
{
    public class Index
    {
        public AssignedRole.Index parent;
        public RestClient rc;

        public Index(AssignedRole.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/default";
        }

        /// <summary>
        ///     Assigns the default role to the currently logged-in user extension.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assigned-role/default
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        ///     User Permission: Users
        /// </summary>
        public async Task<AssignedRolesResource> Put(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<AssignedRolesResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AssignedRole
{
    public partial class Index
    {
        public Default.Index Default()
        {
            return new Default.Index(this);
        }
    }
}