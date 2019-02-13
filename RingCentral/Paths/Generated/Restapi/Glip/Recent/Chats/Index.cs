using System.Threading.Tasks;

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

        public class GetQueryParams
        {
            // Type of chats to be fetched (by default, all type of chats will be fetched).
            public string type;

            // Max number of chats to be fetched by one request (Not more than 250).
            public string recordCount;
        }

        public async Task<RingCentral.GlipChatsListWithoutNavigation> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipChatsListWithoutNavigation>(this.Path(), queryParams);
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