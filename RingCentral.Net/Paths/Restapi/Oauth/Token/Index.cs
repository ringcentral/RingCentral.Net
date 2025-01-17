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
        ///     methods (`client_secret_basic`, `client_secret_jwt` or `private_key_jwt`)
        ///     For non-confidential client application types
        ///     the client identifier must be provided via `client_id` request attribute.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/token
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<TokenInfo> Post(GetTokenRequest getTokenRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new Dictionary<string, string>();
            Utils.GetPairs(getTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<TokenInfo>(Path(), new FormUrlEncodedContent(dict), null,
                restRequestConfig);
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