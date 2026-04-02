using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Notes.Publish
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
            return $"{parent.Path()}/publish";
        }
        /// <summary>
        /// Publishes a note making it visible to other users.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/notes/{noteId}/publish
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMNoteInfo> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.TMNoteInfo>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Notes
{
    public partial class Index
    {
        public TeamMessaging.V1.Notes.Publish.Index Publish()
        {
            return new TeamMessaging.V1.Notes.Publish.Index(this);
        }
    }
}