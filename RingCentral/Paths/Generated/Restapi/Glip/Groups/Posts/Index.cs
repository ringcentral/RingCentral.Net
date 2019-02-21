using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public string postId;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent, string postId = null)
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

        public async Task<RingCentral.GlipPosts> Get(ListGlipGroupPostsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipPosts> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipCreatePost);
        }

        public async Task<RingCentral.GlipPostInfo> Post(object glipCreatePost)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipCreatePost);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Posts.Index Posts(string postId = null)
        {
            return new Restapi.Glip.Groups.Posts.Index(this, postId);
        }
    }
}