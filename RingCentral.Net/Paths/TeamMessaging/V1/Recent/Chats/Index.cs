using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Recent.Chats
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Recent.Index parent;
public Index(TeamMessaging.V1.Recent.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/chats";
        }
        /// <summary>
        /// Returns recent chats where the user is a member. All records in response are sorted by the `lastModifiedTime` in descending order (the latest changed chat is displayed first on page)
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/recent/chats
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMChatListWithoutNavigation> Get(RingCentral.ListRecentChatsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.TMChatListWithoutNavigation>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Recent
{
    public partial class Index
    {
        public TeamMessaging.V1.Recent.Chats.Index Chats()
        {
            return new TeamMessaging.V1.Recent.Chats.Index(this);
        }
    }
}