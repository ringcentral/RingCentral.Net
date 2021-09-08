using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Chats.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        /// Returns the list of notes created in the specified chat.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/notes
        /// Rate Limit Group: Heavy
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipNotesInfo> Get(RingCentral.ListChatNotesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new note in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/notes
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipNoteInfo> Post(RingCentral.GlipNoteCreate glipNoteCreate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Notes.Index Notes()
        {
            return new Restapi.Glip.Chats.Notes.Index(this);
        }
    }
}