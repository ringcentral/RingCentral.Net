using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Revoke
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
            return $"{parent.Path()}/revoke";
        }
        /// <summary>
        /// Revokes all active access/refresh tokens and invalidates the OAuth session basing on token provided.
        /// The `token` parameter may be passed in query string or body and may represent access or refresh token.
        /// 
        /// This endpoint is defined by [RFC-7009 "OAuth 2.0 Token Revocation"](https://datatracker.ietf.org/doc/html/rfc7009)
        /// 
        /// For confidential client application types
        /// this endpoint requires client authentication using one of the supported
        /// methods:
        ///   - `client_secret_basic` - client ID and client secret must be provided via `Authorization` header as described in
        ///     [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-2.3.1).
        ///   - `client_secret_jwt` / `private_key_jwt` -- `client_assertion` attribute should be used to pass a signed JWT as described in
        ///     [RFC-7523](https://datatracker.ietf.org/doc/html/rfc7523#section-2.2).
        /// 
        /// For non-confidential client application types
        /// the client identifier must be provided via `client_id` request attribute.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/revoke
        /// Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(RingCentral.RevokeTokenRequest revokeTokenRequest, RingCentral.RevokeTokenParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            Utils.GetPairs(revokeTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(this.Path(), new FormUrlEncodedContent(dict), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Revoke.Index Revoke()
        {
            return new Restapi.Oauth.Revoke.Index(this);
        }
    }
}