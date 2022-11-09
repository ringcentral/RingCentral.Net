using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Teams.Add
{
    public class Index
    {
        public Teams.Index parent;
        public RestClient rc;

        public Index(Teams.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/add";
        }

        /// <summary>
        ///     Adds members to the specified team.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}/add
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(TMAddTeamMembersRequest tMAddTeamMembersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), tMAddTeamMembersRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Teams
{
    public partial class Index
    {
        public Add.Index Add()
        {
            return new Add.Index(this);
        }
    }
}