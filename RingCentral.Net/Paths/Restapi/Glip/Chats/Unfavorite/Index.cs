using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Chats.Unfavorite
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
            return $"{parent.Path()}/unfavorite";
        }

        /// <summary>
        /// Operation: Remove Chat from Favorites
        /// Http Post /restapi/v1.0/glip/chats/{chatId}/unfavorite
        /// </summary>
        public async Task<string> Post(CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Unfavorite.Index Unfavorite()
        {
            return new Restapi.Glip.Chats.Unfavorite.Index(this);
        }
    }
}