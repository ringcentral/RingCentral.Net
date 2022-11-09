using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Teams.Archive
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
            return $"{parent.Path()}/archive";
        }

        /// <summary>
        ///     Changes the status of the specified team to 'Archived'.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/teams/{chatId}/archive
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
        public Archive.Index Archive()
        {
            return new Archive.Index(this);
        }
    }
}