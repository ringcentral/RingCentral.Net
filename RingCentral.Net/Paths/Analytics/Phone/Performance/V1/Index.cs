namespace RingCentral.Paths.Analytics.Phone.Performance.V1
{
    public partial class Index
    {
        public Performance.Index parent;
        public RestClient rc;

        public Index(Performance.Index parent)
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

namespace RingCentral.Paths.Analytics.Phone.Performance
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}