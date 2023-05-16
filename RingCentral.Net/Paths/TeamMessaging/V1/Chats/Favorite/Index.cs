using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Favorite
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/favorite";
        }

        /// <summary>
        ///     Adds the specified chat to the users's list of favorite chats.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/favorite
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public Favorite.Index Favorite()
        {
            return new Favorite.Index(this);
        }
    }
}