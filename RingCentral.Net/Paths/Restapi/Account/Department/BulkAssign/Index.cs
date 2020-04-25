using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Department.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Assign Multiple Department Members
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/department/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: UserGroups
        /// </summary>
        public async Task<string> Post(RingCentral.DepartmentBulkAssignResource departmentBulkAssignResource,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), departmentBulkAssignResource, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Department
{
    public partial class Index
    {
        public Restapi.Account.Department.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.Department.BulkAssign.Index(this);
        }
    }
}