namespace RingCentral.Paths.Restapi.Account.Department
{
    public partial class Index
    {
        public RestClient rc;
        public string departmentId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string departmentId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.departmentId = departmentId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && departmentId != null)
            {
                return $"{parent.Path()}/department/{departmentId}";
            }

            return $"{parent.Path()}/department";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Department.Index Department(string departmentId = null)
        {
            return new Restapi.Account.Department.Index(this, departmentId);
        }
    }
}