using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Files
{
    public class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/files";
        }

        /// <summary>
        ///     Posts a file.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/files
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMAddFileRequest> Post(
            CreateGlipFileNewRequest createGlipFileNewRequest,
            CreateGlipFileNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createGlipFileNewRequest);
            return await rc.Post<TMAddFileRequest>(Path(), multipartFormDataContent, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Files.Index Files()
        {
            return new Files.Index(this);
        }
    }
}