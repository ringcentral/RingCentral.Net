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

        public string Path()
        {
            return $"{parent.Path()}/authorize";
        }

        /// <summary>
        /// Returns a link to a login page location.
        /// HTTP Method: post
        /// Endpoint: /restapi/oauth/authorize
        /// </summary>
        public async Task<string> Post(RingCentral.AuthorizeRequest authorizeRequest,
            RestRequestConfig restRequestConfig = null)
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