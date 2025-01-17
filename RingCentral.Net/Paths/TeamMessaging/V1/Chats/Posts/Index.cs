using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Posts
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
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/posts
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPostsList> List(ReadGlipPostsNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMPostsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a post in the chat specified in path. Any mention can be added within the `text` attribute of
        ///     the request body in .md format - `![:Type](id)`, where `type` is one of (Person, Team, File, Note,
        ///     Task, Event, Link, Card) and `id` is a unique identifier of the mentioned object of the specified type.
        ///     Attachments can also be added to a post by passing the type and ID of attachment(s) in request body.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/posts
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPostInfo> Post(TMCreatePostRequest tMCreatePostRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMPostInfo>(Path(false), tMCreatePostRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns information about the specified post.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPostInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null) throw new ArgumentException("Parameter cannot be null", nameof(postId));

            return await rc.Get<TMPostInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified post from the chat.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (postId == null) throw new ArgumentException("Parameter cannot be null", nameof(postId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a specific post within a chat.
        ///     HTTP Method: patch
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/posts/{postId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPostInfo> Patch(TMUpdatePostRequest tMUpdatePostRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (postId == null) throw new ArgumentException("Parameter cannot be null", nameof(postId));

            return await rc.Patch<TMPostInfo>(Path(), tMUpdatePostRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public Posts.Index Posts(string postId = null)
        {
            return new Posts.Index(this, postId);
        }
    }
}