namespace RingCentral.Paths.Ai.Status
{
    public partial class Index
    {
        public Ai.Index parent;
        public RestClient rc;

        public Index(Ai.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/status";
        }
    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Status.Index Status()
        {
            return new Status.Index(this);
        }
    }
}