using System.Threading.Tasks;

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

        // Operation: updateGlipPostText
        public async Task<string> Put(string body)
        {
            return await rc.Put<string>(this.Path(), body);
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