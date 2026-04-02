using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Userinfo
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
            return $"{parent.Path()}/userinfo";
        }
        /// <summary>
        /// OpenID Connect User Info endpoint, as defined by [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#UserInfo) specification.
/// It returns Claims about the authenticated End-User.
/// 
/// This is the version that uses HTTP `GET` method.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/oauth/userinfo
        /// Rate Limit Group: Auth
        /// </summary>
  public async Task<RingCentral.UserInfoResource> Get(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.UserInfoResource>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Userinfo.Index Userinfo()
        {
            return new Restapi.Oauth.Userinfo.Index(this);
        }
    }
}