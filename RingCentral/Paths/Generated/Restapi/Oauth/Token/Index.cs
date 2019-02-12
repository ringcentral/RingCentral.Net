using System.Threading.Tasks;

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

        public async Task<RingCentral.TokenInfo> Post()
        {
            return await rc.Post<RingCentral.TokenInfo>(this.Path());
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