using System.Threading.Tasks;

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

        // Operation: bulkAssignDepartments
        // Http Post /restapi/v1.0/account/{accountId}/department/bulk-assign
        public async Task<string> Post(RingCentral.DepartmentBulkAssignResource departmentBulkAssignResource)
        {
            return await rc.Post<string>(this.Path(), departmentBulkAssignResource);
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