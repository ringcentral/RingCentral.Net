using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.WellKnown.OpenidConfiguration
{
    public partial class Index
    {
        public RestClient rc;
public WellKnown.Index parent;
public Index(WellKnown.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/openid-configuration";
        }
        /// <summary>
        /// Returns OpenID Connect provider configuration.
/// 
/// This endpoint follows the [OpenID Connect Discovery 1.0](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata) specification.
/// It provides a mechanism for an OpenID Connect Relying Party to discover the End-User's OpenID Provider and obtain information
/// needed to interact with it, including its OAuth 2.0 endpoint locations.
/// 
        /// HTTP Method: get
        /// Endpoint: /.well-known/openid-configuration
        /// Rate Limit Group: NoThrottling
        /// </summary>
  public async Task<RingCentral.OpenIdDiscovery> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.OpenIdDiscovery>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.WellKnown
{
    public partial class Index
    {
        public WellKnown.OpenidConfiguration.Index OpenidConfiguration()
        {
            return new WellKnown.OpenidConfiguration.Index(this);
        }
    }
}