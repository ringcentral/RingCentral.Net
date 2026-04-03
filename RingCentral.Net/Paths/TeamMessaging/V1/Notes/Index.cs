using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public string noteId;
        public Index(TeamMessaging.V1.Index parent, string noteId = null)
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
        /// Returns the specified note(s). It is possible to fetch up to 50 notes per request.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMNoteWithBodyInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }
            return await rc.Get<RingCentral.TMNoteWithBodyInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified note.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }

        /// <summary>
        /// Edits a note. Notes can be edited by any user if posted to a chat. the user belongs to.
        /// HTTP Method: patch
        /// Endpoint: /team-messaging/v1/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMNoteInfo> Patch(RingCentral.TMCreateNoteRequest tMCreateNoteRequest, RingCentral.PatchNoteNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }
            return await rc.Patch<RingCentral.TMNoteInfo>(this.Path(), tMCreateNoteRequest, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Notes.Index Notes(string noteId = null)
        {
            return new TeamMessaging.V1.Notes.Index(this, noteId);
        }
    }
}