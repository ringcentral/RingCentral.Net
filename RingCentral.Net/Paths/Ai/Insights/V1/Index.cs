namespace RingCentral.Paths.Ai.Insights.V1
{
    public partial class Index
    {
        public Insights.Index parent;
        public RestClient rc;

        public Index(Insights.Index parent)
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

namespace RingCentral.Paths.Ai.Insights
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}