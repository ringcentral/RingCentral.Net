using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Department.Members
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Department.Index parent;

        public Index(Restapi.Account.Department.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        /// Operation: Get Department Member List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/department/{departmentId}/members
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.DepartmentMemberList> Get(ListDepartmentMembersParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.DepartmentMemberList>(this.Path(), queryParams, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Department
{
    public partial class Index
    {
        public Restapi.Account.Department.Members.Index Members()
        {
            return new Restapi.Account.Department.Members.Index(this);
        }
    }
}