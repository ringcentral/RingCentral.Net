using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageThreads.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.MessageThreads.Index parent;
        public string noteId;
        public Index(Restapi.Account.MessageThreads.Index parent, string noteId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.noteId = noteId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && noteId != null)
            {
                return $"{parent.Path()}/notes/{noteId}";
            }
            return $"{parent.Path()}/notes";
        }
        /// <summary>
        /// Returns a list of notes from one or more threads.
        /// All filters are applied as "AND" conditions.
        /// 
        /// The records are sorted by `creationTime` in ascending order.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/notes
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadNoteList> Get(RingCentral.MthListNotesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ThreadNoteList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new note in the thread.
        /// 
        /// The thread must be in `Open` status and the current user must be in the list of thread monitors
        /// for this operation to succeed.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/notes
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadNoteModel> Post(RingCentral.ThreadNoteCreateRequest threadNoteCreateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ThreadNoteModel>(this.Path(false), threadNoteCreateRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes thread note(s).
        /// 
        /// The corresponding threads must be in `Open` status and the calling user must be the notes' author
        /// for this operation to succeed.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/notes
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<string> Delete(RingCentral.ThreadNotesDeleteRequest threadNotesDeleteRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(false), threadNotesDeleteRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Updates the text of a note.
        /// 
        /// The thread must be in `Open` status and the calling user must be the note's author
        /// for this operation to succeed.
        /// 
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-threads/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// </summary>
        public async Task<RingCentral.ThreadNoteModel> Patch(RingCentral.ThreadNoteUpdateRequest threadNoteUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }
            return await rc.Patch<RingCentral.ThreadNoteModel>(this.Path(), threadNoteUpdateRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.MessageThreads
{
    public partial class Index
    {
        public Restapi.Account.MessageThreads.Notes.Index Notes(string noteId = null)
        {
            return new Restapi.Account.MessageThreads.Notes.Index(this, noteId);
        }
    }
}