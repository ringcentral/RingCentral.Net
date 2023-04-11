namespace RingCentral.Paths.Ai.Text.V1
{
    public partial class Index
    {
        public Text.Index parent;
        public RestClient rc;

        public Index(Text.Index parent)
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

namespace RingCentral.Paths.Ai.Text
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}