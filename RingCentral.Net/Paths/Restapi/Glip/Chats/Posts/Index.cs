using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Posts
{
    public class Index
    {
        public Chats.Index parent;
        public string postId;
        public RestClient rc;

        public Index(Chats.Index parent, string postId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.postId = postId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && postId != null) return $"{parent.Path()}/posts/{postId}";
            return $"{parent.Path()}/posts";
        }

        /// <summary>
        ///     Returns a list of posts from the specified chat.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPostsList> List(ReadGlipPostsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipPostsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a post in the chat specified in path. Any mention can be added within the `text` attribute of the request
        ///     body in .md format - `![:Type](id)`, where `type` is one of (Person, Team, File, Note, Task, Event, Link, Card) and
        ///     `id` is a unique identifier of the mentioned object of the specified type. Attachments of the following types
        ///     (File, Card, Event, Note) can also be added to a post by passing type and ID of attachment(s) in request body.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPostInfo> Post(GlipPostPostBody glipPostPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipPostInfo>(Path(false), glipPostPostBody, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified post.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Light
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPostInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipPostInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified post from the chat.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a specific post within a chat.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPostInfo> Patch(GlipPatchPostBody glipPatchPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<GlipPostInfo>(Path(), glipPatchPostBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Posts.Index Posts(string postId = null)
        {
            return new Posts.Index(this, postId);
        }
    }
}