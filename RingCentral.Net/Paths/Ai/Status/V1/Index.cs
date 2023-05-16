namespace RingCentral.Paths.Ai.Status.V1
{
    public partial class Index
    {
        public Status.Index parent;
        public RestClient rc;

        public Index(Status.Index parent)
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

namespace RingCentral.Paths.Ai.Status
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}