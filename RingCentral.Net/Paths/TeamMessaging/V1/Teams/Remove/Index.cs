using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Remove
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/remove";
        }

        /// <summary>
        ///     Removes members from the specified team.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/teams/{chatId}/remove
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(TMRemoveTeamMembersRequest tMRemoveTeamMembersRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), tMRemoveTeamMembersRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public Remove.Index Remove()
        {
            return new Remove.Index(this);
        }
    }
}