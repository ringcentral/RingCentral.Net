using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.V2.Accounts.Extensions.Index parent;
        public Index(Restapi.V2.Accounts.Extensions.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/comm-handling";
        }

    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.CommHandling.Index CommHandling()
        {
            return new Restapi.V2.Accounts.Extensions.CommHandling.Index(this);
        }
    }
}