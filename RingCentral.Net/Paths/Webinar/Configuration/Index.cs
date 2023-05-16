namespace RingCentral.Paths.Webinar.Configuration
{
    public partial class Index
    {
        public Webinar.Index parent;
        public RestClient rc;

        public Index(Webinar.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/configuration";
        }
    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Configuration.Index Configuration()
        {
            return new Configuration.Index(this);
        }
    }
}