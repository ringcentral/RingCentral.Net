using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.Revoke
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
            return $"{parent.Path()}/revoke";
        }

        /// <summary>
        ///     Revokes access/refresh token. Requests to this endpoint must be authenticated with HTTP Basic scheme using the
        ///     application key and application secret as login and password, correspondingly.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/revoke
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(RevokeTokenRequest revokeTokenRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var dict = new Dictionary<string, string>();
            Utils.GetPairs(revokeTokenRequest).ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(Path(), new FormUrlEncodedContent(dict), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Revoke.Index Revoke()
        {
            return new Revoke.Index(this);
        }
    }
}