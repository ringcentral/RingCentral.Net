namespace RingCentral.Paths.Ai.Ringsense
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
            return $"{parent.Path()}/ringsense";
        }
    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Ringsense.Index Ringsense()
        {
            return new Ringsense.Index(this);
        }
    }
}