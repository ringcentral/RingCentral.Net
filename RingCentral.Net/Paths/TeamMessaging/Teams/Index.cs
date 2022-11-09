using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Teams
{
    public partial class Index
    {
        public string chatId;
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent, string chatId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null) return $"{parent.Path()}/teams/{chatId}";
            return $"{parent.Path()}/teams";
        }

        /// <summary>
        ///     Returns the list of teams where the user is a member (both archived and active) combined with a list of public
        ///     teams that can be joined by the current user. All records in response are sorted by creation time of a chat in
        ///     ascending order. A team is a chat between 2 and more (unlimited number) participants assigned with specific name.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/teams
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTeamList> List(ListGlipTeamsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMTeamList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a team, and adds a list of people to the team.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/teams
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTeamInfo> Post(TMCreateTeamRequest tMCreateTeamRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMTeamInfo>(Path(false), tMCreateTeamRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified team.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTeamInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));
            return await rc.Get<TMTeamInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified team.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the name and description of the specified team.
        ///     HTTP Method: patch
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTeamInfo> Patch(TMUpdateTeamRequest tMUpdateTeamRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));
            return await rc.Patch<TMTeamInfo>(Path(), tMUpdateTeamRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Teams.Index Teams(string chatId = null)
        {
            return new Teams.Index(this, chatId);
        }
    }
}