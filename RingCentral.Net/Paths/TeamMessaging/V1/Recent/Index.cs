using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Recent
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public Index(TeamMessaging.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/recent";
        }

    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Recent.Index Recent()
        {
            return new TeamMessaging.V1.Recent.Index(this);
        }
    }
}