namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public RestClient rc;
        public string version;
        public Index(RestClient rc, string version = "v2")
        {
            this.rc = rc;
            this.version = version;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && version != null)
            {
                return $"/scim/{version}";
            }

            return "/scim";
        }
    }
}

namespace RingCentral
{
    public partial class RestClient
    {
        public Paths.Scim.Index Scim(string version = "v2")
        {
            return new Paths.Scim.Index(this, version);
        }
    }
}