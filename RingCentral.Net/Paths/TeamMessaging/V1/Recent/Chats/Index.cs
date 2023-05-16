using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Recent.Chats
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/chats";
        }

        /// <summary>
        ///     Returns recent chats where the user is a member. All records in response are sorted by the `lastModifiedTime` in
        ///     descending order (the latest changed chat is displayed first on page)
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/recent/chats
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMChatListWithoutNavigation> Get(ListRecentChatsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMChatListWithoutNavigation>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Recent
{
    public partial class Index
    {
        public Chats.Index Chats()
        {
            return new Chats.Index(this);
        }
    }
}