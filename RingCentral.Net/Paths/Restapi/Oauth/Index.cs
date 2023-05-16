namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public Restapi.Index parent;
        public RestClient rc;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/oauth";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Oauth.Index Oauth()
        {
            return new Oauth.Index(this);
        }
    }
}