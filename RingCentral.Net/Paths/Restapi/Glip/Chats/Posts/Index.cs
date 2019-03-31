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

        // Operation: Load Glip Posts
        // Http Get /restapi/v1.0/glip/chats/{chatId}/posts
        public async Task<RingCentral.GlipPostsList> List(LoadGlipPostsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipPostsList>(this.Path(false), queryParams);
        }

        // Operation: Create Glip Post
        // Http Post /restapi/v1.0/glip/chats/{chatId}/posts
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipPostPostBody glipPostPostBody)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipPostPostBody);
        }

        // Operation: Get Post
        // Http Get /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        public async Task<RingCentral.GlipPostInfo> Get()
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Get<RingCentral.GlipPostInfo>(this.Path());
        }

        // Operation: Update Glip Post
        // Http Patch /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        public async Task<RingCentral.GlipPostInfo> Patch(RingCentral.GlipPatchPostBody glipPatchPostBody)
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Patch<RingCentral.GlipPostInfo>(this.Path(), glipPatchPostBody);
        }

        // Operation: Delete Glip Post
        // Http Delete /restapi/v1.0/glip/chats/{chatId}/posts/{postId}
        public async Task<string> Delete()
        {
            if (this.postId == null)
            {
                throw new System.ArgumentNullException("postId");
            }

            return await rc.Delete<string>(this.Path());
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