using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Archive
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
            return $"{parent.Path()}/archive";
        }
        /// <summary>
        /// Changes the status of the specified team to 'Archived'.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/teams/{chatId}/archive
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public TeamMessaging.V1.Teams.Archive.Index Archive()
        {
            return new TeamMessaging.V1.Teams.Archive.Index(this);
        }
    }
}