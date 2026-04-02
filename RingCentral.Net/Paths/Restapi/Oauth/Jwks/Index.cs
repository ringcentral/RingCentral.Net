using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Jwks
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
            return $"{parent.Path()}/jwks";
        }
        /// <summary>
        /// Returns the signing key(s) in JWK Set format. Client use it to validate signatures of any JWT
/// (e.g. OpenID Connect ID Token) issued by the Authorization Server
/// (see [RFC-7517](https://www.rfc-editor.org/rfc/rfc7517.html#section-5))
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/oauth/jwks
        /// Rate Limit Group: NoThrottling
        /// </summary>
  public async Task<RingCentral.JWKeySet> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.JWKeySet>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Jwks.Index Jwks()
        {
            return new Restapi.Oauth.Jwks.Index(this);
        }
    }
}