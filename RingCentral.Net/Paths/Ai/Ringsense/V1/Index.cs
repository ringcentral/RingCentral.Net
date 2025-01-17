namespace RingCentral.Paths.Ai.Ringsense.V1
{
    public partial class Index
    {
        public Ringsense.Index parent;
        public RestClient rc;

        public Index(Ringsense.Index parent)
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

namespace RingCentral.Paths.Ai.Ringsense
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}