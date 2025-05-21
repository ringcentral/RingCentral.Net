using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Wstoken
{
    public class Index
    {
        public Oauth.Index parent;
        public RestClient rc;

        public Index(Oauth.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/wstoken";
        }

        /// <summary>
        ///     Returns a special short lived token to authorize a dedicated web socket connection between this client
        ///     and a backend.
        ///     This API needs to be called if a client plans to use "Websocket" transport to receive
        ///     RingCentral push notifications. The token returned by this API should be provided when establishing
        ///     a connection to the RingCentral Websocket Gateway.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/wstoken
        ///     Rate Limit Group: Auth
        ///     App Permission: WebSocket
        /// </summary>
        public async Task<WsTokenResponse> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<WsTokenResponse>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Wstoken.Index Wstoken()
        {
            return new Wstoken.Index(this);
        }
    }
}