using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AssignedRole
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/assigned-role";
        }

        /// <summary>
        /// Returns the list of assigned roles for the current account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/assigned-role
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadAssignedRoles
        /// </summary>
        public async Task<RingCentral.ExtensionWithRolesCollectionResource> Get(
            RingCentral.ListAssignedRolesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ExtensionWithRolesCollectionResource>(this.Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.AssignedRole.Index AssignedRole()
        {
            return new Restapi.Account.AssignedRole.Index(this);
        }
    }
}