using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Recent.Chats
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Recent.Index parent;

        public Index(Restapi.Glip.Recent.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/chats";
        }

        /// <summary>
        /// Returns recent chats where the user is a member. All records in response are sorted by the `lastModifiedTime` in descending order (the latest changed chat is displayed first on page). **Note** 'Chat' is a general name for all types of threads icluding *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all employees, with a specific name)."
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/recent/chats
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipChatsListWithoutNavigation> Get(
            RingCentral.ListRecentChatsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipChatsListWithoutNavigation>(this.Path(), queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Recent
{
    public partial class Index
    {
        public Restapi.Glip.Recent.Chats.Index Chats()
        {
            return new Restapi.Glip.Recent.Chats.Index(this);
        }
    }
}