using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Files
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public Index(TeamMessaging.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/files";
        }
        /// <summary>
        /// Posts a file or multiple files.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/files
        /// Rate Limit Group: Heavy
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMAddFile[]> Post(RingCentral.CreateGlipFileNewRequest createGlipFileNewRequest, RingCentral.CreateGlipFileNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createGlipFileNewRequest);
            return await rc.Post<RingCentral.TMAddFile[]>(this.Path(), multipartFormDataContent, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Files.Index Files()
        {
            return new TeamMessaging.V1.Files.Index(this);
        }
    }
}