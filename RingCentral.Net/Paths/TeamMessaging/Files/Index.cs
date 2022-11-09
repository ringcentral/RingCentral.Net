using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Files
{
    public class Index
    {
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent)
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
        ///     Endpoint: /team-messaging/{version}/files
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMAddFileRequest> Post(CreateGlipFileNewRequest createGlipFileNewRequest,
            CreateGlipFileNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createGlipFileNewRequest);
            return await rc.Post<TMAddFileRequest>(Path(), multipartFormDataContent, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Files.Index Files()
        {
            return new Files.Index(this);
        }
    }
}