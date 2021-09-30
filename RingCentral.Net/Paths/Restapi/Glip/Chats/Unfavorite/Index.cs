using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Unfavorite
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
            return $"{parent.Path()}/unfavorite";
        }

        /// <summary>
        ///     Removes the specified chat from the users's list of favorites.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/unfavorite
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
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
        public Unfavorite.Index Unfavorite()
        {
            return new Unfavorite.Index(this);
        }
    }
}