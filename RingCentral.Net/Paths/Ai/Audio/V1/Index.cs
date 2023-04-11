namespace RingCentral.Paths.Ai.Audio.V1
{
    public partial class Index
    {
        public Audio.Index parent;
        public RestClient rc;

        public Index(Audio.Index parent)
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

namespace RingCentral.Paths.Ai.Audio
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}