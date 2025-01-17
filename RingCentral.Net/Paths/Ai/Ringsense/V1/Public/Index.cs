namespace RingCentral.Paths.Ai.Ringsense.V1.Public
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/public";
        }
    }
}

namespace RingCentral.Paths.Ai.Ringsense.V1
{
    public partial class Index
    {
        public Public.Index Public()
        {
            return new Public.Index(this);
        }
    }
}