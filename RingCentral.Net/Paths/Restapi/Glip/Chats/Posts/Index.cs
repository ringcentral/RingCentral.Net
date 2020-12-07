using System.Threading.Tasks;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostsList> List(ReadGlipPostsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipPostsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Post
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipPostPostBody glipPostPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipPostPostBody, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Post
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Get<RingCentral.GlipPostInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Post
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Post
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Patch(RingCentral.GlipPatchPostBody glipPatchPostBody,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
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