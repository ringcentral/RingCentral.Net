using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Chats.Unread
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unread";
        }

        /// <summary>
        ///     Sets the specified chat status to 'Unread' for the current user.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/chats/{chatId}/unread
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessagingInternal
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Chats
{
    public partial class Index
    {
        public Unread.Index Unread()
        {
            return new Unread.Index(this);
        }
    }
}