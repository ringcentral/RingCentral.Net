namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Configuration.Index parent;
        public RestClient rc;

        public Index(Configuration.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}