using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public string noteId;
        public Restapi.Glip.Index parent;

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
        /// Operation: Get Note
        /// Http Get /restapi/v1.0/glip/notes/{noteId}
        /// </summary>
        public async Task<RingCentral.GetGlipNoteInfo> Get()
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Get<RingCentral.GetGlipNoteInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Note
        /// Http Patch /restapi/v1.0/glip/notes/{noteId}
        /// </summary>
        public async Task<RingCentral.GlipNoteInfo> Patch(RingCentral.GlipNoteCreate glipNoteCreate)
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Patch<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate);
        }

        /// <summary>
        /// Operation: Delete Note
        /// Http Delete /restapi/v1.0/glip/notes/{noteId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Delete<string>(this.Path());
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