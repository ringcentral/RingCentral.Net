using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string noteId;

        public Index(Restapi.Glip.Index parent, string noteId = null)
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
        /// Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GetGlipNoteInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }

            return await rc.Get<RingCentral.GetGlipNoteInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified note.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Edits a note. Notes can be edited by any user if posted to a chat. the user belongs to.
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipNoteInfo> Patch(RingCentral.GlipNoteCreate glipNoteCreate,
            RestRequestConfig restRequestConfig = null)
        {
            if (noteId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(noteId));
            }

            return await rc.Patch<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Notes.Index Notes(string noteId = null)
        {
            return new Restapi.Glip.Notes.Index(this, noteId);
        }
    }
}