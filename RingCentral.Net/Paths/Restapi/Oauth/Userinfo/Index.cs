using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Userinfo
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
            return $"{parent.Path()}/userinfo";
        }

        /// <summary>
        ///     OpenID Connect User Info endpoint, as defined by [OpenID Connect Core
        ///     1.0](https://openid.net/specs/openid-connect-core-1_0.html#UserInfo) specification.
        ///     It returns Claims about the authenticated End-User.
        ///     This is the version that uses HTTP `GET` method.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/oauth/userinfo
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<UserInfoResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserInfoResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Userinfo.Index Userinfo()
        {
            return new Userinfo.Index(this);
        }
    }
}