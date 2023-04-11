namespace RingCentral.Paths.Ai.Audio
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

        public string Path()
        {
            return $"{parent.Path()}/audio";
        }
    }
}

namespace RingCentral.Paths.Ai
{
    public partial class Index
    {
        public Audio.Index Audio()
        {
            return new Audio.Index(this);
        }
    }
}