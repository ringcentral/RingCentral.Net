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

        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
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