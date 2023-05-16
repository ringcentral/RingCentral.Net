using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Notes.Unlock
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/unlock";
        }

        /// <summary>
        ///     Unlocks a note letting other users edit this note. Once the note is locked (by another user) it cannot be unlocked
        ///     during 5 hours since the lock datetime.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/notes/{noteId}/unlock
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Notes
{
    public partial class Index
    {
        public Unlock.Index Unlock()
        {
            return new Unlock.Index(this);
        }
    }
}