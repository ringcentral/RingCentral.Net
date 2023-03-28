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

        public string Path()
        {
            return $"{parent.Path()}/authorize";
        }

        /// <summary>
        ///     Performs OAuth 2.0 authorization (GET version)
        ///     HTTP Method: get
        ///     Endpoint: /restapi/oauth/authorize
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Performs OAuth 2.0 authorization (POST version)
        ///     HTTP Method: post
        ///     Endpoint: /restapi/oauth/authorize
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<string> Post(AuthorizeRequest authorizeRequest, RestRequestConfig restRequestConfig = null)
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