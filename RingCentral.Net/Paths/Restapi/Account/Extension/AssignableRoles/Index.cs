using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AssignableRoles
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/assignable-roles";
        }
        /// <summary>
        /// Returns a list of roles which can be assigned to a given extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/assignable-roles
        /// Rate Limit Group: Medium
        /// App Permission: RoleManagement
        /// </summary>
        public async Task<RingCentral.RolesCollectionResource> Get(RingCentral.ListOfAvailableForAssigningRolesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.RolesCollectionResource>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AssignableRoles.Index AssignableRoles()
        {
            return new Restapi.Account.Extension.AssignableRoles.Index(this);
        }
    }
}