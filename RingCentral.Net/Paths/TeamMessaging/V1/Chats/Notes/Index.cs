using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Notes
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Chats.Index parent;
public Index(TeamMessaging.V1.Chats.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/notes";
        }
        /// <summary>
        /// Returns the list of chat notes.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/chats/{chatId}/notes
        /// Rate Limit Group: Heavy
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMNoteList> Get(RingCentral.ListChatNotesNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.TMNoteList>(this.Path(), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a new note in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/chats/{chatId}/notes
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMNoteInfo> Post(RingCentral.TMCreateNoteRequest tMCreateNoteRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.TMNoteInfo>(this.Path(), tMCreateNoteRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Notes.Index Notes()
        {
            return new TeamMessaging.V1.Chats.Notes.Index(this);
        }
    }
}