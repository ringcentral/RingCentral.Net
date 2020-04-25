using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Posts
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/posts
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPosts> Get(ListGlipPostsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Post
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/posts
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(), glipCreatePost, null, cancellationToken);
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