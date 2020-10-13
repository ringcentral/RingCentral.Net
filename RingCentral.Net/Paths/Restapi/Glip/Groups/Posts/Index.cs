using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Groups.Posts
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/posts";
        }

        /// <summary>
        /// Operation: Create Post in Group
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/posts
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPostInfo> Post(RingCentral.GlipCreatePost glipCreatePost,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipPostInfo>(this.Path(), glipCreatePost, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Posts.Index Posts()
        {
            return new Restapi.Glip.Groups.Posts.Index(this);
        }
    }
}