using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Groups.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notes";
        }

        // Operation: loadGroupNotes
        // Http Get /restapi/v1.0/glip/groups/{groupId}/notes
        public async Task<RingCentral.GlipNotesInfo> Get(LoadGroupNotesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(), queryParams);
        }

        // Operation: createGroupNote
        // Http Post /restapi/v1.0/glip/groups/{groupId}/notes
        public async Task<RingCentral.GlipNoteInfo> Post(RingCentral.GlipNoteCreate glipNoteCreate)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.Notes.Index Notes()
        {
            return new Restapi.Glip.Groups.Notes.Index(this);
        }
    }
}