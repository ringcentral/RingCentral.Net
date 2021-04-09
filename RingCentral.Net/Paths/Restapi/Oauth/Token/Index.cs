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

        public string Path()
        {
            return $"{parent.Path()}/token";
        }

        /// <summary>
        ///     Returns access tokens for making API requests
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