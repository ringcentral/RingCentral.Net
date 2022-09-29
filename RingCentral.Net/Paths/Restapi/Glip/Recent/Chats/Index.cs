using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Recent.Chats
{
    public class Index
    {
        public Recent.Index parent;
        public RestClient rc;

        public Index(Recent.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/chats";
        }

        /// <summary>
        ///     Returns recent chats where the user is a member. All records in response are sorted by the `lastModifiedTime` in
        ///     descending order (the latest changed chat is displayed first on page). **Note** 'Chat' is a general name for all
        ///     types of threads including *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15
        ///     participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone*
        ///     (company chat including all employees, with a specific name)."
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/recent/chats
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipChatsListWithoutNavigation> Get(ListRecentChatsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipChatsListWithoutNavigation>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Recent
{
    public partial class Index
    {
        public Chats.Index Chats()
        {
            return new Chats.Index(this);
        }
    }
}