using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignableRoles
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/assignable-roles";
        }

        /// <summary>
        ///     Returns a list of roles which can be assigned to a given extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assignable-roles
        ///     Rate Limit Group: Medium
        ///     App Permission: RoleManagement
        /// </summary>
        public async Task<RolesCollectionResource> Get(
            ListOfAvailableForAssigningRolesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RolesCollectionResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AssignableRoles.Index AssignableRoles()
        {
            return new AssignableRoles.Index(this);
        }
    }
}