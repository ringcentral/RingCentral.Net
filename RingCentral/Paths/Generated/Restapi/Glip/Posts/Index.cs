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

        public async Task<RingCentral.GlipPosts> Get(GetQueryParams queryParams = null)
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

    public class GetQueryParams
    {
        // Identifier of a group to filter posts
        public string groupId;

        // Token of a page to be returned
        public string pageToken;

        // Number of records to be returned. The maximum value is 250, by default - 30
        public long? recordCount;
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