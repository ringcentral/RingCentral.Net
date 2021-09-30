using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Add
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
        ///     Adds members to the specified team. A team is a chat between 2 and more participants assigned with specific name.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/add
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(GlipPostMembersListBody glipPostMembersListBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), glipPostMembersListBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Add.Index Add()
        {
            return new Add.Index(this);
        }
    }
}