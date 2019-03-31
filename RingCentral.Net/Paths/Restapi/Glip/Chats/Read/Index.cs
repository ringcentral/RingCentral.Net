using System.Threading.Tasks;

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
        /// Operation: Mark Chat as Read
        /// Http Post /restapi/v1.0/glip/chats/{chatId}/read
        /// </summary>
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
        public Restapi.Glip.Chats.Read.Index Read()
        {
            return new Restapi.Glip.Chats.Read.Index(this);
        }
    }
}