namespace RingCentral.Paths.Ai.Audio.V1.Async
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
            return $"{parent.Path()}/async";
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1
{
    public partial class Index
    {
        public Async.Index Async()
        {
            return new Async.Index(this);
        }
    }
}