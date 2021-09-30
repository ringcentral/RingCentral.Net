using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Archive
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
        ///     Changes the status of the specified team to 'Archived'. A team is a chat between 2 and more participants assigned
        ///     with specific name.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/archive
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Archive.Index Archive()
        {
            return new Archive.Index(this);
        }
    }
}