using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Chats.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;
        public string postId;

        public Index(Restapi.Glip.Chats.Index parent, string postId = null)
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
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipPostsList> List(RingCentral.ReadGlipPostsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipPostsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a post in the chat specified in path. Any mention can be added within the `text` attribute of the request body in .md format - `![:Type](id)`, where `type` is one of (Person, Team, File, Note, Task, Event, Link, Card) and `id` is a unique identifier of the mentioned object of the specified type. Attachments of the following types (File, Card, Event, Note) can also be added to a post by passing type and ID of attachment(s) in request body.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipPostPostBody glipPostPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipPostPostBody, null, restRequestConfig);
        }

        /// <summary>
        /// Returns information about the specified post.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }

            return await rc.Get<RingCentral.GlipPostInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified post from the chat.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a specific post within a chat.
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Patch(RingCentral.GlipPatchPostBody glipPatchPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            if (postId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(postId));
            }

            return await rc.Patch<RingCentral.GlipPostInfo>(this.Path(), glipPatchPostBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Posts.Index Posts(string postId = null)
        {
            return new Restapi.Glip.Chats.Posts.Index(this, postId);
        }
    }
}