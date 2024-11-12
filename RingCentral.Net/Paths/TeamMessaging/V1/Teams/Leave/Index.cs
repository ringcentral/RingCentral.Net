using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Leave
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
            return $"{parent.Path()}/leave";
        }

        /// <summary>
        ///     Removes the current user from the specified team.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/teams/{chatId}/leave
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public Leave.Index Leave()
        {
            return new Leave.Index(this);
        }
    }
}