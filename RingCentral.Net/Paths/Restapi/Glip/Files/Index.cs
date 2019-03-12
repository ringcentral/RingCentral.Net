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

        // Operation: Upload File
        // Http Post /restapi/v1.0/glip/files
        public async Task<RingCentral.PostGlipFile> Post(CreateGlipFileRequest createGlipFileRequest,
            CreateGlipFileParameters queryParams = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createGlipFileRequest);
            return await rc.Post<RingCentral.PostGlipFile>(this.Path(), multipartFormDataContent, queryParams);
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