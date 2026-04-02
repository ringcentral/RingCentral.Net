using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Remove
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
            return $"{parent.Path()}/remove";
        }
        /// <summary>
        /// Removes members from the specified team.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/teams/{chatId}/remove
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Post(RingCentral.TMRemoveTeamMembersRequest tMRemoveTeamMembersRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), tMRemoveTeamMembersRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public TeamMessaging.V1.Teams.Remove.Index Remove()
        {
            return new TeamMessaging.V1.Teams.Remove.Index(this);
        }
    }
}