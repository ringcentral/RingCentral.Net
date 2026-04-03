using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Chats.Index parent;
        public string postId;
        public Index(TeamMessaging.V1.Chats.Index parent, string postId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.postId = postId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && postId != null)
            {
                return $"{parent.Path()}/posts/{postId}";
            }
            return $"{parent.Path()}/posts";
        }
        /// <summary>
        /// Returns a list of posts from the specified chat.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMPostsList> List(RingCentral.ReadGlipPostsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMPostsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a post in the chat specified in path. Any mention can be added within the `text` attribute of
        /// the request body in .md format - `![:Type](id)`, where `type` is one of (Person, Team, File, Note,
        /// Task, Event, Link, Card) and `id` is a unique identifier of the mentioned object of the specified type.
        /// Attachments can also be added to a post by passing the type and ID of attachment(s) in request body.
        /// 
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMPostInfo> Post(RingCentral.TMCreatePostRequest tMCreatePostRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.TMPostInfo>(this.Path(false), tMCreatePostRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns information about the specified post.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMPostInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }
            return await rc.Get<RingCentral.TMPostInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified post from the chat.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }

        /// <summary>
        /// Updates a specific post within a chat.
        /// HTTP Method: patch
        /// Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMPostInfo> Patch(RingCentral.TMUpdatePostRequest tMUpdatePostRequest, RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }
            return await rc.Patch<RingCentral.TMPostInfo>(this.Path(), tMUpdatePostRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Posts.Index Posts(string postId = null)
        {
            return new TeamMessaging.V1.Chats.Posts.Index(this, postId);
        }
    }
}