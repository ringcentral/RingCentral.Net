using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Threads.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Chats.Threads.Index parent;
        public Index(TeamMessaging.V1.Chats.Threads.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/posts";
        }
        /// <summary>
        /// Returns a list of posts from the specified thread in a chat.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/chats/{chatId}/threads/{threadId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMPostsList> Get(RingCentral.ReadGlipThreadPostsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMPostsList>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Threads
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Threads.Posts.Index Posts()
        {
            return new TeamMessaging.V1.Chats.Threads.Posts.Index(this);
        }
    }
}