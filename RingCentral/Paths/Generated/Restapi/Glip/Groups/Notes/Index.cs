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

        public class GetQueryParams
        {
            // Number of groups to be fetched by one request, the maximum value is 250, the default is 30
            public string recordCount;

            // Token of a page to be returned
            public string pageToken;

            // Status of notes to be fetched. If not specified all notes are returned
            // Enum: Active, Draft, Unknown
            public string status;

            // Internal identifier of a note author
            public string creatorId;
        }

        public async Task<RingCentral.GlipNotesInfo> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(), queryParams);
        }

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