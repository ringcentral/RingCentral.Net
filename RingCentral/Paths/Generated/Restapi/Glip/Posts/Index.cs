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

        public async Task<RingCentral.GlipPosts> Get()
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path());
        }

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