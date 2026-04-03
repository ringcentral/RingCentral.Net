using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Everyone
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public Index(TeamMessaging.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/everyone";
        }
        /// <summary>
        /// Returns information about "Everyone" chat (a company level chat which includes all employees).
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/everyone
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.EveryoneTeamInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.EveryoneTeamInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates "Everyone" chat information.
        /// HTTP Method: patch
        /// Endpoint: /team-messaging/v1/everyone
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.EveryoneTeamInfo> Patch(RingCentral.UpdateEveryoneTeamRequest updateEveryoneTeamRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<RingCentral.EveryoneTeamInfo>(this.Path(), updateEveryoneTeamRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Everyone.Index Everyone()
        {
            return new TeamMessaging.V1.Everyone.Index(this);
        }
    }
}