using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Teams.Unarchive
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
            return $"{parent.Path()}/unarchive";
        }

        /// <summary>
        ///     Changes the status of the specified team to 'Active'.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/teams/{chatId}/unarchive
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Teams
{
    public partial class Index
    {
        public Unarchive.Index Unarchive()
        {
            return new Unarchive.Index(this);
        }
    }
}