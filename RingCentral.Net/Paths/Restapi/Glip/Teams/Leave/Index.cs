using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Teams.Leave
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
            return $"{parent.Path()}/leave";
        }

        /// <summary>
        /// Removes the current user from the specified team. A team is a chat between 2 and more participants assigned with specific name.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/leave
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Leave.Index Leave()
        {
            return new Restapi.Glip.Teams.Leave.Index(this);
        }
    }
}