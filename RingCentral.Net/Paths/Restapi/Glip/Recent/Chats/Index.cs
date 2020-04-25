using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Recent.Chats
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Recent.Index parent;

        public Index(Restapi.Glip.Recent.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/chats";
        }

        /// <summary>
        /// Operation: Get Recent Chats
        /// Http Get /restapi/v1.0/glip/recent/chats
        /// </summary>
        public async Task<RingCentral.GlipChatsListWithoutNavigation> Get(ListRecentChatsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipChatsListWithoutNavigation>(this.Path(), queryParams,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Recent
{
    public partial class Index
    {
        public Restapi.Glip.Recent.Chats.Index Chats()
        {
            return new Restapi.Glip.Recent.Chats.Index(this);
        }
    }
}