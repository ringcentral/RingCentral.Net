using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes.Lock
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
            return $"{parent.Path()}/lock";
        }

        /// <summary>
        /// Locks a note providing the user with the unique write access for 5 hours.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/notes/{noteId}/lock
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Restapi.Glip.Notes.Lock.Index Lock()
        {
            return new Restapi.Glip.Notes.Lock.Index(this);
        }
    }
}