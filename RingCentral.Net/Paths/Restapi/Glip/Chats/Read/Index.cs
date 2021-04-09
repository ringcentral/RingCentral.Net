using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Read
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/read";
        }

        /// <summary>
        ///     Sets the specified chat status to 'Read' for the current user.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/read
        ///     Rate Limit Group: Medium
        ///     App Permission: GlipInternal
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Read.Index Read()
        {
            return new Read.Index(this);
        }
    }
}