using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public string chatId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string chatId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/teams
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipTeamsList> List(ListGlipTeamsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipTeamsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a team, and adds a list of people to the team.  A team is a chat between 2 and more (unlimited number)
        ///     participants assigned with specific name.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/teams
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipTeamInfo> Post(GlipPostTeamBody glipPostTeamBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipTeamInfo>(Path(false), glipPostTeamBody, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified team. A team is a chat between 2 and more participants assigned with
        ///     specific name.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipTeamInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));

            return await rc.Get<GlipTeamInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified team. A team is a chat between 2 and more (unlimited number) participants assigned with
        ///     specific name.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the name and description of the specified team. A team is a chat between 2 and more (unlimited number)
        ///     participants assigned with specific name.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipTeamInfo> Patch(GlipPatchTeamBody glipPatchTeamBody,
            RestRequestConfig restRequestConfig = null)
        {
            if (chatId == null) throw new ArgumentException("Parameter cannot be null", nameof(chatId));

            return await rc.Patch<GlipTeamInfo>(Path(), glipPatchTeamBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Teams.Index Teams(string chatId = null)
        {
            return new Teams.Index(this, chatId);
        }
    }
}