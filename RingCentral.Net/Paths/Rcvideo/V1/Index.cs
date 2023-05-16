namespace RingCentral.Paths.Rcvideo.V1
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public V1.Index V1()
        {
            return new V1.Index(this);
        }
    }
}