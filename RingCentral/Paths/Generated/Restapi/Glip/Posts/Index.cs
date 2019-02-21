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

        public async Task<RingCentral.GlipPosts> Get(ListGlipPostsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GlipPosts> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(), glipCreatePost);
        }

        public async Task<RingCentral.GlipPostInfo> Post(object glipCreatePost)
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