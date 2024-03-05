using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Introspect
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
            return $"{parent.Path()}/introspect";
        }

        /// <summary>
        ///     Determines state and metadata for a given token (access token, refresh token
        ///     or authorization code)
        ///     Depending on client application type
        ///     requests to this endpoint may require authentication with HTTP Basic scheme
        ///     using registered client ID and client secret as login and password, correspondingly.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/introspect
        ///     Rate Limit Group: Auth
        ///     App Permission: Interoperability
        /// </summary>
        public async Task<TokenIntrospectionResponse> Post(IntrospectTokenRequest introspectTokenRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new Dictionary<string, string>();
            Utils.GetPairs(introspectTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<TokenIntrospectionResponse>(Path(), new FormUrlEncodedContent(dict), null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Introspect.Index Introspect()
        {
            return new Introspect.Index(this);
        }
    }
}