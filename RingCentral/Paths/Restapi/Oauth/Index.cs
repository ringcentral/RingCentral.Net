namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/oauth";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.Oauth.Index Oauth()
        {
            return new Restapi.Oauth.Index(this);
        }
    }
}