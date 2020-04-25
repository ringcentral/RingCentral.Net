using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Get Group Posts
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/posts
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipPosts> Get(ListGlipGroupPostsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipPosts>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Post in Group
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/posts
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(false), glipCreatePost, null, cancellationToken);
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