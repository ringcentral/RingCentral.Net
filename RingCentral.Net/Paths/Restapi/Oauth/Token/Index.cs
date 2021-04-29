using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Token
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

        public string Path()
        {
            return $"{parent.Path()}/token";
        }

        /// <summary>
        /// Returns access tokens for making API requests
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/token
        /// Rate Limit Group: Auth
        /// </summary>
        public async Task<RingCentral.TokenInfo> Post(RingCentral.GetTokenRequest getTokenRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            Utils.GetPairs(getTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<RingCentral.TokenInfo>(this.Path(), new FormUrlEncodedContent(dict), null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Token.Index Token()
        {
            return new Restapi.Oauth.Token.Index(this);
        }
    }
}