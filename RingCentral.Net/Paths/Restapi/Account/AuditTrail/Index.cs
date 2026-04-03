using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AuditTrail
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/audit-trail";
        }

    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.AuditTrail.Index AuditTrail()
        {
            return new Restapi.Account.AuditTrail.Index(this);
        }
    }
}