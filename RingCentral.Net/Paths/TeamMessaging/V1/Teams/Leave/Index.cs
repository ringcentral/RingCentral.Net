using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Leave
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Teams.Index parent;
public Index(TeamMessaging.V1.Teams.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/leave";
        }
        /// <summary>
        /// Removes the current user from the specified team.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/teams/{chatId}/leave
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public TeamMessaging.V1.Teams.Leave.Index Leave()
        {
            return new TeamMessaging.V1.Teams.Leave.Index(this);
        }
    }
}