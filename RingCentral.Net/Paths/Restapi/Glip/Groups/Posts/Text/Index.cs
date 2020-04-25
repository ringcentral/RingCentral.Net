using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Groups.Posts.Text
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Posts.Index parent;

        public Index(Restapi.Glip.Groups.Posts.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/text";
        }

        /// <summary>
        /// Operation: Update Post
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/posts/{postId}/text
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Put(string body, CancellationToken? cancellationToken = null)
        {
            return await rc.Put<string>(this.Path(), body, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups.Posts
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Posts.Text.Index Text()
        {
            return new Restapi.Glip.Groups.Posts.Text.Index(this);
        }
    }
}