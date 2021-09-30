using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Notes
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        ///     Returns the list of notes created in the specified chat.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/notes
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipNotesInfo> Get(ListChatNotesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipNotesInfo>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new note in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/notes
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipNoteInfo> Post(GlipNoteCreate glipNoteCreate, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipNoteInfo>(Path(), glipNoteCreate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Notes.Index Notes()
        {
            return new Notes.Index(this);
        }
    }
}