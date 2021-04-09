using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes.Publish
{
    public class Index
    {
        public Notes.Index parent;
        public RestClient rc;

        public Index(Notes.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/publish";
        }

        /// <summary>
        ///     Publishes a note making it visible to other users.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}/publish
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Publish.Index Publish()
        {
            return new Publish.Index(this);
        }
    }
}