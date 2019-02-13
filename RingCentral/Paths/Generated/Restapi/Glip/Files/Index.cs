using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Files
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
            return $"{parent.Path()}/files";
        }

        public class PostQueryParams
        {
            // Internal identifier of a group to which the post with attachement will be added to
            public string groupId;

            // Name of a file attached
            public string name;
        }

        public async Task<RingCentral.PostGlipFile> Post(PostQueryParams queryParams = null)
        {
            return await rc.Post<RingCentral.PostGlipFile>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Files.Index Files()
        {
            return new Restapi.Glip.Files.Index(this);
        }
    }
}