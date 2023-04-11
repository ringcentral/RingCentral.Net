namespace RingCentral.Paths.Webinar.Registration.V1
{
    public partial class Index
    {
        public Registration.Index parent;
        public RestClient rc;

        public Index(Registration.Index parent)
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

namespace RingCentral.Paths.Webinar.Registration
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}