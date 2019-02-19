using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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

        public async Task<string> Post(RevokeTokenRequest revokeTokenRequest)
        {
            var dict = new System.Collections.Generic.Dictionary<string, string>();
            revokeTokenRequest.GetType().GetProperties()
                .Select(p => (name: p.Name, value: p.GetValue(revokeTokenRequest)))
                .Concat(revokeTokenRequest.GetType().GetFields()
                    .Select(p => (name: p.Name, value: p.GetValue(revokeTokenRequest))))
                .Where(t => t.value != null).ToList()
                .ForEach(t => dict.Add(t.name, t.value.ToString()));
            return await rc.Post<string>(this.Path(), new FormUrlEncodedContent(dict));
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