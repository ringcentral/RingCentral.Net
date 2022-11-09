using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Teams.Join
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
            return $"{parent.Path()}/join";
        }

        /// <summary>
        ///     Adds the current user to the specified team.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}/join
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Teams
{
    public partial class Index
    {
        public Join.Index Join()
        {
            return new Join.Index(this);
        }
    }
}