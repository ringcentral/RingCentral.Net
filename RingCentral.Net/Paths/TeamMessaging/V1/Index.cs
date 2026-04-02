using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.Index parent;
public Index(TeamMessaging.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v1";
        }

    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public TeamMessaging.V1.Index V1()
        {
            return new TeamMessaging.V1.Index(this);
        }
    }
}