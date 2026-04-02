using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Groups
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string groupId;
public Index(TeamMessaging.V1.Index parent, string groupId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.groupId = groupId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && groupId != null)
            {
                return $"{parent.Path()}/groups/{groupId}";
            }
            return $"{parent.Path()}/groups";
        }

    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Groups.Index Groups(string groupId = null)
        {
            return new TeamMessaging.V1.Groups.Index(this, groupId);
        }
    }
}