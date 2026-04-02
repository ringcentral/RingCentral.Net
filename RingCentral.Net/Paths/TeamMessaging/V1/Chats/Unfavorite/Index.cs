using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Unfavorite
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Chats.Index parent;
public Index(TeamMessaging.V1.Chats.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/unfavorite";
        }
        /// <summary>
        /// Removes the specified chat from the users's list of favorite chats.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/chats/{chatId}/unfavorite
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Unfavorite.Index Unfavorite()
        {
            return new TeamMessaging.V1.Chats.Unfavorite.Index(this);
        }
    }
}