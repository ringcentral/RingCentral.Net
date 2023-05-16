namespace RingCentral.Paths.Ai.Text
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
            return $"{parent.Path()}/text";
        }
    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Text.Index Text()
        {
            return new Text.Index(this);
        }
    }
}