using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Chats.Unread
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unread";
        }

        /// <summary>
        /// Sets the specified chat status to 'Unread' for the current user. **Note** 'Chat' is a general name for all types of threads icluding *Personal* (user's own me-chat), *Direct* (one on one chat), *Group* (chat of 3-15 participants without specific name), *Team* (chat of 2 and more participants, with a specific name), *Everyone* (company chat including all employees, with a specific name)."
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/unread
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessagingInternal
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Unread.Index Unread()
        {
            return new Restapi.Glip.Chats.Unread.Index(this);
        }
    }
}