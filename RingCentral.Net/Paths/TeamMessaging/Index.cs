namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public RestClient rc;
        public string version;

        public Index(RestClient rc, string version = "v1")
        {
            this.rc = rc;
            this.version = version;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && version != null) return $"/team-messaging/{version}";
            return "/team-messaging";
        }
    }
}