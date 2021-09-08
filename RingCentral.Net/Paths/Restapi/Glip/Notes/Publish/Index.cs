using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Notes.Publish
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Notes.Index parent;

        public Index(Restapi.Glip.Notes.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/publish";
        }

        /// <summary>
        /// Publishes a note making it visible to other users.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}/publish
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Restapi.Glip.Notes.Publish.Index Publish()
        {
            return new Restapi.Glip.Notes.Publish.Index(this);
        }
    }
}