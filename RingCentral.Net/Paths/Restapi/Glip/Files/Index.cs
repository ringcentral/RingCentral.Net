using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Files
{
    public class Index
    {
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/files";
        }

        /// <summary>
        ///     Posts a file.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/files
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<PostGlipFile> Post(CreateGlipFileRequest createGlipFileRequest,
            CreateGlipFileParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createGlipFileRequest);
            return await rc.Post<PostGlipFile>(Path(), multipartFormDataContent, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Files.Index Files()
        {
            return new Files.Index(this);
        }
    }
}