using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Authorize
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
            return $"{parent.Path()}/authorize";
        }

        /// <summary>
        ///     Performs Authentication of the End-User by sending the User Agent to the Authorization Server's
        ///     Authorization Endpoint for Authentication and Authorization,
        ///     using request parameters defined by OAuth 2.0 [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-3.1)
        ///     and additional parameters and parameter values defined by
        ///     [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#AuthorizationEndpoint).
        ///     This is the version that uses HTTP `GET` method.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/oauth/authorize
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Get(AuthorizeParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Performs Authentication of the End-User by sending the User Agent to the Authorization Server's
        ///     Authorization Endpoint for Authentication and Authorization,
        ///     using request parameters defined by OAuth 2.0 [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-3.1)
        ///     and additional parameters and parameter values defined by
        ///     [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#AuthorizationEndpoint).
        ///     This is the version that uses HTTP `POST` method.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/authorize
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(AuthorizeRequest authorizeRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new Dictionary<string, string>();
            Utils.GetPairs(authorizeRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(Path(), new FormUrlEncodedContent(dict), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Authorize.Index Authorize()
        {
            return new Authorize.Index(this);
        }
    }
}