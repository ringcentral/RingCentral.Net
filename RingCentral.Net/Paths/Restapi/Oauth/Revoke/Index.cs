using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Oauth.Revoke
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
            return $"{parent.Path()}/revoke";
        }

        /// <summary>
        /// Revokes access/refresh token. Requests to this endpoint must be authenticated with HTTP Basic scheme using the application key and application secret as login and password, correspondingly.
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/revoke
        /// Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(RingCentral.RevokeTokenRequest revokeTokenRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            Utils.GetPairs(revokeTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(this.Path(), new FormUrlEncodedContent(dict), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Oauth.Revoke.Index Revoke()
        {
            return new Restapi.Oauth.Revoke.Index(this);
        }
    }
}