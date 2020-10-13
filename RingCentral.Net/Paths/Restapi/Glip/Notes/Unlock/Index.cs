using System.Threading.Tasks;
using System.Threading;

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
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/notes/{noteId}/unlock
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
        public Restapi.Glip.Notes.Unlock.Index Unlock()
        {
            return new Restapi.Glip.Notes.Unlock.Index(this);
        }
    }
}