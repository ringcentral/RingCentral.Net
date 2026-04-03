using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Authorize
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
            return $"{parent.Path()}/authorize";
        }
        /// <summary>
        /// Performs Authentication of the End-User by sending the User Agent to the Authorization Server's
        /// Authorization Endpoint for Authentication and Authorization,
        /// using request parameters defined by OAuth 2.0 [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-3.1)
        /// and additional parameters and parameter values defined by
        /// [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#AuthorizationEndpoint).
        /// 
        /// This is the version that uses HTTP `GET` method.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/oauth/authorize
        /// Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Get(RingCentral.AuthorizeParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Performs Authentication of the End-User by sending the User Agent to the Authorization Server's
        /// Authorization Endpoint for Authentication and Authorization,
        /// using request parameters defined by OAuth 2.0 [RFC-6749](https://datatracker.ietf.org/doc/html/rfc6749#section-3.1)
        /// and additional parameters and parameter values defined by
        /// [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#AuthorizationEndpoint).
        /// 
        /// This is the version that uses HTTP `POST` method and requires a request body instead of query parameters.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/authorize
        /// Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(RingCentral.AuthorizeRequest authorizeRequest, RestRequestConfig restRequestConfig = null)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            Utils.GetPairs(authorizeRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(this.Path(), new FormUrlEncodedContent(dict), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Authorize.Index Authorize()
        {
            return new Restapi.Oauth.Authorize.Index(this);
        }
    }
}