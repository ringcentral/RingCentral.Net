using System.Threading.Tasks;

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

        public class ListQueryParams
        {
            // Type of chats to be fetched. By default all type of chats will be fetched
            public string type;

            // Number of chats to be fetched by one request. The maximum value is 250, by default - 30.
            public string recordCount;

            // Pagination token.
            public string pageToken;
        }

        public async Task<RingCentral.GlipChatsList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipChatsList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipChatInfo> Get()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipChatInfo>(this.Path());
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