namespace RingCentral.Paths.Webinar.History
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

        public string Path()
        {
            return $"{parent.Path()}/history";
        }
    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public History.Index History()
        {
            return new History.Index(this);
        }
    }
}