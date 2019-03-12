using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/posts";
        }

        // Operation: Get Posts
        // Http Get /restapi/v1.0/glip/posts
        public async Task<RingCentral.GlipPosts> Get(ListGlipPostsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(), queryParams);
        }

        // Operation: Create Post
        // Http Post /restapi/v1.0/glip/posts
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(), glipCreatePost);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Posts.Index Posts()
        {
            return new Restapi.Glip.Posts.Index(this);
        }
    }
}