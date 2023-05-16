namespace RingCentral.Paths.Analytics.Calls.V1
{
    public partial class Index
    {
        public Calls.Index parent;
        public RestClient rc;

        public Index(Calls.Index parent)
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

namespace RingCentral.Paths.Analytics.Calls
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}