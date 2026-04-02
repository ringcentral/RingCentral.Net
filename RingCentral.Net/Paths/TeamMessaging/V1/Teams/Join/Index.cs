using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Join
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
            return $"{parent.Path()}/join";
        }
        /// <summary>
        /// Adds the current user to the specified team.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/teams/{chatId}/join
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
        public TeamMessaging.V1.Teams.Join.Index Join()
        {
            return new TeamMessaging.V1.Teams.Join.Index(this);
        }
    }
}