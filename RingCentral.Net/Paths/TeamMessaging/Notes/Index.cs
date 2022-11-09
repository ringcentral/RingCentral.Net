using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Notes
{
    public partial class Index
    {
        public string noteId;
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent, string noteId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.noteId = noteId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && noteId != null) return $"{parent.Path()}/notes/{noteId}";
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        ///     Returns the specified note(s). It is possible to fetch up to 50 notes per request.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/notes/{noteId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMNoteWithBodyInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null) throw new ArgumentException("Parameter cannot be null", nameof(noteId));
            return await rc.Get<TMNoteWithBodyInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified note.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/{version}/notes/{noteId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null) throw new ArgumentException("Parameter cannot be null", nameof(noteId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Edits a note. Notes can be edited by any user if posted to a chat. the user belongs to.
        ///     HTTP Method: patch
        ///     Endpoint: /team-messaging/{version}/notes/{noteId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMNoteInfo> Patch(TMCreateNoteRequest tMCreateNoteRequest,
            PatchNoteNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null) throw new ArgumentException("Parameter cannot be null", nameof(noteId));
            return await rc.Patch<TMNoteInfo>(Path(), tMCreateNoteRequest, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Notes.Index Notes(string noteId = null)
        {
            return new Notes.Index(this, noteId);
        }
    }
}