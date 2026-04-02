using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Notes.Unlock
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
            return $"{parent.Path()}/unlock";
        }
        /// <summary>
        /// Unlocks a note letting other users edit this note. Once the note is locked (by another user) it cannot be unlocked during 5 hours since the lock datetime.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/notes/{noteId}/unlock
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
        public TeamMessaging.V1.Notes.Unlock.Index Unlock()
        {
            return new TeamMessaging.V1.Notes.Unlock.Index(this);
        }
    }
}