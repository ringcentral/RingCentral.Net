using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Unread
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
        ///     Sets the specified chat status to 'Unread' for the current user. **Note** 'Chat' is a general name for all types of
        ///     threads including *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants
        ///     without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat
        ///     including all employees, with a specific name)."
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/unread
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessagingInternal
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Unread.Index Unread()
        {
            return new Unread.Index(this);
        }
    }
}