using System.Threading.Tasks;

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
        /// Operation: Mark Chat as Unread
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/unread
        /// Rate Limit Group: Medium
        /// App Permission: GlipInternal
        /// User Permission: undefined
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