using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Jwks
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
            return $"{parent.Path()}/jwks";
        }

        /// <summary>
        ///     Returns the signing key(s) in JWK Set format. Client use it to validate signatures of any JWT
        ///     (e.g. OpenID Connect ID Token) issued by the Authorization Server
        ///     (see [RFC-7517](https://www.rfc-editor.org/rfc/rfc7517.html#section-5))
        ///     HTTP Method: get
        ///     Endpoint: /restapi/oauth/jwks
        ///     Rate Limit Group: NoThrottling
        /// </summary>
        public async Task<JWKeySet> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<JWKeySet>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Jwks.Index Jwks()
        {
            return new Jwks.Index(this);
        }
    }
}