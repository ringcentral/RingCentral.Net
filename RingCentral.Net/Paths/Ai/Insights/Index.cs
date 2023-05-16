namespace RingCentral.Paths.Ai.Insights
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
            return $"{parent.Path()}/insights";
        }
    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Insights.Index Insights()
        {
            return new Insights.Index(this);
        }
    }
}