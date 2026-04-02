using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MsTeams.DirectRouting
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.MsTeams.Index parent;
public Index(Restapi.Account.MsTeams.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/direct-routing";
        }

    }
}

namespace RingCentral.Paths.Restapi.Account.MsTeams
{
    public partial class Index
    {
        public Restapi.Account.MsTeams.DirectRouting.Index DirectRouting()
        {
            return new Restapi.Account.MsTeams.DirectRouting.Index(this);
        }
    }
}