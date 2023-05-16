using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Notes
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        ///     Returns the list of chat notes.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/notes
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMNoteList> Get(ListChatNotesNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMNoteList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new note in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/notes
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMNoteInfo> Post(TMCreateNoteRequest tMCreateNoteRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMNoteInfo>(Path(), tMCreateNoteRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public Notes.Index Notes()
        {
            return new Notes.Index(this);
        }
    }
}