using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string chatId;
public Index(TeamMessaging.V1.Index parent, string chatId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.chatId = chatId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/teams/{chatId}";
            }
            return $"{parent.Path()}/teams";
        }
        /// <summary>
        /// Returns the list of teams where the user is a member (both archived and active) combined with a list of public teams that can be joined by the current user. All records in response are sorted by creation time of a chat in ascending order. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/teams
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTeamList> List(RingCentral.ListGlipTeamsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.TMTeamList>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a team, and adds a list of people to the team.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/teams
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTeamInfo> Post(RingCentral.TMCreateTeamRequest tMCreateTeamRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.TMTeamInfo>(this.Path(false), tMCreateTeamRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns information about the specified team.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/teams/{chatId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTeamInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (chatId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(chatId));
    }return await rc.Get<RingCentral.TMTeamInfo>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Deletes the specified team.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (chatId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(chatId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }

        /// <summary>
        /// Updates the name and description of the specified team.
        /// HTTP Method: patch
        /// Endpoint: /team-messaging/v1/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTeamInfo> Patch(RingCentral.TMUpdateTeamRequest tMUpdateTeamRequest, RestRequestConfig restRequestConfig = null)
  {
if (chatId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(chatId));
    }return await rc.Patch<RingCentral.TMTeamInfo>(this.Path(), tMUpdateTeamRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Teams.Index Teams(string chatId = null)
        {
            return new TeamMessaging.V1.Teams.Index(this, chatId);
        }
    }
}