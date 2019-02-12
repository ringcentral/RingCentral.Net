using System.Threading.Tasks;

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

        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
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