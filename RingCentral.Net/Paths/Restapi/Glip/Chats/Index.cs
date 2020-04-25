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
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/glip/chats
        /// </summary>
        public async Task<RingCentral.GlipChatsList> List(ListGlipChatsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipChatsList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Chat
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/glip/chats/{chatId}
        /// </summary>
        public async Task<RingCentral.GlipChatInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipChatInfo>(this.Path(), null, cancellationToken);
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