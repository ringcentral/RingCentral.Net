namespace RingCentral.Paths.Rcvideo.History
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
            return $"{parent.Path()}/history";
        }
    }
}

namespace RingCentral.Paths.Rcvideo
{
    public partial class Index
    {
        public History.Index History()
        {
            return new History.Index(this);
        }
    }
}