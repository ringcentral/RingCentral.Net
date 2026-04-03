using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Notes.Lock
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Notes.Index parent;
        public Index(TeamMessaging.V1.Notes.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/lock";
        }
        /// <summary>
        /// Locks a note providing the user with the unique write access for 5 hours.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/notes/{noteId}/lock
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Notes
{
    public partial class Index
    {
        public TeamMessaging.V1.Notes.Lock.Index Lock()
        {
            return new TeamMessaging.V1.Notes.Lock.Index(this);
        }
    }
}