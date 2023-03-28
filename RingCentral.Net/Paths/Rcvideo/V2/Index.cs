namespace RingCentral.Paths.Rcvideo.V2
{
    public partial class Index
    {
        public Rcvideo.Index parent;
        public RestClient rc;

        public Index(Rcvideo.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/v2";
        }
    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public V2.Index V2()
        {
            return new V2.Index(this);
        }
    }
}