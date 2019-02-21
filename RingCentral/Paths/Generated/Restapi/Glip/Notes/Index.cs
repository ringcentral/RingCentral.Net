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

        public async Task<RingCentral.GlipNotesInfo> List(LoadUserNotesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipNotesInfo> List(object queryParams)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipNoteInfo> Post(RingCentral.GlipNoteCreate glipNoteCreate)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(false), glipNoteCreate);
        }

        public async Task<RingCentral.GlipNoteInfo> Post(object glipNoteCreate)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(false), glipNoteCreate);
        }

        public async Task<RingCentral.GlipNotesInfo> Get()
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path());
        }

        public async Task<string> Delete()
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Delete<string>(this.Path());
        }

        public async Task<RingCentral.GlipNoteInfo> Patch(RingCentral.GlipNoteCreate glipNoteCreate,
            PatchNoteParameters queryParams = null)
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Patch<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate, queryParams);
        }

        public async Task<RingCentral.GlipNoteInfo> Patch(object glipNoteCreate, object queryParams)
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Patch<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate, queryParams);
        }

        public async Task<RingCentral.GlipNoteInfo> Put(RingCentral.GlipNoteCreate glipNoteCreate)
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Put<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate);
        }

        public async Task<RingCentral.GlipNoteInfo> Put(object glipNoteCreate)
        {
            if (this.noteId == null)
            {
                throw new System.ArgumentNullException("noteId");
            }

            return await rc.Put<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate);
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