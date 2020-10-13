using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/chats/{chatId}";
            }

            return $"{parent.Path()}/chats";
        }

        /// <summary>
        /// Operation: Get Chats
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipChatsList> List(ListGlipChatsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipChatsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Chat
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}
        /// Rate Limit Group: Light
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipChatInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipChatInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Index Chats(string chatId = null)
        {
            return new Restapi.Glip.Chats.Index(this, chatId);
        }
    }
}