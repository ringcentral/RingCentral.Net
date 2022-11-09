using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Everyone
{
    public class Index
    {
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/everyone";
        }

        /// <summary>
        ///     Returns information about "Everyone" chat (a company level chat which includes all employees).
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/everyone
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<EveryoneTeamInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<EveryoneTeamInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates "Everyone" chat information.
        ///     HTTP Method: patch
        ///     Endpoint: /team-messaging/{version}/everyone
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<EveryoneTeamInfo> Patch(UpdateEveryoneTeamRequest updateEveryoneTeamRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<EveryoneTeamInfo>(Path(), updateEveryoneTeamRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Everyone.Index Everyone()
        {
            return new Everyone.Index(this);
        }
    }
}