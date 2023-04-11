namespace RingCentral.Paths.Rcvideo.V1.History
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

        public string Path()
        {
            return $"{parent.Path()}/history";
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1
{
    public partial class Index
    {
        public History.Index History()
        {
            return new History.Index(this);
        }
    }
}