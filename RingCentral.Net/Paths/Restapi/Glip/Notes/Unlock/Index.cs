using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes.Unlock
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Notes.Index parent;

        public Index(Restapi.Glip.Notes.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unlock";
        }

        /// <summary>
        /// Operation: Unlock Note
        /// Http Post /restapi/v1.0/glip/notes/{noteId}/unlock
        /// </summary>
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Restapi.Glip.Notes.Unlock.Index Unlock()
        {
            return new Restapi.Glip.Notes.Unlock.Index(this);
        }
    }
}