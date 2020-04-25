using System.Threading.Tasks;
using System.Threading;
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
        /// Operation: Revoke Token
        /// Http Post /restapi/oauth/revoke
        /// </summary>
        public async Task<string> Post(RevokeTokenRequest revokeTokenRequest,
            CancellationToken? cancellationToken = null)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            RingCentral.Utils.GetPairs(revokeTokenRequest)
                .ToList().ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(this.Path(), new FormUrlEncodedContent(dict), null, cancellationToken);
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