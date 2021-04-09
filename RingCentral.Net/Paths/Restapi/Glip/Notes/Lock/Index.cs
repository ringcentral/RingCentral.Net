using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes.Lock
{
    public class Index
    {
        public Notes.Index parent;
        public RestClient rc;

        public Index(Notes.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/lock";
        }

        /// <summary>
        ///     Locks a note providing the user with the unique write access for 5 hours.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/notes/{noteId}/lock
        ///     Rate Limit Group: Light
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Lock.Index Lock()
        {
            return new Lock.Index(this);
        }
    }
}