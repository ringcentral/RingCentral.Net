using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Wstoken
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Oauth.Index parent;
public Index(Restapi.Oauth.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/wstoken";
        }
        /// <summary>
        /// Returns a special short lived token to authorize a dedicated web socket connection between this client
/// and a backend.
/// 
/// This API needs to be called if a client plans to use "Websocket" transport to receive
/// RingCentral push notifications. The token returned by this API should be provided when establishing
/// a connection to the RingCentral Websocket Gateway.
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/wstoken
        /// Rate Limit Group: Auth
        /// App Permission: WebSocket
        /// </summary>
  public async Task<RingCentral.WsTokenResponse> Post(RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.WsTokenResponse>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Wstoken.Index Wstoken()
        {
            return new Restapi.Oauth.Wstoken.Index(this);
        }
    }
}