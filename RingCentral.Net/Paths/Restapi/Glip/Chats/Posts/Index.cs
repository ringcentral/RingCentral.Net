using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Chats.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public string postId;
        public Restapi.Glip.Chats.Index parent;

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
        /// Operation: Get Posts
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/glip/chats/{chatId}/posts
        /// </summary>
        public async Task<RingCentral.GlipPostsList> List(ReadGlipPostsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipPostsList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Post
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/glip/chats/{chatId}/posts
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipPostPostBody glipPostPostBody,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipPostPostBody, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Post
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Get<RingCentral.GlipPostInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Post
        /// Rate Limit Group: Medium
        /// Http Patch /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Patch(RingCentral.GlipPatchPostBody glipPatchPostBody,
            CancellationToken? cancellationToken = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Patch<RingCentral.GlipPostInfo>(this.Path(), glipPatchPostBody, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Post
        /// Rate Limit Group: Medium
        /// Http Delete /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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