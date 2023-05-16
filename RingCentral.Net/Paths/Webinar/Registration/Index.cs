namespace RingCentral.Paths.Webinar.Registration
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
            return $"{parent.Path()}/registration";
        }
    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Registration.Index Registration()
        {
            return new Registration.Index(this);
        }
    }
}