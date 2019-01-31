namespace RingCentral.Paths.Scim
{
    public class Index
    {
        public RestClient rc;
        public string version;

        public Index(RestClient rc, string version = "v2")
        {
            this.rc = rc;
            this.version = version;
        }

        public string Path()
        {
            return $"/scim/{version}";
        }

        public Scim.ServiceProviderConfig.Index ServiceProviderConfig()
        {
            return new Scim.ServiceProviderConfig.Index(this);
        }
    }
}