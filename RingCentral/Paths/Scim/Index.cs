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
            if (version != null)
            {
                return $"/scim/{version}";
            }

            return "/scim";
        }

        public Scim.ServiceProviderConfig.Index ServiceProviderConfig()
        {
            return new Scim.ServiceProviderConfig.Index(this);
        }

        public Scim.Health.Index Health()
        {
            return new Scim.Health.Index(this);
        }

        public Scim.Users.Index Users(string id = null)
        {
            return new Scim.Users.Index(this, id);
        }
    }
}