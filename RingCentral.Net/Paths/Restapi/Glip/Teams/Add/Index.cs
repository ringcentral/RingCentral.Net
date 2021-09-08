using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Teams.Add
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/add";
        }

        /// <summary>
        /// Adds members to the specified team. A team is a chat between 2 and more participants assigned with specific name.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/add
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(RingCentral.GlipPostMembersListBody glipPostMembersListBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), glipPostMembersListBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Add.Index Add()
        {
            return new Restapi.Glip.Teams.Add.Index(this);
        }
    }
}