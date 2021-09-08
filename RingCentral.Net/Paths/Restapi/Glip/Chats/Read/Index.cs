using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Chats.Read
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
            return $"{parent.Path()}/read";
        }

        /// <summary>
        /// Sets the specified chat status to 'Read' for the current user.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/read
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
        public Restapi.Glip.Chats.Read.Index Read()
        {
            return new Restapi.Glip.Chats.Read.Index(this);
        }
    }
}