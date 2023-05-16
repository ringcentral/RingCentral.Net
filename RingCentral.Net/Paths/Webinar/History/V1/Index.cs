namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public History.Index parent;
        public RestClient rc;

        public Index(History.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Webinar.History
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}