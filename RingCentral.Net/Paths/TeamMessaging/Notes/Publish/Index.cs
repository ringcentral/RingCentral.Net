using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Notes.Publish
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
        ///     Endpoint: /team-messaging/{version}/notes/{noteId}/publish
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMNoteInfo> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMNoteInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Notes
{
    public partial class Index
    {
        public Publish.Index Publish()
        {
            return new Publish.Index(this);
        }
    }
}