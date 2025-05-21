using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Token
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
            return $"{parent.Path()}/token";
        }

        /// <summary>
        ///     Returns access (and potentially refresh) tokens for making API requests.
        ///     For confidential client application types
        ///     this endpoint requires client authentication using one of the supported
        ///     methods:
        ///     - `client_secret_basic` - client ID and client secret must be provided via `Authorization` header as described in
        ///     [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-2.3.1).
        ///     - `client_secret_jwt` / `private_key_jwt` -- `client_assertion` attribute should be used to pass a signed JWT as
        ///     described in
        ///     [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.2).
        ///     For non-confidential client application types
        ///     the client identifier must be provided via `client_id` request attribute.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/token
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<TokenInfo> Post(GetTokenRequest getTokenRequest, RestRequestConfig restRequestConfig = null)
        {
            var dict = new Dictionary<string, string>();
            Utils.GetPairs(getTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<TokenInfo>(Path(), new FormUrlEncodedContent(dict), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Token.Index Token()
        {
            return new Token.Index(this);
        }
    }
}