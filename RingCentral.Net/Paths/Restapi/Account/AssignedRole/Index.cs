using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AssignedRole
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/assigned-role";
        }

        /// <summary>
        ///     Returns a list of roles assigned to the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/assigned-role
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadAssignedRoles
        /// </summary>
        public async Task<ExtensionWithRolesCollectionResource> Get(ListAssignedRolesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ExtensionWithRolesCollectionResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public AssignedRole.Index AssignedRole()
        {
            return new AssignedRole.Index(this);
        }
    }
}