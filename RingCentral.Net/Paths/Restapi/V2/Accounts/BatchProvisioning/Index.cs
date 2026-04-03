using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.BatchProvisioning
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.Index parent;
        public Index(Restapi.V2.Accounts.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/batch-provisioning";
        }

    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Restapi.V2.Accounts.BatchProvisioning.Index BatchProvisioning()
        {
            return new Restapi.V2.Accounts.BatchProvisioning.Index(this);
        }
    }
}